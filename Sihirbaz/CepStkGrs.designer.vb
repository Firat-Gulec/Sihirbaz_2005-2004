<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CepStkGrs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CepStkGrs))
        Me.pnlCepStkGrs = New System.Windows.Forms.Panel
        Me.grpmain = New System.Windows.Forms.GroupBox
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.dtpgirtar = New System.Windows.Forms.DateTimePicker
        Me.lbgirtar = New System.Windows.Forms.Label
        Me.nudmik = New System.Windows.Forms.NumericUpDown
        Me.lbmik = New System.Windows.Forms.Label
        Me.lblModel = New System.Windows.Forms.Label
        Me.txtaciklama = New System.Windows.Forms.TextBox
        Me.lblSipKod = New System.Windows.Forms.Label
        Me.lbaciklama = New System.Windows.Forms.Label
        Me.lblCelKod = New System.Windows.Forms.Label
        Me.cmbsipkod = New System.Windows.Forms.ComboBox
        Me.lblMlxKod = New System.Windows.Forms.Label
        Me.cmbmlzkod = New System.Windows.Forms.ComboBox
        Me.cmbcelkod = New System.Windows.Forms.ComboBox
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlCepStkGrs.SuspendLayout()
        Me.grpmain.SuspendLayout()
        CType(Me.nudmik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCepStkGrs
        '
        Me.pnlCepStkGrs.Controls.Add(Me.grpmain)
        Me.pnlCepStkGrs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCepStkGrs.Location = New System.Drawing.Point(0, 0)
        Me.pnlCepStkGrs.Name = "pnlCepStkGrs"
        Me.pnlCepStkGrs.Size = New System.Drawing.Size(794, 415)
        Me.pnlCepStkGrs.TabIndex = 0
        '
        'grpmain
        '
        Me.grpmain.Controls.Add(Me.btnKytEkle)
        Me.grpmain.Controls.Add(Me.dtpgirtar)
        Me.grpmain.Controls.Add(Me.lbgirtar)
        Me.grpmain.Controls.Add(Me.nudmik)
        Me.grpmain.Controls.Add(Me.lbmik)
        Me.grpmain.Controls.Add(Me.lblModel)
        Me.grpmain.Controls.Add(Me.txtaciklama)
        Me.grpmain.Controls.Add(Me.lblSipKod)
        Me.grpmain.Controls.Add(Me.lbaciklama)
        Me.grpmain.Controls.Add(Me.lblCelKod)
        Me.grpmain.Controls.Add(Me.cmbsipkod)
        Me.grpmain.Controls.Add(Me.lblMlxKod)
        Me.grpmain.Controls.Add(Me.cmbmlzkod)
        Me.grpmain.Controls.Add(Me.cmbcelkod)
        Me.grpmain.Controls.Add(Me.cmbModel)
        Me.grpmain.Location = New System.Drawing.Point(33, 29)
        Me.grpmain.Name = "grpmain"
        Me.grpmain.Size = New System.Drawing.Size(729, 356)
        Me.grpmain.TabIndex = 0
        Me.grpmain.TabStop = False
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
        Me.btnKytEkle.Text = "Kay�t Ekle"
        Me.btnKytEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKytEkle.UseVisualStyleBackColor = True
        '
        'dtpgirtar
        '
        Me.dtpgirtar.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpgirtar.CalendarForeColor = System.Drawing.Color.White
        Me.dtpgirtar.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dtpgirtar.CalendarTrailingForeColor = System.Drawing.Color.Orange
        Me.dtpgirtar.CustomFormat = "dd  MMMM  yyyy  dddd"
        Me.dtpgirtar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpgirtar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpgirtar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpgirtar.Location = New System.Drawing.Point(120, 280)
        Me.dtpgirtar.Name = "dtpgirtar"
        Me.dtpgirtar.Size = New System.Drawing.Size(275, 26)
        Me.dtpgirtar.TabIndex = 12
        '
        'lbgirtar
        '
        Me.lbgirtar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbgirtar.ForeColor = System.Drawing.Color.Navy
        Me.lbgirtar.Location = New System.Drawing.Point(14, 283)
        Me.lbgirtar.Name = "lbgirtar"
        Me.lbgirtar.Size = New System.Drawing.Size(100, 21)
        Me.lbgirtar.TabIndex = 5
        Me.lbgirtar.Text = "Giri� Tarihi"
        Me.lbgirtar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lbmik
        '
        Me.lbmik.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbmik.ForeColor = System.Drawing.Color.Navy
        Me.lbmik.Location = New System.Drawing.Point(14, 237)
        Me.lbmik.Name = "lbmik"
        Me.lbmik.Size = New System.Drawing.Size(100, 21)
        Me.lbmik.TabIndex = 4
        Me.lbmik.Text = "Miktar"
        Me.lbmik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtaciklama.Location = New System.Drawing.Point(423, 124)
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
        Me.lblSipKod.Text = "Sipari� Kodu"
        Me.lblSipKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbaciklama
        '
        Me.lbaciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbaciklama.ForeColor = System.Drawing.Color.Navy
        Me.lbaciklama.Location = New System.Drawing.Point(423, 99)
        Me.lbaciklama.Name = "lbaciklama"
        Me.lbaciklama.Size = New System.Drawing.Size(100, 21)
        Me.lbaciklama.TabIndex = 6
        Me.lbaciklama.Text = "A��klama"
        Me.lbaciklama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCelKod
        '
        Me.lblCelKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCelKod.ForeColor = System.Drawing.Color.Navy
        Me.lblCelKod.Location = New System.Drawing.Point(14, 99)
        Me.lblCelKod.Name = "lblCelKod"
        Me.lblCelKod.Size = New System.Drawing.Size(100, 21)
        Me.lblCelKod.TabIndex = 1
        Me.lblCelKod.Text = "�elebi Kodu"
        Me.lblCelKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbsipkod
        '
        Me.cmbsipkod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbsipkod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsipkod.BackColor = System.Drawing.Color.White
        Me.cmbsipkod.DisplayMember = "siparis_kodu"
        Me.cmbsipkod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbsipkod.FormattingEnabled = True
        Me.cmbsipkod.Location = New System.Drawing.Point(120, 189)
        Me.cmbsipkod.Name = "cmbsipkod"
        Me.cmbsipkod.Size = New System.Drawing.Size(275, 26)
        Me.cmbsipkod.TabIndex = 10
        '
        'lblMlxKod
        '
        Me.lblMlxKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMlxKod.ForeColor = System.Drawing.Color.Navy
        Me.lblMlxKod.Location = New System.Drawing.Point(14, 145)
        Me.lblMlxKod.Name = "lblMlxKod"
        Me.lblMlxKod.Size = New System.Drawing.Size(100, 21)
        Me.lblMlxKod.TabIndex = 2
        Me.lblMlxKod.Text = "Malzeme Kodu"
        Me.lblMlxKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbmlzkod
        '
        Me.cmbmlzkod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbmlzkod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbmlzkod.BackColor = System.Drawing.Color.White
        Me.cmbmlzkod.DisplayMember = "malzeme_kodu"
        Me.cmbmlzkod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbmlzkod.FormattingEnabled = True
        Me.cmbmlzkod.Location = New System.Drawing.Point(120, 143)
        Me.cmbmlzkod.Name = "cmbmlzkod"
        Me.cmbmlzkod.Size = New System.Drawing.Size(275, 26)
        Me.cmbmlzkod.TabIndex = 9
        '
        'cmbcelkod
        '
        Me.cmbcelkod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbcelkod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcelkod.BackColor = System.Drawing.Color.White
        Me.cmbcelkod.DisplayMember = "celebi_kodu"
        Me.cmbcelkod.DropDownWidth = 246
        Me.cmbcelkod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbcelkod.FormattingEnabled = True
        Me.cmbcelkod.Location = New System.Drawing.Point(120, 97)
        Me.cmbcelkod.Name = "cmbcelkod"
        Me.cmbcelkod.Size = New System.Drawing.Size(275, 26)
        Me.cmbcelkod.TabIndex = 8
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
        Me.btnNext.Text = "�leri"
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
        Me.btnCancel.Text = "�ptal"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'CepStkGrs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlCepStkGrs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CepStkGrs"
        Me.Text = "CepStkKul"
        Me.pnlCepStkGrs.ResumeLayout(False)
        Me.grpmain.ResumeLayout(False)
        Me.grpmain.PerformLayout()
        CType(Me.nudmik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rprgrpMain As System.Windows.Forms.GroupBox
    Friend WithEvents pnlCepStkGrs As System.Windows.Forms.Panel
    Friend WithEvents grpmain As System.Windows.Forms.GroupBox
    Friend WithEvents dtpgirtar As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbgirtar As System.Windows.Forms.Label
    Friend WithEvents nudmik As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbmik As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents txtaciklama As System.Windows.Forms.TextBox
    Friend WithEvents lblSipKod As System.Windows.Forms.Label
    Friend WithEvents lbaciklama As System.Windows.Forms.Label
    Friend WithEvents lblCelKod As System.Windows.Forms.Label
    Friend WithEvents cmbsipkod As System.Windows.Forms.ComboBox
    Friend WithEvents lblMlxKod As System.Windows.Forms.Label
    Friend WithEvents cmbmlzkod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcelkod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
   
End Class
