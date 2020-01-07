<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StkGrs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StkGrs))
        Me.pnlStkGrs = New System.Windows.Forms.Panel
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.lblAciklama = New System.Windows.Forms.Label
        Me.grsbtnMlzEkle = New System.Windows.Forms.Button
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.cmbCelKod = New System.Windows.Forms.ComboBox
        Me.lblCelKod = New System.Windows.Forms.Label
        Me.cmbModel = New System.Windows.Forms.ComboBox
        Me.cmbMarka = New System.Windows.Forms.ComboBox
        Me.cmbSipKod = New System.Windows.Forms.ComboBox
        Me.cmbMlzKod = New System.Windows.Forms.ComboBox
        Me.lblModel = New System.Windows.Forms.Label
        Me.mtbFiyat = New System.Windows.Forms.MaskedTextBox
        Me.lblSipKod = New System.Windows.Forms.Label
        Me.dtpFatTar = New System.Windows.Forms.DateTimePicker
        Me.lblMarka = New System.Windows.Forms.Label
        Me.lblMlzKod = New System.Windows.Forms.Label
        Me.dtpGirTar = New System.Windows.Forms.DateTimePicker
        Me.txtFatNo = New System.Windows.Forms.TextBox
        Me.nudMik = New System.Windows.Forms.NumericUpDown
        Me.txtKrgEtkNo = New System.Windows.Forms.TextBox
        Me.lblFatTar = New System.Windows.Forms.Label
        Me.lblKrgEtkNo = New System.Windows.Forms.Label
        Me.lblFatNo = New System.Windows.Forms.Label
        Me.lblGirTar = New System.Windows.Forms.Label
        Me.lblFiyat = New System.Windows.Forms.Label
        Me.lblMik = New System.Windows.Forms.Label
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlStkGrs.SuspendLayout()
        Me.grpMain.SuspendLayout()
        CType(Me.nudMik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStkGrs
        '
        Me.pnlStkGrs.Controls.Add(Me.grpMain)
        Me.pnlStkGrs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStkGrs.Location = New System.Drawing.Point(0, 0)
        Me.pnlStkGrs.Name = "pnlStkGrs"
        Me.pnlStkGrs.Size = New System.Drawing.Size(794, 415)
        Me.pnlStkGrs.TabIndex = 0
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.lblAciklama)
        Me.grpMain.Controls.Add(Me.grsbtnMlzEkle)
        Me.grpMain.Controls.Add(Me.btnKytEkle)
        Me.grpMain.Controls.Add(Me.txtAciklama)
        Me.grpMain.Controls.Add(Me.cmbCelKod)
        Me.grpMain.Controls.Add(Me.lblCelKod)
        Me.grpMain.Controls.Add(Me.cmbModel)
        Me.grpMain.Controls.Add(Me.cmbMarka)
        Me.grpMain.Controls.Add(Me.cmbSipKod)
        Me.grpMain.Controls.Add(Me.cmbMlzKod)
        Me.grpMain.Controls.Add(Me.lblModel)
        Me.grpMain.Controls.Add(Me.mtbFiyat)
        Me.grpMain.Controls.Add(Me.lblSipKod)
        Me.grpMain.Controls.Add(Me.dtpFatTar)
        Me.grpMain.Controls.Add(Me.lblMarka)
        Me.grpMain.Controls.Add(Me.lblMlzKod)
        Me.grpMain.Controls.Add(Me.dtpGirTar)
        Me.grpMain.Controls.Add(Me.txtFatNo)
        Me.grpMain.Controls.Add(Me.nudMik)
        Me.grpMain.Controls.Add(Me.txtKrgEtkNo)
        Me.grpMain.Controls.Add(Me.lblFatTar)
        Me.grpMain.Controls.Add(Me.lblKrgEtkNo)
        Me.grpMain.Controls.Add(Me.lblFatNo)
        Me.grpMain.Controls.Add(Me.lblGirTar)
        Me.grpMain.Controls.Add(Me.lblFiyat)
        Me.grpMain.Controls.Add(Me.lblMik)
        Me.grpMain.Location = New System.Drawing.Point(33, 29)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(729, 356)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'lblAciklama
        '
        Me.lblAciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.ForeColor = System.Drawing.Color.Navy
        Me.lblAciklama.Location = New System.Drawing.Point(388, 132)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(100, 21)
        Me.lblAciklama.TabIndex = 11
        Me.lblAciklama.Text = "Açýklama"
        Me.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grsbtnMlzEkle
        '
        Me.grsbtnMlzEkle.FlatAppearance.BorderSize = 0
        Me.grsbtnMlzEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.grsbtnMlzEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.grsbtnMlzEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grsbtnMlzEkle.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grsbtnMlzEkle.Image = CType(resources.GetObject("grsbtnMlzEkle.Image"), System.Drawing.Image)
        Me.grsbtnMlzEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.grsbtnMlzEkle.Location = New System.Drawing.Point(447, 310)
        Me.grsbtnMlzEkle.Name = "grsbtnMlzEkle"
        Me.grsbtnMlzEkle.Size = New System.Drawing.Size(125, 40)
        Me.grsbtnMlzEkle.TabIndex = 24
        Me.grsbtnMlzEkle.Text = "Malzeme Ekle"
        Me.grsbtnMlzEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.grsbtnMlzEkle.UseVisualStyleBackColor = True
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
        Me.txtAciklama.Location = New System.Drawing.Point(388, 154)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(315, 150)
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
        'mtbFiyat
        '
        Me.mtbFiyat.BackColor = System.Drawing.Color.White
        Me.mtbFiyat.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mtbFiyat.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtbFiyat.ForeColor = System.Drawing.Color.Black
        Me.mtbFiyat.HidePromptOnLeave = True
        Me.mtbFiyat.Location = New System.Drawing.Point(120, 272)
        Me.mtbFiyat.Name = "mtbFiyat"
        Me.mtbFiyat.Size = New System.Drawing.Size(233, 26)
        Me.mtbFiyat.TabIndex = 19
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
        'dtpFatTar
        '
        Me.dtpFatTar.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpFatTar.CalendarForeColor = System.Drawing.Color.White
        Me.dtpFatTar.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dtpFatTar.CalendarTrailingForeColor = System.Drawing.Color.PowderBlue
        Me.dtpFatTar.CustomFormat = "dd MMMM yyyy dddd"
        Me.dtpFatTar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpFatTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFatTar.Location = New System.Drawing.Point(470, 96)
        Me.dtpFatTar.Name = "dtpFatTar"
        Me.dtpFatTar.Size = New System.Drawing.Size(233, 26)
        Me.dtpFatTar.TabIndex = 22
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
        'dtpGirTar
        '
        Me.dtpGirTar.CalendarFont = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpGirTar.CalendarForeColor = System.Drawing.Color.White
        Me.dtpGirTar.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dtpGirTar.CalendarTrailingForeColor = System.Drawing.Color.PowderBlue
        Me.dtpGirTar.CustomFormat = "dd MMMM yyyy dddd"
        Me.dtpGirTar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.dtpGirTar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGirTar.Location = New System.Drawing.Point(120, 306)
        Me.dtpGirTar.Name = "dtpGirTar"
        Me.dtpGirTar.Size = New System.Drawing.Size(233, 26)
        Me.dtpGirTar.TabIndex = 20
        '
        'txtFatNo
        '
        Me.txtFatNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtFatNo.Location = New System.Drawing.Point(470, 62)
        Me.txtFatNo.Name = "txtFatNo"
        Me.txtFatNo.Size = New System.Drawing.Size(233, 26)
        Me.txtFatNo.TabIndex = 21
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
        'txtKrgEtkNo
        '
        Me.txtKrgEtkNo.BackColor = System.Drawing.Color.White
        Me.txtKrgEtkNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKrgEtkNo.ForeColor = System.Drawing.Color.Black
        Me.txtKrgEtkNo.Location = New System.Drawing.Point(120, 202)
        Me.txtKrgEtkNo.Name = "txtKrgEtkNo"
        Me.txtKrgEtkNo.Size = New System.Drawing.Size(233, 26)
        Me.txtKrgEtkNo.TabIndex = 17
        '
        'lblFatTar
        '
        Me.lblFatTar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFatTar.ForeColor = System.Drawing.Color.Navy
        Me.lblFatTar.Location = New System.Drawing.Point(364, 99)
        Me.lblFatTar.Name = "lblFatTar"
        Me.lblFatTar.Size = New System.Drawing.Size(100, 21)
        Me.lblFatTar.TabIndex = 10
        Me.lblFatTar.Text = "Fatura Tarihi"
        Me.lblFatTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKrgEtkNo
        '
        Me.lblKrgEtkNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKrgEtkNo.ForeColor = System.Drawing.Color.Navy
        Me.lblKrgEtkNo.Location = New System.Drawing.Point(14, 204)
        Me.lblKrgEtkNo.Name = "lblKrgEtkNo"
        Me.lblKrgEtkNo.Size = New System.Drawing.Size(100, 21)
        Me.lblKrgEtkNo.TabIndex = 5
        Me.lblKrgEtkNo.Text = "Kargo Etiket No"
        Me.lblKrgEtkNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFatNo
        '
        Me.lblFatNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFatNo.ForeColor = System.Drawing.Color.Navy
        Me.lblFatNo.Location = New System.Drawing.Point(364, 64)
        Me.lblFatNo.Name = "lblFatNo"
        Me.lblFatNo.Size = New System.Drawing.Size(100, 21)
        Me.lblFatNo.TabIndex = 9
        Me.lblFatNo.Text = "Fatura No"
        Me.lblFatNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGirTar
        '
        Me.lblGirTar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGirTar.ForeColor = System.Drawing.Color.Navy
        Me.lblGirTar.Location = New System.Drawing.Point(14, 309)
        Me.lblGirTar.Name = "lblGirTar"
        Me.lblGirTar.Size = New System.Drawing.Size(100, 21)
        Me.lblGirTar.TabIndex = 8
        Me.lblGirTar.Text = "Giriþ Tarihi"
        Me.lblGirTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFiyat
        '
        Me.lblFiyat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFiyat.ForeColor = System.Drawing.Color.Navy
        Me.lblFiyat.Location = New System.Drawing.Point(14, 274)
        Me.lblFiyat.Name = "lblFiyat"
        Me.lblFiyat.Size = New System.Drawing.Size(100, 21)
        Me.lblFiyat.TabIndex = 7
        Me.lblFiyat.Text = "Fiyat"
        Me.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'StkGrs
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlStkGrs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StkGrs"
        Me.Text = "StkGrs"
        Me.pnlStkGrs.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        CType(Me.nudMik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlStkGrs As System.Windows.Forms.Panel
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents grsbtnMlzEkle As System.Windows.Forms.Button
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents lblAciklama As System.Windows.Forms.Label
    Friend WithEvents cmbCelKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblCelKod As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarka As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSipKod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMlzKod As System.Windows.Forms.ComboBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents mtbFiyat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblSipKod As System.Windows.Forms.Label
    Friend WithEvents dtpFatTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMarka As System.Windows.Forms.Label
    Friend WithEvents lblMlzKod As System.Windows.Forms.Label
    Friend WithEvents dtpGirTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFatNo As System.Windows.Forms.TextBox
    Friend WithEvents nudMik As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtKrgEtkNo As System.Windows.Forms.TextBox
    Friend WithEvents lblFatTar As System.Windows.Forms.Label
    Friend WithEvents lblKrgEtkNo As System.Windows.Forms.Label
    Friend WithEvents lblFatNo As System.Windows.Forms.Label
    Friend WithEvents lblGirTar As System.Windows.Forms.Label
    Friend WithEvents lblFiyat As System.Windows.Forms.Label
    Friend WithEvents lblMik As System.Windows.Forms.Label
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button




End Class
