Imports Sihirbaz.fnct
Imports Sihirbaz.prcd
Imports System.Data.SqlClient

Public Class Garanti

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click
        btns_Next_Click()

        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(0).Cells(2).Value & "'")
        Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")
        komut.Connection = conn
        komut.CommandType = CommandType.StoredProcedure
        komut.CommandText = "p_grnt"
        conn.Open()
        Try
            With komut.Parameters

                .Add("@malzeme_id", SqlDbType.VarChar).Value = mlzid
                .Add("@personel_id", SqlDbType.VarChar).Value = perid
                .Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text
                .Add("@etiket_no", SqlDbType.BigInt).Value = txtEtkNo.Text
                .Add("@miktar", SqlDbType.BigInt).Value = nudMik.Text
                .Add("@tarih", SqlDbType.BigInt).Value = dtpTar.Text
                .Add("@durum", SqlDbType.BigInt).Value = chkDur.Text
            End With
            komut.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        p_ConnectServer(dsCelebi, "malzeme", "select * from malzeme")
        Me.cmbModel.Text = ""
        Me.cmbCelKod.Text = ""
        Me.cmbMlzKod.Text = ""
        Me.cmbSipKod.Text = ""
        Me.txtEtkNo.Text = "0"
        Me.nudMik.Text = "0"
        Me.txtAciklama.Text = ""
        Me.chkDur.Checked = False
    End Sub
End Class