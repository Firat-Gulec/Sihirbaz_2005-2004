Imports Sihirbaz.prcd
Imports Sihirbaz.fnct

Public Class Rapor

    Dim a As Integer
    Dim SelRow As Integer

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvRapor.CellBeginEdit
        dgvRapor.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
    End Sub

   

    Private Sub DataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvRapor.ColumnHeaderMouseClick
        p_DataGridColor(Me.dgvRapor)
        MsgBox(e.ColumnIndex)
    End Sub

    Private Sub DataGridView1_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRapor.RowLeave
        p_DataGridEditColor(Me.dgvRapor, e.RowIndex)
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvRapor.RowsAdded
        p_DataGridEditColor(Me.dgvRapor, dgvRapor.Rows.Count)
    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        p_DataGridColor(Me.dgvRapor)
    End Sub

    Private Sub btnNext_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseClick
        p_kayit_ekle()

    End Sub

    Private Sub btnBack_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBack.MouseClick
        v_animyon = "Right"
        p_WizAnim()
        frms_Load()
        p_CtrlCopy(Home.tmp(0), Form.pnlPages)
        p_CtrlCopy(Home.tmp(1), Form.pnlButtons)
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

    Public Sub Rapor_Load()
        Form.lblPageName.Text = "Rapor"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\RaporLogo.png")
        Me.btnNext.Text = "Son"
        p_DataGridColor(Me.dgvRapor)
        Me.dgvRapor.AutoResizeColumns()
    End Sub

End Class