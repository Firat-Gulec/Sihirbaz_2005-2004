<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StkKul
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StkKul))
        Me.pnlStkKul = New System.Windows.Forms.Panel
        Me.csgrsgrpmain = New System.Windows.Forms.GroupBox
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.dtpKulTar = New System.Windows.Forms.DateTimePicker
        Me.lblGirTar = New System.Windows.Forms.Label
        Me.nudmik = New System.Windows.Forms.NumericUpDown
        Me.lblMik = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.txtaciklama = New System.Windows.Forms.TextBox
        Me.lblSipKod = New System.Windows.Forms.Label
        Me.lblAciklama = New System.Windows.Forms.Label
        Me.lblCelKod = New System.Windows.Forms.Label
        Me.cmbSipKod = New System.Windows.Forms.ComboBox
        Me.lblMlzKod = New System.Windows.Forms.Label
        Me.cmbMlzKod = New System.Windows.Forms.ComboBox
        Me.cmbCelKod = New System.Windows.Forms.ComboBox
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlStkKul.SuspendLayout()
        Me.csgrsgrpmain.SuspendLayout()
        CType(Me.nudmik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStkKul
        '
        Me.pnlStkKul.Controls.Add(Me.csgrsgrpmain)
        Me.pnlStkKul.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStkKul.Location = New System.Drawing.Point(0, 0)
        Me.pnlStkKul.Name = "pnlStkKul"
        Me.pnlStkKul.Size = New System.Drawing.Size(794, 415)
        Me.pnlStkKul.TabIndex = 0
        '
        'csgrsgrpmain
        '
        Me.csgrsgrpmain.Controls.Add(Me.btnKytEkle)
        Me.csgrsgrpmain.Controls.Add(Me.dtpKulTar)
        Me.csgrsgrpmain.Controls.Add(Me.lblGirTar)
        Me.csgrsgrpmain.Controls.Add(Me.nudmik)
        Me.csgrsgrpmain.Controls.Add(Me.lblMik)
        Me.csgrsgrpmain.Controls.Add(Me.lblModel)
        Me.csgrsgrpmain.Controls.Add(Me.txtaciklama)
        Me.csgrsgrpmain.Controls.Add(Me.lblSipKod)
        Me.csgrsgrpmain.Controls.Add(Me.lblAciklama)
        Me.csgrsgrpmain.Controls.Add(Me.lblCelKod)
        Me.csgrsgrpmain.Controls.Add(Me.cmbSipKod)
        Me.csgrsgrpmain.Controls.Add(Me.lblMlzKod)
        Me.csgrsgrpmain.Controls.Add(Me.cmbMlzKod)
        Me.csgrsgrpmain.Controls.Add(Me.cmbCelKod)
        Me.csgrsgrpmain.Controls.Add(Me.cmbModel)
        Me.csgrsgrpmain.Location = New System.Drawing.Point(33, 29)
        Me.csgrsgrpmain.Name = "csgrsgrpmain"
        Me.csgrsgrpmain.Size = New System.Drawing.Size(729, 356)
        Me.csgrsgrpmain.TabIndex = 0
        Me.csgrsgrpmain.TabStop = False
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
        Me.btnKytEkle.TabIndex = 14
        Me.btnKytEkle.Text = "Kayýt Ekle"
        Me.btnKytEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKytEkle.UseVisualStyleBackColor = True
        '
        'dtpKulTar
        '
        Me.dtpKulTar.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpKulTar.CalendarForeColor = System.Drawing.Color.White
        Me.dtpKulTar.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dtpKulTar.CalendarTrailingForeColor = System.Drawing.Color.Orange
        Me.dtpKulTar.CustomFormat = "dd  MMMM  yyyy  dddd"
        Me.dtpKulTar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpKulTar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpKulTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKulTar.Location = New System.Drawing.Point(120, 280)
        Me.dtpKulTar.Name = "dtpKulTar"
        Me.dtpKulTar.Size = New System.Drawing.Size(275, 26)
        Me.dtpKulTar.TabIndex = 12
        '
        'lblGirTar
        '
        Me.lblGirTar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGirTar.ForeColor = System.Drawing.Color.Navy
        Me.lblGirTar.Location = New System.Drawing.Point(14, 283)
        Me.lblGirTar.Name = "lblGirTar"
        Me.lblGirTar.Size = New System.Drawing.Size(100, 21)
        Me.lblGirTar.TabIndex = 5
        Me.lblGirTar.Text = "Giriþ Tarihi"
        Me.lblGirTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudmik
        '
        Me.nudmik.BackColor = System.Drawing.Color.White
        Me.nudmik.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nudmik.ForeColor = System.Drawing.Color.Black
        Me.nudmik.Location = New System.Drawing.Point(120, 236)
        Me.nudmik.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudmik.Name = "nudmik"
        Me.nudmik.Size = New System.Drawing.Size(275, 26)
        Me.nudmik.TabIndex = 11
        Me.nudmik.ThousandsSeparator = True
        Me.nudmik.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblMik
        '
        Me.lblMik.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMik.ForeColor = System.Drawing.Color.Navy
        Me.lblMik.Location = New System.Drawing.Point(14, 237)
        Me.lblMik.Name = "lblMik"
        Me.lblMik.Size = New System.Drawing.Size(100, 21)
        Me.lblMik.TabIndex = 4
        Me.lblMik.Text = "Miktar"
        Me.lblMik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Navy
        Me.lblModel.Location = New System.Drawing.Point(14, 52)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 21)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtaciklama
        '
        Me.txtaciklama.BackColor = System.Drawing.Color.White
        Me.txtaciklama.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtaciklama.ForeColor = System.Drawing.Color.Black
        Me.txtaciklama.Location = New System.Drawing.Point(423, 123)
        Me.txtaciklama.Multiline = True
        Me.txtaciklama.Name = "txtaciklama"
        Me.txtaciklama.Size = New System.Drawing.Size(280, 183)
        Me.txtaciklama.TabIndex = 13
        '
        'lblSipKod
        '
        Me.lblSipKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipKod.ForeColor = System.Drawing.Color.Navy
        Me.lblSipKod.Location = New System.Drawing.Point(14, 191)
        Me.lblSipKod.Name = "lblSipKod"
        Me.lblSipKod.Size = New System.Drawing.Size(100, 21)
        Me.lblSipKod.TabIndex = 3
        Me.lblSipKod.Text = "Sipariþ Kodu"
        Me.lblSipKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAciklama
        '
        Me.lblAciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.ForeColor = System.Drawing.Color.Navy
        Me.lblAciklama.Location = New System.Drawing.Point(423, 99)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(100, 21)
        Me.lblAciklama.TabIndex = 6
        Me.lblAciklama.Text = "Açýklama"
        Me.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCelKod
        '
        Me.lblCelKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCelKod.ForeColor = System.Drawing.Color.Navy
        Me.lblCelKod.Location = New System.Drawing.Point(14, 99)
        Me.lblCelKod.Name = "lblCelKod"
        Me.lblCelKod.Size = New System.Drawing.Size(100, 21)
        Me.lblCelKod.TabIndex = 1
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
        Me.cmbSipKod.Location = New System.Drawing.Point(120, 189)
        Me.cmbSipKod.Name = "cmbSipKod"
        Me.cmbSipKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbSipKod.TabIndex = 10
        '
        'lblMlzKod
        '
        Me.lblMlzKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMlzKod.ForeColor = System.Drawing.Color.Navy
        Me.lblMlzKod.Location = New System.Drawing.Point(14, 145)
        Me.lblMlzKod.Name = "lblMlzKod"
        Me.lblMlzKod.Size = New System.Drawing.Size(100, 21)
        Me.lblMlzKod.TabIndex = 2
        Me.lblMlzKod.Text = "Malzeme Kodu"
        Me.lblMlzKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMlzKod
        '
        Me.cmbMlzKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMlzKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMlzKod.BackColor = System.Drawing.Color.White
        Me.cmbMlzKod.DisplayMember = "malzeme_kodu"
        Me.cmbMlzKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMlzKod.FormattingEnabled = True
        Me.cmbMlzKod.Location = New System.Drawing.Point(120, 143)
        Me.cmbMlzKod.Name = "cmbMlzKod"
        Me.cmbMlzKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbMlzKod.TabIndex = 9
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
        Me.cmbCelKod.Location = New System.Drawing.Point(120, 97)
        Me.cmbCelKod.Name = "cmbCelKod"
        Me.cmbCelKod.Size = New System.Drawing.Size(275, 26)
        Me.cmbCelKod.TabIndex = 8
        '
        'cmbModel
        '
        Me.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModel.BackColor = System.Drawing.Color.White
        Me.cmbModel.DisplayMember = "Ad"
        Me.cmbModel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(120, 50)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(583, 26)
        Me.cmbModel.TabIndex = 7
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
        'StkKul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlStkKul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StkKul"
        Me.Text = "StkKul"
        Me.pnlStkKul.ResumeLayout(False)
        Me.csgrsgrpmain.ResumeLayout(False)
        Me.csgrsgrpmain.PerformLayout()
        CType(Me.nudmik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rprgrpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlStkKul As System.Windows.Forms.Panel
    Friend WithEvents csgrsgrpmain As System.Windows.Forms.GroupBox
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
    Friend WithEvents dtpKulTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGirTar As System.Windows.Forms.Label
    Friend WithEvents nudmik As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMik As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtaciklama As System.Windows.Forms.TextBox
    Friend WithEvents lblSipKod As System.Windows.Forms.Label
    Friend WithEvents lblAciklama As System.Windows.Forms.Label
    Friend WithEvents lblCelKod As System.Windows.Forms.Label
    Friend WithEvents cmbSipKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblMlzKod As System.Windows.Forms.Label
    Friend WithEvents cmbMlzKod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCelKod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    
End Class
