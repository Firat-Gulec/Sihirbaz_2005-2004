Imports Sihirbaz.prcd
Imports Sihirbaz.fnct




Public Class Home
    Public Shared tmp() As Control = New Control(2) {Siparis.pnlSiparis, Siparis.pnlStatusBar, Siparis}

    Dim down As Boolean

    Private Sub Button1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _
                        optSiparis.KeyUp, optStkGrs.KeyUp, optStkKul.KeyUp, optCepStkGrs.KeyUp, optCepStkKul.KeyUp
        If e.KeyCode = Keys.Space Then
            down = False
            p_OptionSelect(sender, "Up", down)
            p_OptionSelect(sender, "Leave", down)
            p_WizardInfo(sender, Me.wbAnim, Me.lblInfo)
        End If
    End Sub

    Private Sub Option_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                        optSiparis.MouseClick, optStkGrs.MouseClick, optStkKul.MouseClick, optCepStkGrs.MouseClick, optCepStkKul.MouseClick
        down = False
        p_OptionSelect(sender, "Up", down)
        p_WizardInfo(sender, Me.wbAnim, Me.lblInfo)
        tmp = f_SelectedOpt(Me.grpOption, Form.v_diz)

    End Sub

    Private Sub Button5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                        optSiparis.MouseDown, optStkGrs.MouseDown, optStkKul.MouseDown, optCepStkGrs.MouseDown, optCepStkKul.MouseDown
        down = True
        p_OptionSelect(sender, "Down", down)
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
                        optSiparis.MouseLeave, optStkGrs.MouseLeave, optStkKul.MouseLeave, optCepStkGrs.MouseLeave, optCepStkKul.MouseLeave
        p_OptionSelect(sender, "Leave", down)
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                        optSiparis.MouseMove, optStkGrs.MouseMove, optStkKul.MouseMove, optCepStkGrs.MouseMove, optCepStkKul.MouseMove
        p_OptionSelect(sender, "Over", down)
    End Sub

    Private Sub ComboBox1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles cmbEleman.MeasureItem
        p_cmblstMeasureItem(e, 48, 48)
    End Sub

    Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cmbEleman.DrawItem
        Dim ccc As String
        If dsCelebi.Tables("personel").Rows(e.Index).Item(4) = True Then
            ccc = CurDir.ToString & "\Skins\Default\Images\Women.png"
        Else
            ccc = CurDir.ToString & "\Skins\Default\Images\Men.png"
        End If
        p_cmblstDrawItem(e, ccc, dsCelebi.Tables("personel").Rows(e.Index).Item(1).ToString.TrimEnd & " " & _
                                                      dsCelebi.Tables("personel").Rows(e.Index).Item(2).ToString.TrimEnd)
    End Sub


    Private Sub btnNext_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseClick
        Form.lblEleman.Text = f_UserName(dsCelebi, Me.cmbEleman)
        v_animyon = "Left"
        p_WizAnim()
        frms_Load()
        p_CtrlCopy(tmp(0), Form.pnlPages)
        p_CtrlCopy(tmp(1), Form.pnlButtons)
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
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    Public Sub Home_Load1()
        Me.optSiparis.Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionTick.png")
        Me.lblInfo.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "Siparis", "")
        Me.wbAnim.Url = New Uri(CurDir.ToString & "\Skins\Default\HTML\Siparis.htm")
       
    End Sub

    Public Sub Home_Load()
        p_ConnectServer(dsCelebi, "personel", "SELECT * FROM personel ORDER BY ad ASC")
        bsEleman.Sort = "ad ASC"
        Rapor.dgvRapor.Columns.Clear()
        Form.lblPageName.Text = "Depo Hareketleri"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\Logo.png")
        Form.lblEleman.Text = ""
        Me.btnBack.Enabled = False
        Me.btnNext.Text = "Ýleri"
        Me.cmbEleman.DataSource = bsEleman
        Me.cmbEleman.DisplayMember = "Ad"
    End Sub


    Private Sub grpOption_Paint1(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles grpOption.Paint
        DrawBorder(Me.grpOption)
    End Sub

    Private Sub btnPerEkl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerEkl.Click
        v_animyon = "Down"
        p_WizAnim()
        Personel.Personel_Load()
        p_CtrlCopy(Personel.pnlPersonel, Form.pnlPages)
        p_CtrlCopy(Personel.pnlStatusBar, Form.pnlButtons)
    End Sub
End Class