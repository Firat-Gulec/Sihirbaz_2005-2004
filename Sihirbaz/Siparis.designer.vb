<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Siparis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Siparis))
        Me.pnlSiparis = New System.Windows.Forms.Panel
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.chkSipDur = New System.Windows.Forms.CheckBox
        Me.dtpSipTar = New System.Windows.Forms.DateTimePicker
        Me.lblSipDur = New System.Windows.Forms.Label
        Me.lblMarka = New System.Windows.Forms.Label
        Me.cmbMarka = New System.Windows.Forms.ComboBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.lblSipKod = New System.Windows.Forms.Label
        Me.lblAciklama = New System.Windows.Forms.Label
        Me.lblCelKod = New System.Windows.Forms.Label
        Me.cmbSipKod = New System.Windows.Forms.ComboBox
        Me.lblSipTar = New System.Windows.Forms.Label
        Me.lblMlzKod = New System.Windows.Forms.Label
        Me.nudSipMik = New System.Windows.Forms.NumericUpDown
        Me.cmbMlzKod = New System.Windows.Forms.ComboBox
        Me.lblSipMik = New System.Windows.Forms.Label
        Me.cmbCelKod = New System.Windows.Forms.ComboBox
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlSiparis.SuspendLayout()
        Me.grpMain.SuspendLayout()
        CType(Me.nudSipMik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSiparis
        '
        Me.pnlSiparis.Controls.Add(Me.grpMain)
        Me.pnlSiparis.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSiparis.Location = New System.Drawing.Point(0, 0)
        Me.pnlSiparis.Name = "pnlSiparis"
        Me.pnlSiparis.Size = New System.Drawing.Size(794, 415)
        Me.pnlSiparis.TabIndex = 0
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.btnKytEkle)
        Me.grpMain.Controls.Add(Me.chkSipDur)
        Me.grpMain.Controls.Add(Me.dtpSipTar)
        Me.grpMain.Controls.Add(Me.lblSipDur)
        Me.grpMain.Controls.Add(Me.lblMarka)
        Me.grpMain.Controls.Add(Me.cmbMarka)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.txtAciklama)
        Me.grpMain.Controls.Add(Me.lblSipKod)
        Me.grpMain.Controls.Add(Me.lblAciklama)
        Me.grpMain.Controls.Add(Me.lblCelKod)
        Me.grpMain.Controls.Add(Me.cmbSipKod)
        Me.grpMain.Controls.Add(Me.lblSipTar)
        Me.grpMain.Controls.Add(Me.lblMlzKod)
        Me.grpMain.Controls.Add(Me.nudSipMik)
        Me.grpMain.Controls.Add(Me.cmbMlzKod)
        Me.grpMain.Controls.Add(Me.lblSipMik)
        Me.grpMain.Controls.Add(Me.cmbCelKod)
        Me.grpMain.Controls.Add(Me.cmbModel)
        Me.grpMain.Location = New System.Drawing.Point(33, 29)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(729, 356)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'btnKytEkle
        '
        Me.btnKytEkle.FlatAppearance.BorderSize = 0
        Me.btnKytEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnKytEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnKytEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKytEkle.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKytEkle.ForeColor = System.Drawing.Color.Black
        Me.btnKytEkle.Image = CType(resources.GetObject("btnKytEkle.Image"), System.Drawing.Image)
        Me.btnKytEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKytEkle.Location = New System.Drawing.Point(578, 310)
        Me.btnKytEkle.Name = "btnKytEkle"
        Me.btnKytEkle.Size = New System.Drawing.Size(125, 40)
        Me.btnKytEkle.TabIndex = 18
        Me.btnKytEkle.Text = "Kayýt Ekle"
        Me.btnKytEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKytEkle.UseVisualStyleBackColor = True
        '
        'chkSipDur
        '
        Me.chkSipDur.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkSipDur.Location = New System.Drawing.Point(120, 318)
        Me.chkSipDur.Name = "chkSipDur"
        Me.chkSipDur.Size = New System.Drawing.Size(15, 26)
        Me.chkSipDur.TabIndex = 16
        Me.chkSipDur.UseVisualStyleBackColor = True
        '
        'dtpSipTar
        '
        Me.dtpSipTar.CustomFormat = "dd MMMM yyyy dddd"
        Me.dtpSipTar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpSipTar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpSipTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSipTar.Location = New System.Drawing.Point(120, 280)
        Me.dtpSipTar.Name = "dtpSipTar"
        Me.dtpSipTar.Size = New System.Drawing.Size(275, 26)
        Me.dtpSipTar.TabIndex = 15
        Me.dtpSipTar.Value = New Date(2006, 6, 25, 0, 0, 0, 0)
        '
        'lblSipDur
        '
        Me.lblSipDur.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipDur.ForeColor = System.Drawing.Color.Navy
        Me.lblSipDur.Location = New System.Drawing.Point(14, 320)
        Me.lblSipDur.Name = "lblSipDur"
        Me.lblSipDur.Size = New System.Drawing.Size(100, 21)
        Me.lblSipDur.TabIndex = 7
        Me.lblSipDur.Text = "Sipariþ Durumu"
        Me.lblSipDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMarka
        '
        Me.lblMarka.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMarka.ForeColor = System.Drawing.Color.Navy
        Me.lblMarka.Location = New System.Drawing.Point(14, 77)
        Me.lblMarka.Name = "lblMarka"
        Me.lblMarka.Size = New System.Drawing.Size(100, 21)
        Me.lblMarka.TabIndex = 1
        Me.lblMarka.Text = "Marka"
        Me.lblMarka.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMarka
        '
        Me.cmbMarka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMarka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMarka.BackColor = System.Drawing.Color.White
        Me.cmbMarka.DisplayMember = "Ad"
        Me.cmbMarka.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.Location = New System.Drawing.Point(120, 75)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(275, 26)
        Me.cmbMarka.TabIndex = 10
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Navy
        Me.lblModel.Location = New System.Drawing.Point(14, 37)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 21)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAciklama
        '
        Me.txtAciklama.BackColor = System.Drawing.Color.White
        Me.txtAciklama.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.ForeColor = System.Drawing.Color.Black
        Me.txtAciklama.Location = New System.Drawing.Point(423, 94)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(280, 212)
        Me.txtAciklama.TabIndex = 17
        '
        'lblSipKod
        '
        Me.lblSipKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipKod.ForeColor = System.Drawing.Color.Navy
        Me.lblSipKod.Location = New System.Drawing.Point(14, 199)
        Me.lblSipKod.Name = "lblSipKod"
        Me.lblSipKod.Size = New System.Drawing.Size(100, 21)
        Me.lblSipKod.TabIndex = 4
        Me.lblSipKod.Text = "Sipariþ Kodu"
        Me.lblSipKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAciklama
        '
        Me.lblAciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.ForeColor = System.Drawing.Color.Navy
        Me.lblAciklama.Location = New System.Drawing.Point(422, 70)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(100, 21)
        Me.lblAciklama.TabIndex = 8
        Me.lblAciklama.Text = "Açýklama"
        Me.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCelKod
        '
        Me.lblCelKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCelKod.ForeColor = System.Drawing.Color.Navy
        Me.lblCelKod.Location = New System.Drawing.Point(14, 117)
        Me.lblCelKod.Name = "lblCelKod"
        Me.lblCelKod.Size = New System.Drawing.Size(100, 21)
        Me.lblCelKod.TabIndex = 2
        Me.lblCelKod.Text = "Çelebi Kodu"
        Me.lblCelKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSipKod
        '
        Me.cmbSipKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSipKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSipKod.BackColor = System.Drawing.Color.White
        Me.cmbSipKod.DisplayMember = "siparis_kodu"
        Me.cmbSipKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbSipKod.FormattingEnabled = True
        Me.cmbSipKod.Location = New System.Drawing.Point(120, 197)
        Me.cmbSipKod.Name = "cmbSipKod"
        Me.cmbSipKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbSipKod.TabIndex = 13
        '
        'lblSipTar
        '
        Me.lblSipTar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipTar.ForeColor = System.Drawing.Color.Navy
        Me.lblSipTar.Location = New System.Drawing.Point(14, 283)
        Me.lblSipTar.Name = "lblSipTar"
        Me.lblSipTar.Size = New System.Drawing.Size(100, 21)
        Me.lblSipTar.TabIndex = 6
        Me.lblSipTar.Text = "Sipariþ Tarihi"
        Me.lblSipTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMlzKod
        '
        Me.lblMlzKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMlzKod.ForeColor = System.Drawing.Color.Navy
        Me.lblMlzKod.Location = New System.Drawing.Point(14, 158)
        Me.lblMlzKod.Name = "lblMlzKod"
        Me.lblMlzKod.Size = New System.Drawing.Size(100, 21)
        Me.lblMlzKod.TabIndex = 3
        Me.lblMlzKod.Text = "Malzeme Kodu"
        Me.lblMlzKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudSipMik
        '
        Me.nudSipMik.BackColor = System.Drawing.Color.White
        Me.nudSipMik.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nudSipMik.ForeColor = System.Drawing.Color.Black
        Me.nudSipMik.Location = New System.Drawing.Point(120, 238)
        Me.nudSipMik.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSipMik.Name = "nudSipMik"
        Me.nudSipMik.Size = New System.Drawing.Size(275, 26)
        Me.nudSipMik.TabIndex = 14
        Me.nudSipMik.ThousandsSeparator = True
        Me.nudSipMik.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'cmbMlzKod
        '
        Me.cmbMlzKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMlzKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMlzKod.BackColor = System.Drawing.Color.White
        Me.cmbMlzKod.DisplayMember = "malzeme_kodu"
        Me.cmbMlzKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMlzKod.FormattingEnabled = True
        Me.cmbMlzKod.Location = New System.Drawing.Point(120, 156)
        Me.cmbMlzKod.Name = "cmbMlzKod"
        Me.cmbMlzKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbMlzKod.TabIndex = 12
        '
        'lblSipMik
        '
        Me.lblSipMik.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipMik.ForeColor = System.Drawing.Color.Navy
        Me.lblSipMik.Location = New System.Drawing.Point(14, 241)
        Me.lblSipMik.Name = "lblSipMik"
        Me.lblSipMik.Size = New System.Drawing.Size(100, 21)
        Me.lblSipMik.TabIndex = 5
        Me.lblSipMik.Text = "Sipariþ Miktar"
        Me.lblSipMik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCelKod
        '
        Me.cmbCelKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCelKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCelKod.BackColor = System.Drawing.Color.White
        Me.cmbCelKod.DisplayMember = "celebi_kodu"
        Me.cmbCelKod.DropDownWidth = 246
        Me.cmbCelKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbCelKod.FormattingEnabled = True
        Me.cmbCelKod.Location = New System.Drawing.Point(120, 115)
        Me.cmbCelKod.Name = "cmbCelKod"
        Me.cmbCelKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbCelKod.TabIndex = 11
        '
        'cmbModel
        '
        Me.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModel.BackColor = System.Drawing.Color.White
        Me.cmbModel.DisplayMember = "Ad"
        Me.cmbModel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(120, 35)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(583, 26)
        Me.cmbModel.TabIndex = 9
        '
        'pnlStatusBar
        '
        Me.pnlStatusBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlStatusBar.Controls.Add(Me.btnBack)
        Me.pnlStatusBar.Controls.Add(Me.btnNext)
        Me.pnlStatusBar.Controls.Add(Me.btnCancel)
        Me.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Location = New System.Drawing.Point(0, 415)
        Me.pnlStatusBar.Name = "pnlStatusBar"
        Me.pnlStatusBar.Size = New System.Drawing.Size(794, 36)
        Me.pnlStatusBar.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.AccessibleName = ""
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(557, 0)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(79, 36)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Geri"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.AccessibleName = ""
        Me.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(636, 0)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(79, 36)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Ýleri"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleName = ""
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(715, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Ýptal"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Siparis
        '
        Me.AccessibleDescription = "Sipariþ Giriþi"
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlSiparis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Siparis"
        Me.Text = "Siparis"
        Me.pnlSiparis.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.nudSipMik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Siparis As System.Windows.Forms.Panel
    Friend WithEvents pnlSiparis As System.Windows.Forms.Panel
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
    Friend WithEvents chkSipDur As System.Windows.Forms.CheckBox
    Friend WithEvents dtpSipTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSipDur As System.Windows.Forms.Label
    Friend WithEvents lblMarka As System.Windows.Forms.Label
    Friend WithEvents cmbMarka As System.Windows.Forms.ComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents lblSipKod As System.Windows.Forms.Label
    Friend WithEvents lblAciklama As System.Windows.Forms.Label
    Friend WithEvents lblCelKod As System.Windows.Forms.Label
    Friend WithEvents cmbSipKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblSipTar As System.Windows.Forms.Label
    Friend WithEvents lblMlzKod As System.Windows.Forms.Label
    Friend WithEvents nudSipMik As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbMlzKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblSipMik As System.Windows.Forms.Label
    Friend WithEvents cmbCelKod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
