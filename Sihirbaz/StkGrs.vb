Imports Sihirbaz.prcd
Imports Sihirbaz.fnct

Public Class StkGrs
    Friend WithEvents dgvcolImage As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgvcolCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents dgvcolModel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMarka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolCelKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMlzKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolSipKod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolKrgEtkNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolMik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolFiyat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolGirTar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolFatNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolFatTar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcolAciklama As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub InitDgvCols()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvcolImage = New System.Windows.Forms.DataGridViewImageColumn
        Me.dgvcolCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgvcolModel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMarka = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolCelKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMlzKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolSipKod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolKrgEtkNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolMik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolFiyat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolGirTar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolFatNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcolFatTar = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        'dgvcolKrgEtkNo
        '
        Me.dgvcolKrgEtkNo.HeaderText = "Kargo Etiket No"
        Me.dgvcolKrgEtkNo.Name = "dgvcolKrgEtkNo"
        '
        'dgvcolMik
        '
        Me.dgvcolMik.HeaderText = "Miktar"
        Me.dgvcolMik.Name = "dgvcolMik"
        '
        'dgvcolFiyat
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvcolFiyat.DefaultCellStyle = datagridviewcellstyle1
        Me.dgvcolFiyat.HeaderText = "Fiyat"
        Me.dgvcolFiyat.Name = "dgvcolFiyat"
        '
        'dgvcolGirTar
        '
        Me.dgvcolGirTar.HeaderText = "Giriþ Tarihi"
        Me.dgvcolGirTar.Name = "dgvcolGirTar"
        '
        'dgvcolFatNo
        '
        Me.dgvcolFatNo.HeaderText = "Fatura No"
        Me.dgvcolFatNo.Name = "dgvcolFatNo"
        '
        'dgvcolFatTar
        '
        Me.dgvcolFatTar.HeaderText = "Fatura Tarihi"
        Me.dgvcolFatTar.Name = "dgvcolFatTar"
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

    Private Sub grsbtnMlzEkle_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grsbtnMlzEkle.MouseClick
        v_animyon = "Down"
        p_WizAnim()
        MlzTan.MlzTan_Load()
        p_CtrlCopy(MlzTan.pnlMlzTan, Form.pnlPages)
        p_CtrlCopy(MlzTan.pnlStatusBar, Form.pnlButtons)
    End Sub

    Public Sub StkGrs_Load()
        p_ConnectServer(dsCelebi, "marka", "SELECT * FROM marka")
        p_ConnectServer(dsCelebi, "malzeme", "SELECT * FROM malzeme")
        Form.lblPageName.Text = "Stok Giriþi"
        Form.pctPagePict.BackgroundImage = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\StokGirisLogo.png")
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
            Rapor.dgvRapor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { _
                                Me.dgvcolImage, Me.dgvcolCheck, Me.dgvcolModel, Me.dgvcolMarka, Me.dgvcolCelKod, _
                                Me.dgvcolMlzKod, Me.dgvcolSipKod, Me.dgvcolKrgEtkNo, Me.dgvcolMik, _
                                Me.dgvcolFiyat, Me.dgvcolGirTar, Me.dgvcolFatNo, Me.dgvcolFatTar, _
                                Me.dgvcolAciklama})
        End If
    End Sub

    Private Sub btnKytEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKytEkle.Click
        Me.dtpGirTar.CustomFormat = "MM/dd/yyyy"
        Me.dtpFatTar.CustomFormat = "MM/dd/yyyy"
        Rapor.dgvRapor.Rows.Add()
        Rapor.dgvRapor.Rows(Rapor.dgvRapor.RowCount - 1).SetValues(Image.FromFile(CurDir.ToString & "\Skins\Default\Images\TaskPaneDownOver.png"), True, _
                                Me.cmbModel.Text.ToString, Me.cmbMarka.Text.ToString, Me.cmbCelKod.Text.ToString, _
                                Me.cmbMlzKod.Text.ToString, Me.cmbSipKod.Text.ToString, Me.txtKrgEtkNo.Text.ToString, _
                                Me.nudMik.Value.ToString, Me.mtbFiyat.Text.ToString, Me.dtpGirTar.Text, _
                                Me.txtFatNo.Text.ToString, Me.dtpFatTar.Text, Me.txtAciklama.Text.ToString)
        Me.dtpGirTar.CustomFormat = "dd MMMM yyyy dddd"
        Me.dtpFatTar.CustomFormat = "dd MMMM yyyy dddd"
    End Sub

  
    Private Sub cmbMarka_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMarka.SelectedIndexChanged
        bsMalzeme.Filter = "marka_id=" & Me.cmbMarka.SelectedIndex + 1
    End Sub
End Class
