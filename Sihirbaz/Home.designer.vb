<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnlHome = New System.Windows.Forms.Panel
        Me.btnPerEkl = New System.Windows.Forms.Button
        Me.wbAnim = New System.Windows.Forms.WebBrowser
        Me.grpOption = New System.Windows.Forms.Panel
        Me.optCepStkKul = New System.Windows.Forms.Button
        Me.optSiparis = New System.Windows.Forms.Button
        Me.optCepStkGrs = New System.Windows.Forms.Button
        Me.optStkKul = New System.Windows.Forms.Button
        Me.optStkGrs = New System.Windows.Forms.Button
        Me.cmbEleman = New System.Windows.Forms.ComboBox
        Me.grpInfo = New System.Windows.Forms.GroupBox
        Me.lblInfo = New System.Windows.Forms.Label
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pnlHome.SuspendLayout()
        Me.grpOption.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.pnlStatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.btnPerEkl)
        Me.pnlHome.Controls.Add(Me.wbAnim)
        Me.pnlHome.Controls.Add(Me.grpOption)
        Me.pnlHome.Controls.Add(Me.cmbEleman)
        Me.pnlHome.Controls.Add(Me.grpInfo)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(794, 415)
        Me.pnlHome.TabIndex = 45
        '
        'btnPerEkl
        '
        Me.btnPerEkl.FlatAppearance.BorderSize = 0
        Me.btnPerEkl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnPerEkl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnPerEkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerEkl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnPerEkl.ForeColor = System.Drawing.Color.Black
        Me.btnPerEkl.Image = CType(resources.GetObject("btnPerEkl.Image"), System.Drawing.Image)
        Me.btnPerEkl.Location = New System.Drawing.Point(693, 28)
        Me.btnPerEkl.Name = "btnPerEkl"
        Me.btnPerEkl.Size = New System.Drawing.Size(54, 54)
        Me.btnPerEkl.TabIndex = 50
        Me.btnPerEkl.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPerEkl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPerEkl.UseVisualStyleBackColor = True
        '
        'wbAnim
        '
        Me.wbAnim.AllowWebBrowserDrop = False
        Me.wbAnim.IsWebBrowserContextMenuEnabled = False
        Me.wbAnim.Location = New System.Drawing.Point(47, 28)
        Me.wbAnim.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbAnim.Name = "wbAnim"
        Me.wbAnim.ScrollBarsEnabled = False
        Me.wbAnim.Size = New System.Drawing.Size(220, 157)
        Me.wbAnim.TabIndex = 1
        Me.wbAnim.TabStop = False
        Me.wbAnim.Url = New System.Uri("C:\Documents and Settings\3xplor3r\My Documents\Visual Studio 2005\Projects\Wizar" & _
                "d Okul\Wizard Okul\bin\Debug\Skins\Default\Images\Skins\Default\HTML\Add.htm", System.UriKind.Absolute)
        Me.wbAnim.WebBrowserShortcutsEnabled = False
        '
        'grpOption
        '
        Me.grpOption.Controls.Add(Me.optCepStkKul)
        Me.grpOption.Controls.Add(Me.optSiparis)
        Me.grpOption.Controls.Add(Me.optCepStkGrs)
        Me.grpOption.Controls.Add(Me.optStkKul)
        Me.grpOption.Controls.Add(Me.optStkGrs)
        Me.grpOption.Location = New System.Drawing.Point(308, 110)
        Me.grpOption.Name = "grpOption"
        Me.grpOption.Size = New System.Drawing.Size(439, 276)
        Me.grpOption.TabIndex = 49
        '
        'optCepStkKul
        '
        Me.optCepStkKul.AccessibleDescription = "CepStkKul"
        Me.optCepStkKul.FlatAppearance.BorderSize = 0
        Me.optCepStkKul.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optCepStkKul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optCepStkKul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optCepStkKul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCepStkKul.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.optCepStkKul.ForeColor = System.Drawing.Color.White
        Me.optCepStkKul.Image = CType(resources.GetObject("optCepStkKul.Image"), System.Drawing.Image)
        Me.optCepStkKul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCepStkKul.Location = New System.Drawing.Point(42, 223)
        Me.optCepStkKul.Name = "optCepStkKul"
        Me.optCepStkKul.Size = New System.Drawing.Size(324, 29)
        Me.optCepStkKul.TabIndex = 4
        Me.optCepStkKul.Text = "  CEP STOK KULLANIMI"
        Me.optCepStkKul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCepStkKul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optCepStkKul.UseVisualStyleBackColor = True
        '
        'optSiparis
        '
        Me.optSiparis.AccessibleDescription = "Siparis"
        Me.optSiparis.AutoEllipsis = True
        Me.optSiparis.FlatAppearance.BorderSize = 0
        Me.optSiparis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optSiparis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optSiparis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optSiparis.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.optSiparis.ForeColor = System.Drawing.Color.White
        Me.optSiparis.Image = CType(resources.GetObject("optSiparis.Image"), System.Drawing.Image)
        Me.optSiparis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optSiparis.Location = New System.Drawing.Point(42, 23)
        Me.optSiparis.Name = "optSiparis"
        Me.optSiparis.Size = New System.Drawing.Size(324, 29)
        Me.optSiparis.TabIndex = 0
        Me.optSiparis.Text = "  SÝPARÝÞ GÝRÝÞÝ"
        Me.optSiparis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optSiparis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optSiparis.UseVisualStyleBackColor = True
        '
        'optCepStkGrs
        '
        Me.optCepStkGrs.AccessibleDescription = "CepStkGrs"
        Me.optCepStkGrs.FlatAppearance.BorderSize = 0
        Me.optCepStkGrs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optCepStkGrs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optCepStkGrs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optCepStkGrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optCepStkGrs.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.optCepStkGrs.ForeColor = System.Drawing.Color.White
        Me.optCepStkGrs.Image = CType(resources.GetObject("optCepStkGrs.Image"), System.Drawing.Image)
        Me.optCepStkGrs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCepStkGrs.Location = New System.Drawing.Point(42, 173)
        Me.optCepStkGrs.Name = "optCepStkGrs"
        Me.optCepStkGrs.Size = New System.Drawing.Size(324, 29)
        Me.optCepStkGrs.TabIndex = 3
        Me.optCepStkGrs.Text = "  CEP STOK GÝRÝÞÝ"
        Me.optCepStkGrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optCepStkGrs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optCepStkGrs.UseVisualStyleBackColor = True
        '
        'optStkKul
        '
        Me.optStkKul.AccessibleDescription = "StkKul"
        Me.optStkKul.FlatAppearance.BorderSize = 0
        Me.optStkKul.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optStkKul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optStkKul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optStkKul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optStkKul.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.optStkKul.ForeColor = System.Drawing.Color.White
        Me.optStkKul.Image = CType(resources.GetObject("optStkKul.Image"), System.Drawing.Image)
        Me.optStkKul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optStkKul.Location = New System.Drawing.Point(42, 123)
        Me.optStkKul.Name = "optStkKul"
        Me.optStkKul.Size = New System.Drawing.Size(324, 29)
        Me.optStkKul.TabIndex = 2
        Me.optStkKul.Text = "  STOK KULLANIMI"
        Me.optStkKul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optStkKul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optStkKul.UseVisualStyleBackColor = True
        '
        'optStkGrs
        '
        Me.optStkGrs.AccessibleDescription = "StkGrs"
        Me.optStkGrs.FlatAppearance.BorderSize = 0
        Me.optStkGrs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.optStkGrs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.optStkGrs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.optStkGrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optStkGrs.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.optStkGrs.ForeColor = System.Drawing.Color.White
        Me.optStkGrs.Image = CType(resources.GetObject("optStkGrs.Image"), System.Drawing.Image)
        Me.optStkGrs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optStkGrs.Location = New System.Drawing.Point(42, 73)
        Me.optStkGrs.Name = "optStkGrs"
        Me.optStkGrs.Size = New System.Drawing.Size(324, 29)
        Me.optStkGrs.TabIndex = 1
        Me.optStkGrs.Text = "  STOK GÝRÝÞÝ"
        Me.optStkGrs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optStkGrs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.optStkGrs.UseVisualStyleBackColor = True
        '
        'cmbEleman
        '
        Me.cmbEleman.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.cmbEleman.DisplayMember = "Ad"
        Me.cmbEleman.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbEleman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEleman.ForeColor = System.Drawing.Color.White
        Me.cmbEleman.FormattingEnabled = True
        Me.cmbEleman.ItemHeight = 48
        Me.cmbEleman.Location = New System.Drawing.Point(308, 28)
        Me.cmbEleman.Name = "cmbEleman"
        Me.cmbEleman.Size = New System.Drawing.Size(379, 54)
        Me.cmbEleman.TabIndex = 45
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpInfo.Controls.Add(Me.lblInfo)
        Me.grpInfo.Location = New System.Drawing.Point(47, 238)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(220, 148)
        Me.grpInfo.TabIndex = 48
        Me.grpInfo.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(3, 16)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(214, 129)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "  sipariþ giriþi"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlStatusBar.TabIndex = 46
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
        Me.btnBack.TabIndex = 1
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
        Me.btnNext.TabIndex = 2
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
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Ýptal"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 451)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.pnlHome.ResumeLayout(False)
        Me.grpOption.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.pnlStatusBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHome As System.Windows.Forms.Panel
    Friend WithEvents cmbEleman As System.Windows.Forms.ComboBox
    Friend WithEvents wbAnim As System.Windows.Forms.WebBrowser
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents optCepStkKul As System.Windows.Forms.Button
    Friend WithEvents optCepStkGrs As System.Windows.Forms.Button
    Friend WithEvents optSiparis As System.Windows.Forms.Button
    Friend WithEvents optStkGrs As System.Windows.Forms.Button
    Friend WithEvents optStkKul As System.Windows.Forms.Button
    Friend WithEvents pnlStatusBar As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpOption As System.Windows.Forms.Panel
    Friend WithEvents btnPerEkl As System.Windows.Forms.Button


End Class
