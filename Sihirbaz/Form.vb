Imports Sihirbaz.prcd
Imports Sihirbaz.fnct

Public Class Form
    Public v_diz() As String = New String(4) {"optSiparis", "optStkGrs", "optStkKul", "optCepStkGrs", "optCepStkKul"}
    Public v_opac As String
    Public v_x, v_y As Integer

    'Dim bbmp As Bitmap


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitComp()
        Home.Home_Load()
        Home.Home_Load1()
        Me.v_opac = "Normal"
        Timer1.Enabled = True
        p_CtrlCopy(Home.pnlHome, Me.pnlPages)
        p_CtrlCopy(Home.pnlStatusBar, Me.pnlButtons)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case v_opac
            Case "Close"
                If Me.Opacity > 0 Then
                    Me.Opacity -= 0.04
                Else
                    Application.Exit()
                End If

            Case "Normal"
                If Me.WindowState <> FormWindowState.Minimized Then
                    If Me.Opacity < 1 Then
                        Me.Opacity += 0.05
                    Else
                        Timer1.Enabled = False
                    End If
                End If
        End Select
    End Sub

    Private Sub pctClose_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pctClose.MouseMove
        pctClose.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\CloseOver.png")
    End Sub

    Private Sub pctClose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pctClose.MouseLeave
        On Error Resume Next
        pctClose.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\Close.png")
    End Sub

    Private Sub pctClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctClose.Click
        v_opac = "Close"
        Timer1.Enabled = True
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        v_opac = "Close"
        Timer1.Enabled = True
    End Sub

    Private Sub FormMove_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        v_x = e.X
        v_y = e.Y
    End Sub

    Private Sub FormMove_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Left += e.X - v_x
            Me.Top += e.Y - v_y
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        p_Anim()
        
    End Sub

End Class