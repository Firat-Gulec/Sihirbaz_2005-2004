<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personel))
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlPersonel = New System.Windows.Forms.Panel
        Me.grpMain = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.optBayan = New System.Windows.Forms.Button
        Me.optBay = New System.Windows.Forms.Button
        Me.txtAciklama = New System.Windows.Forms.TextBox
        Me.cmbKang = New System.Windows.Forms.ComboBox
        Me.txtTckno = New System.Windows.Forms.TextBox
        Me.lblTckno = New System.Windows.Forms.Label
        Me.lblCinsiyet = New System.Windows.Forms.Label
        Me.lblKang = New System.Windows.Forms.Label
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.TxtSoyad = New System.Windows.Forms.TextBox
        Me.txtAd = New System.Windows.Forms.TextBox
        Me.txtAdres = New System.Windows.Forms.TextBox
        Me.btnKytEkle = New System.Windows.Forms.Button
        Me.lblSoyad = New System.Windows.Forms.Label
        Me.lblAd = New System.Windows.Forms.Label
        Me.lblAdres = New System.Windows.Forms.Label
        Me.lblAciklama = New System.Windows.Forms.Label
        Me.lblTel = New System.Windows.Forms.Label
        Me.pnlStatusBar.SuspendLayout()
        Me.pnlPersonel.SuspendLayout()
        Me.grpMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.pnlStatusBar.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.AccessibleName = ""
        Me.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBack.Enabled = False
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
        Me.btnNext.Text = "Tamam"
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
        'pnlPersonel
        '
        Me.pnlPersonel.Controls.Add(Me.grpMain)
        Me.pnlPersonel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPersonel.Location = New System.Drawing.Point(0, 0)
        Me.pnlPersonel.Name = "pnlPersonel"
        Me.pnlPersonel.Size = New System.Drawing.Size(794, 415)
        Me.pnlPersonel.TabIndex = 0
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.Panel1)
        Me.grpMain.Controls.Add(Me.txtAciklama)
        Me.grpMain.Controls.Add(Me.cmbKang)
        Me.grpMain.Controls.Add(Me.txtTckno)
        Me.grpMain.Controls.Add(Me.lblTckno)
        Me.grpMain.Controls.Add(Me.lblCinsiyet)
        Me.grpMain.Controls.Add(Me.lblKang)
        Me.grpMain.Controls.Add(Me.TxtTel)
        Me.grpMain.Controls.Add(Me.TxtSoyad)
        Me.grpMain.Controls.Add(Me.txtAd)
        Me.grpMain.Controls.Add(Me.txtAdres)
        Me.grpMain.Controls.Add(Me.btnKytEkle)
        Me.grpMain.Controls.Add(Me.lblSoyad)
        Me.grpMain.Controls.Add(Me.lblAd)
        Me.grpMain.Controls.Add(Me.lblAdres)
        Me.grpMain.Controls.Add(Me.lblAciklama)
        Me.grpMain.Controls.Add(Me.lblTel)
        Me.grpMain.Location = New System.Drawing.Point(33, 29)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(729, 356)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optBayan)
        Me.Panel1.Controls.Add(Me.optBay)
        Me.Panel1.Location = New System.Drawing.Point(408, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 29)
        Me.Panel1.TabIndex = 13
        '
        'optBayan
        '
        Me.optBayan.AccessibleDescription = "Siparis"
        Me.optBayan.Dock = System.Windows.Forms.DockStyle.Left
        Me.optBayan.FlatAppearance.BorderSize = 0
        Me.optBayan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optBayan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optBayan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optBayan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optBayan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic)
        Me.optBayan.ForeColor = System.Drawing.Color.Navy
        Me.optBayan.Image = CType(resources.GetObject("optBayan.Image"), System.Drawing.Image)
        Me.optBayan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optBayan.Location = New System.Drawing.Point(125, 0)
        Me.optBayan.Name = "optBayan"
        Me.optBayan.Size = New System.Drawing.Size(126, 29)
        Me.optBayan.TabIndex = 2
        Me.optBayan.Text = "  Bayan"
        Me.optBayan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optBayan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optBayan.UseVisualStyleBackColor = True
        '
        'optBay
        '
        Me.optBay.AccessibleDescription = "Siparis"
        Me.optBay.Dock = System.Windows.Forms.DockStyle.Left
        Me.optBay.FlatAppearance.BorderSize = 0
        Me.optBay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optBay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optBay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optBay.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic)
        Me.optBay.ForeColor = System.Drawing.Color.Navy
        Me.optBay.Image = CType(resources.GetObject("optBay.Image"), System.Drawing.Image)
        Me.optBay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optBay.Location = New System.Drawing.Point(0, 0)
        Me.optBay.Name = "optBay"
        Me.optBay.Size = New System.Drawing.Size(125, 29)
        Me.optBay.TabIndex = 1
        Me.optBay.Text = "  Bay"
        Me.optBay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optBay.UseVisualStyleBackColor = True
        '
        'txtAciklama
        '
        Me.txtAciklama.BackColor = System.Drawing.Color.White
        Me.txtAciklama.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtAciklama.ForeColor = System.Drawing.Color.Black
        Me.txtAciklama.Location = New System.Drawing.Point(376, 214)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(330, 82)
        Me.txtAciklama.TabIndex = 15
        '
        'cmbKang
        '
        Me.cmbKang.BackColor = System.Drawing.Color.White
        Me.cmbKang.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmbKang.FormattingEnabled = True
        Me.cmbKang.Location = New System.Drawing.Point(23, 290)
        Me.cmbKang.Name = "cmbKang"
        Me.cmbKang.Size = New System.Drawing.Size(330, 26)
        Me.cmbKang.TabIndex = 12
        '
        'txtTckno
        '
        Me.txtTckno.BackColor = System.Drawing.Color.White
        Me.txtTckno.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtTckno.ForeColor = System.Drawing.Color.Black
        Me.txtTckno.Location = New System.Drawing.Point(23, 232)
        Me.txtTckno.Name = "txtTckno"
        Me.txtTckno.Size = New System.Drawing.Size(330, 26)
        Me.txtTckno.TabIndex = 11
        '
        'lblTckno
        '
        Me.lblTckno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTckno.ForeColor = System.Drawing.Color.Navy
        Me.lblTckno.Location = New System.Drawing.Point(20, 208)
        Me.lblTckno.Name = "lblTckno"
        Me.lblTckno.Size = New System.Drawing.Size(93, 21)
        Me.lblTckno.TabIndex = 3
        Me.lblTckno.Text = "TC Kimlik No"
        Me.lblTckno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCinsiyet
        '
        Me.lblCinsiyet.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCinsiyet.ForeColor = System.Drawing.Color.Navy
        Me.lblCinsiyet.Location = New System.Drawing.Point(373, 31)
        Me.lblCinsiyet.Name = "lblCinsiyet"
        Me.lblCinsiyet.Size = New System.Drawing.Size(95, 21)
        Me.lblCinsiyet.TabIndex = 5
        Me.lblCinsiyet.Text = "Cinsiyet"
        Me.lblCinsiyet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKang
        '
        Me.lblKang.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKang.ForeColor = System.Drawing.Color.Navy
        Me.lblKang.Location = New System.Drawing.Point(20, 266)
        Me.lblKang.Name = "lblKang"
        Me.lblKang.Size = New System.Drawing.Size(100, 21)
        Me.lblKang.TabIndex = 4
        Me.lblKang.Text = "Kan Grubu"
        Me.lblKang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTel
        '
        Me.TxtTel.BackColor = System.Drawing.Color.White
        Me.TxtTel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.TxtTel.ForeColor = System.Drawing.Color.Black
        Me.TxtTel.Location = New System.Drawing.Point(23, 171)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(330, 26)
        Me.TxtTel.TabIndex = 10
        '
        'TxtSoyad
        '
        Me.TxtSoyad.BackColor = System.Drawing.Color.White
        Me.TxtSoyad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.TxtSoyad.ForeColor = System.Drawing.Color.Black
        Me.TxtSoyad.Location = New System.Drawing.Point(23, 113)
        Me.TxtSoyad.Name = "TxtSoyad"
        Me.TxtSoyad.Size = New System.Drawing.Size(330, 26)
        Me.TxtSoyad.TabIndex = 9
        '
        'txtAd
        '
        Me.txtAd.BackColor = System.Drawing.Color.White
        Me.txtAd.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtAd.ForeColor = System.Drawing.Color.Black
        Me.txtAd.Location = New System.Drawing.Point(23, 55)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(330, 26)
        Me.txtAd.TabIndex = 8
        '
        'txtAdres
        '
        Me.txtAdres.BackColor = System.Drawing.Color.White
        Me.txtAdres.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtAdres.ForeColor = System.Drawing.Color.Black
        Me.txtAdres.Location = New System.Drawing.Point(376, 110)
        Me.txtAdres.Multiline = True
        Me.txtAdres.Name = "txtAdres"
        Me.txtAdres.Size = New System.Drawing.Size(330, 80)
        Me.txtAdres.TabIndex = 14
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
        Me.btnKytEkle.Location = New System.Drawing.Point(581, 310)
        Me.btnKytEkle.Name = "btnKytEkle"
        Me.btnKytEkle.Size = New System.Drawing.Size(125, 40)
        Me.btnKytEkle.TabIndex = 16
        Me.btnKytEkle.Text = "Kayýt Ekle"
        Me.btnKytEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKytEkle.UseVisualStyleBackColor = True
        '
        'lblSoyad
        '
        Me.lblSoyad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.Color.Navy
        Me.lblSoyad.Location = New System.Drawing.Point(20, 89)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(93, 21)
        Me.lblSoyad.TabIndex = 1
        Me.lblSoyad.Text = "Soyadi"
        Me.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAd
        '
        Me.lblAd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.Navy
        Me.lblAd.Location = New System.Drawing.Point(20, 31)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(100, 21)
        Me.lblAd.TabIndex = 0
        Me.lblAd.Text = "Adi"
        Me.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdres
        '
        Me.lblAdres.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAdres.ForeColor = System.Drawing.Color.Navy
        Me.lblAdres.Location = New System.Drawing.Point(373, 86)
        Me.lblAdres.Name = "lblAdres"
        Me.lblAdres.Size = New System.Drawing.Size(73, 21)
        Me.lblAdres.TabIndex = 6
        Me.lblAdres.Text = "Adres"
        Me.lblAdres.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAciklama
        '
        Me.lblAciklama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAciklama.ForeColor = System.Drawing.Color.Navy
        Me.lblAciklama.Location = New System.Drawing.Point(377, 193)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(141, 18)
        Me.lblAciklama.TabIndex = 7
        Me.lblAciklama.Text = "Açýklama"
        Me.lblAciklama.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTel
        '
        Me.lblTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.Navy
        Me.lblTel.Location = New System.Drawing.Point(20, 147)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(100, 21)
        Me.lblTel.TabIndex = 2
        Me.lblTel.Text = "Telefon"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Personel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlPersonel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Personel"
        Me.Text = "Form1"
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlPersonel.ResumeLayout(False)
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents pnlPersonel As System.Windows.Forms.Panel
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnKytEkle As System.Windows.Forms.Button
    Friend WithEvents lblSoyad As System.Windows.Forms.Label
    Friend WithEvents lblAd As System.Windows.Forms.Label
    Friend WithEvents txtAciklama As System.Windows.Forms.TextBox
    Friend WithEvents lblAdres As System.Windows.Forms.Label
    Friend WithEvents lblAciklama As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtAdres As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtSoyad As System.Windows.Forms.TextBox
    Friend WithEvents txtAd As System.Windows.Forms.TextBox
    Friend WithEvents lblKang As System.Windows.Forms.Label
    Friend WithEvents cmbKang As System.Windows.Forms.ComboBox
    Friend WithEvents txtTckno As System.Windows.Forms.TextBox
    Friend WithEvents lblTckno As System.Windows.Forms.Label
    Friend WithEvents optBay As System.Windows.Forms.Button
    Friend WithEvents optBayan As System.Windows.Forms.Button
    Friend WithEvents lblCinsiyet As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
