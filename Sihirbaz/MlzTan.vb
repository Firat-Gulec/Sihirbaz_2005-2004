Imports Sihirbaz.fnct
Imports Sihirbaz.prcd
Imports System.Data.SqlClient

Public Class MlzTan
    Private Sub btnNext_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseClick
        v_animyon = "Up"
        p_WizAnim()
        StkGrs.StkGrs_Load()
        p_CtrlCopy(StkGrs.pnlStkGrs, Form.pnlPages)
        p_CtrlCopy(StkGrs.pnlStatusBar, Form.pnlButtons)
    End Sub

    Private Sub btnBack_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBack.MouseClick
        StkGrs.StkGrs_Load()
        p_CtrlCopy(StkGrs.pnlStkGrs, Form.pnlPages)
        p_CtrlCopy(StkGrs.pnlStatusBar, Form.pnlButtons)
    End Sub

    Private Sub Mouse_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
                               btnCancel.MouseLeave, btnBack.MouseLeave, btnNext.MouseLeave
        sender.Font = New Font("Calibri", 10, FontStyle.Bold + FontStyle.Italic, GraphicsUnit.Point)
    End Sub

    Private Sub Mouse_Move(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                            btnCancel.MouseMove, btnBack.MouseMove, btnNext.MouseMove
        Sender.Cursor = Cursors.Hand
        Sender.Font = New Font("Calibri", 11, FontStyle.Bold + FontStyle.Underline + FontStyle.Italic, GraphicsUnit.Point)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.btnNext.Text = "Tamam"
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    Public Sub MlzTan_Load()
        Me.cmbMarka.DataSource = bsMarka
        Me.cmbMarka.DisplayMember = "Ad"
        Form.lblPageName.Text = "Malzeme Tanýmlama"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\MalzemeTanimLogo.png")
        Me.btnBack.Enabled = False
        Me.btnNext.Text = "Tamam"
    End Sub

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click
       
        'Dim connstr As String = "Data Source=FREDD\SQLEXPRESS;Initial Catalog=celebi;integrated Security=True"
        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim markaid As Integer = f_GetID("SELECT id FROM marka WHERE ad='" & Me.cmbMarka.Text & "'")
        komut.Connection = conn
        komut.CommandType = CommandType.StoredProcedure
        komut.CommandText = "p_mlz"

        conn.Open()
        Try
            With komut.Parameters

                .Add("@model", SqlDbType.VarChar).Value = cmb.Text
                .Add("@celebi_kodu", SqlDbType.VarChar).Value = cmbCelKod.Text
                .Add("@mal_kodu", SqlDbType.VarChar).Value = cmbMlzKod.Text
                .Add("@sip_kod", SqlDbType.VarChar).Value = cmbSipKod.Text
                .Add("@marka", SqlDbType.BigInt).Value = markaid
                .Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text
                .Add("@sismiktar", SqlDbType.BigInt).Value = nudSisMik.Text
                .Add("@minmiktar", SqlDbType.BigInt).Value = nudMinMik.Text

            End With
            komut.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
        p_ConnectServer(dsCelebi, "malzeme", "select * from malzeme")
        Me.cmb.Text = ""
        Me.cmbCelKod.Text = ""
        Me.cmbMlzKod.Text = ""
        Me.cmbSipKod.Text = ""
        Me.nudMinMik.Text = "0"
        Me.nudSisMik.Text = "0"
        Me.txtAciklama.Text = ""

    End Sub
End Class