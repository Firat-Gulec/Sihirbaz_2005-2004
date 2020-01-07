Imports Sihirbaz.prcd
Imports Sihirbaz.fnct

Public Class Login
    Public v_diz() As String = New String(4) {"hmoptSiparis", "hmoptStkGrs", "hmoptStkKul", "hmoptCepStkGrs", "hmoptCepStkKul"}
    Public v_opac As String
    Public v_x, v_y As Integer




    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case v_opac
            Case "Close"
                If Me.Opacity > 0 Then
                    Me.Opacity -= 0.04
                Else
                    Me.Close()
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
                            btnCancel.MouseLeave, btnNext.MouseLeave
        sender.Font = New Font("Calibri", 10, FontStyle.Bold + FontStyle.Italic, GraphicsUnit.Point)
    End Sub

    Private Sub Mouse_Move(ByVal Sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _
                            btnCancel.MouseMove, btnNext.MouseMove
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.SelectedIndex = 0 Then
            Me.GroupBox1.Enabled = False
        Else
            Me.GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If Me.ComboBox1.SelectedIndex = 0 Then
            Me.Panel2.Enabled = True
            Me.Panel3.Enabled = True
        Else
            Me.Panel2.Enabled = False
            Me.Panel3.Enabled = False
        End If
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ComboBox1.SelectedIndex = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "DataSource", "")
        Me.TextBox4.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "ServerName", "")
        Me.TextBox1.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "DatabaseFileName", "")
        Me.ComboBox2.SelectedIndex = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "Authentication", "")
        Me.TextBox2.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "UserName", "")
        Me.TextBox3.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "Password", "")
        Me.v_opac = "Normal"
        Timer1.Enabled = True
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Me.CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "DataSource", _
                            Me.ComboBox1.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "ServerName", _
                            Me.TextBox4.Text, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "DatabaseFileName", _
                            Me.TextBox1.Text, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "Authentication", _
                            Me.ComboBox2.SelectedIndex, Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "UserName", _
                            Me.TextBox2.Text, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo\Settings", "Password", _
                            Me.TextBox3.Text, Microsoft.Win32.RegistryValueKind.String)
            
        End If
        If Me.ComboBox2.SelectedIndex = 0 Then
            constr = "Data Source=" & Me.TextBox4.Text & ";Initial Catalog=" & Me.TextBox1.Text & ";Integrated Security=True"
        Else
            constr = "Data Source=" & Me.TextBox4.Text & ";Initial Catalog=" & Me.TextBox1.Text & _
                ";Persist Security Info=True;User ID=" & Me.TextBox2.Text & ";Password=" & Me.TextBox3.Text & ""
        End If
        Me.Hide()
        Form.Show()
    End Sub
End Class