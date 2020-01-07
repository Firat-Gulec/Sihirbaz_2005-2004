Imports Sihirbaz.fnct
Imports Sihirbaz.prcd
Imports System.Data.SqlClient

Public Class Personel


    Dim down As Boolean
    Dim cins As Boolean

    Private Sub Button1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
                        optBay.KeyUp, optBayan.KeyUp
        If e.KeyCode = Keys.Space Then
            down = False
            p_OptionSelect(sender, "Up", down)
            p_OptionSelect(sender, "Leave", down)
            If sender.name = "optBay" Then
                cins = False
            ElseIf sender.name = "optBayan" Then
                cins = True
            End If
        End If


    End Sub

    Private Sub Option_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                       optBay.MouseClick, optBayan.MouseClick
        down = False
        p_OptionSelect(sender, "Up", down)
        If sender.name = "optBay" Then
            cins = False
        ElseIf sender.name = "optBayan" Then
            cins = True
        End If
    End Sub

    Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                        optBay.MouseDown, optBayan.MouseDown
        down = True
        p_OptionSelect(sender, "Down", down)
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
                        optBay.MouseLeave, optBayan.MouseLeave
        p_OptionSelect(sender, "Leave", down)
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                        optBay.MouseMove, optBayan.MouseMove
        p_OptionSelect(sender, "Over", down)
    End Sub

    Private Sub btnNext_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseClick
        v_animyon = "Up"
        p_WizAnim()
        Home.Home_Load()
        p_CtrlCopy(Home.pnlHome, Form.pnlPages)
        p_CtrlCopy(Home.pnlStatusBar, Form.pnlButtons)
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

    Public Sub Personel_Load()
        Me.txtAd.Text = ""
        Me.TxtSoyad.Text = ""
        Me.txtTckno.Text = ""
        Me.TxtTel.Text = ""
        Me.txtAdres.Text = ""
        Me.txtAciklama.Text = ""
        Me.optBay.Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormal.png")
        Me.optBayan.Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormal.png")
        Me.optBay.AutoEllipsis = False
        Me.optBayan.AutoEllipsis = False

        Me.cmbKang.DataSource = bsKan
        Me.cmbKang.DisplayMember = "grup"
        Form.lblPageName.Text = "Personel Giriþi"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\People.png")
        Me.btnBack.Enabled = False
        Me.btnNext.Text = "Tamam"
    End Sub

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click

        Dim conn As New SqlConnection(constr)
        Dim da As New SqlDataAdapter
        conn.Open()
        Try
            If Me.txtAd.Text <> "" And Me.TxtSoyad.Text <> "" And Me.txtTckno.Text <> "" And Me.TxtTel.Text <> "" And Me.txtAdres.Text <> "" And Me.txtAciklama.Text <> "" And (Me.optBay.AutoEllipsis = True Or Me.optBayan.AutoEllipsis = True) Then
                Dim kang As Integer = f_GetID("SELECT id FROM kan_grup WHERE grup='" & cmbKang.Text & "'")
                da.InsertCommand = New SqlCommand( _
                                                "INSERT INTO personel " & _
                                                "VALUES ('" & txtAd.Text & _
                                                "','" & TxtSoyad.Text & _
                                                "'," & txtTckno.Text & _
                                                ",'" & cins & _
                                                "'," & TxtTel.Text & _
                                                "," & kang & _
                                                ",'" & txtAdres.Text & _
                                                "','" & txtAciklama.Text & _
                                                "')", conn)
                da.InsertCommand.ExecuteNonQuery()
            Else
                MessageBox.Show("Boþ alan býrakmayýn")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

    End Sub
End Class