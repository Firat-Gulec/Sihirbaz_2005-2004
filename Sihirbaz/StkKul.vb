Imports Sihirbaz.fnct
Imports Sihirbaz.prcd

Public Class StkKul
    Friend WithEvents dgvcolImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgvcolCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvcolModel As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents dgvcolMarka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolCelKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMlzKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolKulTar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolAciklama As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub InitDgvCols()
        Me.dgvcolImage = New System.Windows.Forms.DataGridViewImageColumn
        Me.dgvcolCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgvcolModel = New System.Windows.Forms.DataGridViewTextBoxColumn
        'Me.dgvcolMarka = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolCelKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMlzKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolKulTar = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        'Me.dgvcolMarka.HeaderText = "Marka"
        'Me.dgvcolMarka.Name = "dgvcolMarka"
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
        'dgvcolMik
        '
        Me.dgvcolMik.HeaderText = "Miktar"
        Me.dgvcolMik.Name = "dgvcolMik"
        '
        'dgvcolKulTar
        '
        Me.dgvcolKulTar.HeaderText = "Kullaným Tarihi"
        Me.dgvcolKulTar.Name = "dgvcolKulTar"
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

    Public Sub StkKul_Load()
        p_ConnectServer(dsCelebi, "marka", "SELECT * FROM marka")
        p_ConnectServer(dsCelebi, "malzeme", "SELECT * FROM malzeme")
        Form.lblPageName.Text = "Stok Kullanýmý"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\StokKullanimLogo.png")
        Me.cmbModel.DataSource = bsMalzeme
        Me.cmbModel.DisplayMember = "Ad"
        Me.cmbCelKod.DataSource = bsMalzeme
        Me.cmbCelKod.DisplayMember = "celebi_kodu"
        Me.cmbMlzKod.DataSource = bsMalzeme
        Me.cmbMlzKod.DisplayMember = "malzeme_kodu"
        Me.cmbSipKod.DataSource = bsMalzeme
        Me.cmbSipKod.DisplayMember = "siparis_kodu"
        InitDgvCols()
        If Rapor.dgvRapor.ColumnCount = 0 Then
            Rapor.dgvRapor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { _
                                Me.dgvcolImage, Me.dgvcolCheck, Me.dgvcolModel, Me.dgvcolCelKod, _
                                Me.dgvcolMlzKod, Me.dgvcolSipKod, Me.dgvcolMik, _
                                Me.dgvcolKulTar, Me.dgvcolAciklama})
        End If
    End Sub

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click
        Me.dtpKulTar.CustomFormat = "MM/dd/yyyy"
        Rapor.dgvRapor.Rows.Add()
        Rapor.dgvRapor.Rows(Rapor.dgvRapor.RowCount - 1).SetValues(Image.FromFile(CurDir.ToString & "\Skins\Default\Images\TaskPaneDownOver.png"), True, _
                                Me.cmbModel.Text.ToString, Me.cmbCelKod.Text.ToString, _
                                Me.cmbMlzKod.Text.ToString, Me.cmbSipKod.Text.ToString, _
                                Me.nudmik.Value.ToString, Me.dtpKulTar.Text, Me.txtaciklama.Text.ToString)
        Me.dtpKulTar.CustomFormat = "dd  MMMM  yyyy  dddd"
    End Sub
End Class