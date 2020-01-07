<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Garanti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Garanti))
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlStkGrs = New System.Windows.Forms.Panel
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.chkDur = New System.Windows.Forms.CheckBox
        Me.lblDur = New System.Windows.Forms.Label
        Me.lblAciklama = New System.Windows.Forms.Label
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.cmbCelKod = New System.Windows.Forms.ComboBox
        Me.lblCelKod = New System.Windows.Forms.Label
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.cmbMarka = New System.Windows.Forms.ComboBox
        Me.cmbSipKod = New System.Windows.Forms.ComboBox
        Me.cmbMlzKod = New System.Windows.Forms.ComboBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.lblSipKod = New System.Windows.Forms.Label
        Me.lblMarka = New System.Windows.Forms.Label
        Me.lblMlzKod = New System.Windows.Forms.Label
        Me.dtpTar = New System.Windows.Forms.DateTimePicker
        Me.nudMik = New System.Windows.Forms.NumericUpDown
        Me.txtEtkNo = New System.Windows.Forms.TextBox
        Me.lblKrgEtkNo = New System.Windows.Forms.Label
        Me.lblTar = New System.Windows.Forms.Label
        Me.lblMik = New System.Windows.Forms.Label
        Me.pnlStatusBar.SuspendLayout()
        Me.pnlStkGrs.SuspendLayout()
        Me.grpMain.SuspendLayout()
        CType(Me.nudMik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pnlStatusBar.TabIndex = 3
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
        'pnlStkGrs
        '
        Me.pnlStkGrs.Controls.Add(Me.grpMain)
        Me.pnlStkGrs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStkGrs.Location = New System.Drawing.Point(0, 0)
        Me.pnlStkGrs.Name = "pnlStkGrs"
        Me.pnlStkGrs.Size = New System.Drawing.Size(794, 415)
        Me.pnlStkGrs.TabIndex = 2
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.chkDur)
        Me.grpMain.Controls.Add(Me.lblDur)
        Me.grpMain.Controls.Add(Me.lblAciklama)
        Me.grpMain.Controls.Add(Me.btnKytEkle)
        Me.grpMain.Controls.Add(Me.txtAciklama)
        Me.grpMain.Controls.Add(Me.cmbCelKod)
        Me.grpMain.Controls.Add(Me.lblCelKod)
        Me.grpMain.Controls.Add(Me.cmbModel)
        Me.grpMain.Controls.Add(Me.cmbMarka)
        Me.grpMain.Controls.Add(Me.cmbSipKod)
        Me.grpMain.Controls.Add(Me.cmbMlzKod)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.lblSipKod)
        Me.grpMain.Controls.Add(Me.lblMarka)
        Me.grpMain.Controls.Add(Me.lblMlzKod)
        Me.grpMain.Controls.Add(Me.dtpTar)
        Me.grpMain.Controls.Add(Me.nudMik)
        Me.grpMain.Controls.Add(Me.txtEtkNo)
        Me.grpMain.Controls.Add(Me.lblKrgEtkNo)
        Me.grpMain.Controls.Add(Me.lblTar)
        Me.grpMain.Controls.Add(Me.lblMik)
        Me.grpMain.Location = New System.Drawing.Point(33, 29)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(729, 356)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'chkDur
        '
        Me.chkDur.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkDur.Location = New System.Drawing.Point(495, 75)
        Me.chkDur.Name = "chkDur"
        Me.chkDur.Size = New System.Drawing.Size(15, 26)
        Me.chkDur.TabIndex = 27
        Me.chkDur.UseVisualStyleBackColor = True
        '
        'lblDur
        '
        Me.lblDur.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblDur.ForeColor = System.Drawing.Color.Navy
        Me.lblDur.Location = New System.Drawing.Point(365, 77)
        Me.lblDur.Name = "lblDur"
        Me.lblDur.Size = New System.Drawing.Size(110, 21)
        Me.lblDur.TabIndex = 26
        Me.lblDur.Text = "Garanti Durumu"
        Me.lblDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAciklama
        '
        Me.lblAciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.ForeColor = System.Drawing.Color.Navy
        Me.lblAciklama.Location = New System.Drawing.Point(385, 112)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(100, 21)
        Me.lblAciklama.TabIndex = 11
        Me.lblAciklama.Text = "Açýklama"
        Me.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnKytEkle.TabIndex = 25
        Me.btnKytEkle.Text = "Kayýt Ekle"
        Me.btnKytEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKytEkle.UseVisualStyleBackColor = True
        '
        'txtAciklama
        '
        Me.txtAciklama.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.Location = New System.Drawing.Point(388, 136)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(315, 168)
        Me.txtAciklama.TabIndex = 23
        '
        'cmbCelKod
        '
        Me.cmbCelKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCelKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCelKod.BackColor = System.Drawing.Color.White
        Me.cmbCelKod.DropDownWidth = 233
        Me.cmbCelKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbCelKod.FormattingEnabled = True
        Me.cmbCelKod.Location = New System.Drawing.Point(120, 97)
        Me.cmbCelKod.Name = "cmbCelKod"
        Me.cmbCelKod.Size = New System.Drawing.Size(233, 26)
        Me.cmbCelKod.TabIndex = 14
        '
        'lblCelKod
        '
        Me.lblCelKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCelKod.ForeColor = System.Drawing.Color.Navy
        Me.lblCelKod.Location = New System.Drawing.Point(14, 99)
        Me.lblCelKod.Name = "lblCelKod"
        Me.lblCelKod.Size = New System.Drawing.Size(100, 21)
        Me.lblCelKod.TabIndex = 2
        Me.lblCelKod.Text = "Çelebi Kodu"
        Me.lblCelKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbModel
        '
        Me.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbModel.BackColor = System.Drawing.Color.White
        Me.cmbModel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Items.AddRange(New Object() {"nslr", "lsrjgb.l", "eljgrbpoeýbrtg", "epýrngpen", "39u45035u0nl", "oeurgpo"})
        Me.cmbModel.Location = New System.Drawing.Point(120, 27)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(584, 26)
        Me.cmbModel.TabIndex = 12
        '
        'cmbMarka
        '
        Me.cmbMarka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMarka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMarka.BackColor = System.Drawing.Color.White
        Me.cmbMarka.DropDownWidth = 233
        Me.cmbMarka.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.ItemHeight = 18
        Me.cmbMarka.Location = New System.Drawing.Point(120, 62)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(233, 26)
        Me.cmbMarka.TabIndex = 13
        '
        'cmbSipKod
        '
        Me.cmbSipKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSipKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSipKod.BackColor = System.Drawing.Color.White
        Me.cmbSipKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbSipKod.FormattingEnabled = True
        Me.cmbSipKod.Location = New System.Drawing.Point(120, 167)
        Me.cmbSipKod.Name = "cmbSipKod"
        Me.cmbSipKod.Size = New System.Drawing.Size(233, 26)
        Me.cmbSipKod.TabIndex = 16
        '
        'cmbMlzKod
        '
        Me.cmbMlzKod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMlzKod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMlzKod.BackColor = System.Drawing.Color.White
        Me.cmbMlzKod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbMlzKod.FormattingEnabled = True
        Me.cmbMlzKod.Location = New System.Drawing.Point(120, 132)
        Me.cmbMlzKod.Name = "cmbMlzKod"
        Me.cmbMlzKod.Size = New System.Drawing.Size(233, 26)
        Me.cmbMlzKod.TabIndex = 15
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.Navy
        Me.lblModel.Location = New System.Drawing.Point(14, 29)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 21)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSipKod
        '
        Me.lblSipKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSipKod.ForeColor = System.Drawing.Color.Navy
        Me.lblSipKod.Location = New System.Drawing.Point(14, 169)
        Me.lblSipKod.Name = "lblSipKod"
        Me.lblSipKod.Size = New System.Drawing.Size(100, 21)
        Me.lblSipKod.TabIndex = 4
        Me.lblSipKod.Text = "Sipariþ Kodu"
        Me.lblSipKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMarka
        '
        Me.lblMarka.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMarka.ForeColor = System.Drawing.Color.Navy
        Me.lblMarka.Location = New System.Drawing.Point(14, 64)
        Me.lblMarka.Name = "lblMarka"
        Me.lblMarka.Size = New System.Drawing.Size(100, 21)
        Me.lblMarka.TabIndex = 1
        Me.lblMarka.Text = "Marka"
        Me.lblMarka.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMlzKod
        '
        Me.lblMlzKod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMlzKod.ForeColor = System.Drawing.Color.Navy
        Me.lblMlzKod.Location = New System.Drawing.Point(14, 134)
        Me.lblMlzKod.Name = "lblMlzKod"
        Me.lblMlzKod.Size = New System.Drawing.Size(100, 21)
        Me.lblMlzKod.TabIndex = 3
        Me.lblMlzKod.Text = "Malzeme Kodu"
        Me.lblMlzKod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTar
        '
        Me.dtpTar.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpTar.CalendarForeColor = System.Drawing.Color.White
        Me.dtpTar.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dtpTar.CalendarTrailingForeColor = System.Drawing.Color.PowderBlue
        Me.dtpTar.CustomFormat = "dd MMMM yyyy dddd"
        Me.dtpTar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTar.Location = New System.Drawing.Point(120, 274)
        Me.dtpTar.Name = "dtpTar"
        Me.dtpTar.Size = New System.Drawing.Size(233, 26)
        Me.dtpTar.TabIndex = 20
        '
        'nudMik
        '
        Me.nudMik.BackColor = System.Drawing.Color.White
        Me.nudMik.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.nudMik.ForeColor = System.Drawing.Color.Black
        Me.nudMik.Location = New System.Drawing.Point(120, 238)
        Me.nudMik.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMik.Name = "nudMik"
        Me.nudMik.Size = New System.Drawing.Size(233, 26)
        Me.nudMik.TabIndex = 18
        Me.nudMik.ThousandsSeparator = True
        Me.nudMik.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtEtkNo
        '
        Me.txtEtkNo.BackColor = System.Drawing.Color.White
        Me.txtEtkNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtEtkNo.ForeColor = System.Drawing.Color.Black
        Me.txtEtkNo.Location = New System.Drawing.Point(120, 202)
        Me.txtEtkNo.Name = "txtEtkNo"
        Me.txtEtkNo.Size = New System.Drawing.Size(233, 26)
        Me.txtEtkNo.TabIndex = 17
        '
        'lblKrgEtkNo
        '
        Me.lblKrgEtkNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKrgEtkNo.ForeColor = System.Drawing.Color.Navy
        Me.lblKrgEtkNo.Location = New System.Drawing.Point(14, 204)
        Me.lblKrgEtkNo.Name = "lblKrgEtkNo"
        Me.lblKrgEtkNo.Size = New System.Drawing.Size(100, 21)
        Me.lblKrgEtkNo.TabIndex = 5
        Me.lblKrgEtkNo.Text = "Etiket No"
        Me.lblKrgEtkNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTar
        '
        Me.lblTar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTar.ForeColor = System.Drawing.Color.Navy
        Me.lblTar.Location = New System.Drawing.Point(14, 281)
        Me.lblTar.Name = "lblTar"
        Me.lblTar.Size = New System.Drawing.Size(100, 21)
        Me.lblTar.TabIndex = 8
        Me.lblTar.Text = "Tarih"
        Me.lblTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMik
        '
        Me.lblMik.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblMik.ForeColor = System.Drawing.Color.Navy
        Me.lblMik.Location = New System.Drawing.Point(14, 239)
        Me.lblMik.Name = "lblMik"
        Me.lblMik.Size = New System.Drawing.Size(100, 21)
        Me.lblMik.TabIndex = 6
        Me.lblMik.Text = "Miktar"
        Me.lblMik.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Garanti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlStkGrs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Garanti"
        Me.Text = "Garanti"
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlStkGrs.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.nudMik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlStkGrs As System.Windows.Forms.Panel
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents lblAciklama As System.Windows.Forms.Label
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents cmbCelKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblCelKod As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarka As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSipKod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMlzKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblSipKod As System.Windows.Forms.Label
    Friend WithEvents lblMarka As System.Windows.Forms.Label
    Friend WithEvents lblMlzKod As System.Windows.Forms.Label
    Friend WithEvents dtpTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents nudMik As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtEtkNo As System.Windows.Forms.TextBox
    Friend WithEvents lblKrgEtkNo As System.Windows.Forms.Label
    Friend WithEvents lblTar As System.Windows.Forms.Label
    Friend WithEvents lblMik As System.Windows.Forms.Label
    Friend WithEvents chkDur As System.Windows.Forms.CheckBox
    Friend WithEvents lblDur As System.Windows.Forms.Label
End Class
