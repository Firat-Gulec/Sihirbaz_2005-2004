Imports Sihirbaz.fnct
Imports Sihirbaz.prcd

Public Class Siparis
    Friend WithEvents dgvcolImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgvcolCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvcolModel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMarka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolCelKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMlzKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipMik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipTar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipDur As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvcolAciklama As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub InitDgvCols()
        Me.dgvcolImage = New System.Windows.Forms.DataGridViewImageColumn
        Me.dgvcolCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgvcolModel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMarka = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolCelKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMlzKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipMik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipTar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipDur = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgvcolAciklama = New System.Windows.Forms.DataGridViewTextBoxColumn
        '
        'dgvcolImage
        '
        Me.dgvcolImage.HeaderText = "Image"
        Me.dgvcolImage.Name = "dgvcolImage"
        '
        'dgvcolCheck
        '
        Me.dgvcolCheck.HeaderText = "Check"
        Me.dgvcolCheck.Name = "dgvcolCheck"
        '
        'dgvcolModel
        '
        Me.dgvcolModel.HeaderText = "Model"
        Me.dgvcolModel.Name = "dgvcolModel"
        '
        'dgvcolMarka
        '
        Me.dgvcolMarka.HeaderText = "Marka"
        Me.dgvcolMarka.Name = "dgvcolMarka"
        '
        'dgvcolCelKod
        '
        Me.dgvcolCelKod.HeaderText = "Çelebi Kodu"
        Me.dgvcolCelKod.Name = "dgvcolCelKod"
        '
        'dgvcolMlzKod
        '
        Me.dgvcolMlzKod.HeaderText = "Malzeme Kodu"
        Me.dgvcolMlzKod.Name = "dgvcolMlzKod"
        '
        'dgvcolSipKod
        '
        Me.dgvcolSipKod.HeaderText = "Sipariþ Kodu"
        Me.dgvcolSipKod.Name = "dgvcolSipKod"
        '
        'dgvcolSipMik
        '
        Me.dgvcolSipMik.HeaderText = "Sipariþ Miktarý"
        Me.dgvcolSipMik.Name = "dgvcolSipMik"
        '
        'dgvcolSipTar
        '
        Me.dgvcolSipTar.HeaderText = "Sipariþ Tarihi"
        Me.dgvcolSipTar.Name = "dgvcolSipTar"
        '
        'dgvcolSipDur
        '
        Me.dgvcolSipDur.HeaderText = "Sipariþ Durumu"
        Me.dgvcolSipDur.Name = "dgvcolSipDur"
        '
        'dgvcolAciklama
        '
        Me.dgvcolAciklama.HeaderText = "Açýklama"
        Me.dgvcolAciklama.Name = "dgvcolAciklama"
    End Sub

    Private Sub btnNext_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseClick

        btns_Next_Click()
    End Sub

    Private Sub btnBack_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnBack.MouseClick
        btns_Back_Click()
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
        Me.btnNext.Text = "Ýleri"
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    Public Sub Siparis_Load()
        p_ConnectServer(dsCelebi, "marka", "SELECT * FROM marka")
        p_ConnectServer(dsCelebi, "malzeme", "SELECT * FROM malzeme")
        Form.lblPageName.Text = "Sipariþ Giriþi"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\SiparisLogo.png")
        bsMarka.Sort = "id asc"
        Me.cmbMarka.DataSource = bsMarka
        Me.cmbMarka.DisplayMember = "Ad"
        Me.cmbModel.DataSource = bsMalzeme
        Me.cmbModel.DisplayMember = "Ad"
        Me.cmbCelKod.DataSource = bsMalzeme
        Me.cmbCelKod.DisplayMember = "celebi_kodu"
        Me.cmbMlzKod.DataSource = bsMalzeme
        Me.cmbMlzKod.DisplayMember = "malzeme_kodu"
        Me.cmbSipKod.DataSource = bsMalzeme
        Me.cmbSipKod.DisplayMember = "siparis_kodu"
        bsMalzeme.Filter = "marka_id=" & Me.cmbMarka.SelectedIndex + 1
        InitDgvCols()
        If Rapor.dgvRapor.ColumnCount = 0 Then
            Rapor.dgvRapor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn(10) {Me.dgvcolImage, _
                                                                                            Me.dgvcolCheck, _
                                                                                            Me.dgvcolModel, _
                                                                                            Me.dgvcolMarka, _
                                                                                            Me.dgvcolCelKod, _
                                                                                            Me.dgvcolMlzKod, _
                                                                                            Me.dgvcolSipKod, _
                                                                                            Me.dgvcolSipMik, _
                                                                                            Me.dgvcolSipTar, _
                                                                                            Me.dgvcolSipDur, _
                                                                                            Me.dgvcolAciklama})
        End If




    End Sub

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click
        Me.dtpSipTar.CustomFormat = "MM/dd/yyyy"
        Rapor.dgvRapor.Rows.Add()
        Rapor.dgvRapor.Rows(Rapor.dgvRapor.RowCount - 1).SetValues(Image.FromFile(CurDir.ToString & "\Skins\Default\Images\TaskPaneDownOver.png"), True, _
                                        Me.cmbModel.Text.ToString, Me.cmbMarka.Text.ToString, Me.cmbCelKod.Text.ToString, _
                                        Me.cmbMlzKod.Text.ToString, Me.cmbSipKod.Text.ToString, Me.nudSipMik.Value.ToString, _
                                        Me.dtpSipTar.Text, Me.chkSipDur.Checked, Me.txtAciklama.Text.ToString)
        Me.dtpSipTar.CustomFormat = "dd MMMM yyyy dddd"
    End Sub

    
    Private Sub cmbMarka_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMarka.SelectedIndexChanged
        bsMalzeme.Filter = "marka_id=" & Me.cmbMarka.SelectedIndex + 1
    End Sub

   
End Class