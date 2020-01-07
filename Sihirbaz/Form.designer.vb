<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.pnlRszDwn = New System.Windows.Forms.Panel
        Me.pnlRszRght = New System.Windows.Forms.Panel
        Me.pnlRszLft = New System.Windows.Forms.Panel
        Me.pnlRszUp = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.pctClose = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStatusBar = New System.Windows.Forms.Panel
        Me.pnlButtons = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.pctStatus02 = New System.Windows.Forms.PictureBox
        Me.pctStatus01 = New System.Windows.Forms.PictureBox
        Me.pctTsprI = New System.Windows.Forms.PictureBox
        Me.pctIsprP = New System.Windows.Forms.PictureBox
        Me.pnlInfoBar = New System.Windows.Forms.Panel
        Me.lblEleman = New System.Windows.Forms.Label
        Me.lblPageInfo = New System.Windows.Forms.Label
        Me.pctPagePict = New System.Windows.Forms.PictureBox
        Me.lblPageName = New System.Windows.Forms.Label
        Me.pnlTitleBar = New System.Windows.Forms.Panel
        Me.pctTitle03 = New System.Windows.Forms.PictureBox
        Me.pctTitle04 = New System.Windows.Forms.PictureBox
        Me.pctTitle02 = New System.Windows.Forms.PictureBox
        Me.pctTitle01 = New System.Windows.Forms.PictureBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPages = New System.Windows.Forms.Panel
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatusBar.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.pctStatus02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctStatus01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTsprI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIsprP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfoBar.SuspendLayout()
        CType(Me.pctPagePict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.pctTitle03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTitle04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTitle02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTitle01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRszDwn
        '
        Me.pnlRszDwn.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlRszDwn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRszDwn.Location = New System.Drawing.Point(3, 597)
        Me.pnlRszDwn.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRszDwn.Name = "pnlRszDwn"
        Me.pnlRszDwn.Size = New System.Drawing.Size(794, 3)
        Me.pnlRszDwn.TabIndex = 16
        '
        'pnlRszRght
        '
        Me.pnlRszRght.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlRszRght.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRszRght.Location = New System.Drawing.Point(797, 2)
        Me.pnlRszRght.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRszRght.Name = "pnlRszRght"
        Me.pnlRszRght.Size = New System.Drawing.Size(3, 598)
        Me.pnlRszRght.TabIndex = 18
        '
        'pnlRszLft
        '
        Me.pnlRszLft.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlRszLft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlRszLft.Location = New System.Drawing.Point(0, 2)
        Me.pnlRszLft.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRszLft.Name = "pnlRszLft"
        Me.pnlRszLft.Size = New System.Drawing.Size(3, 598)
        Me.pnlRszLft.TabIndex = 15
        '
        'pnlRszUp
        '
        Me.pnlRszUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlRszUp.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRszUp.Location = New System.Drawing.Point(0, 0)
        Me.pnlRszUp.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlRszUp.Name = "pnlRszUp"
        Me.pnlRszUp.Size = New System.Drawing.Size(800, 2)
        Me.pnlRszUp.TabIndex = 17
        '
        'lblTitle
        '
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.LightSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(128, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(538, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "D a t a b a s e   R e c o r d   W i z a r d"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pctClose
        '
        Me.pctClose.BackColor = System.Drawing.Color.Transparent
        Me.pctClose.BackgroundImage = CType(resources.GetObject("pctClose.BackgroundImage"), System.Drawing.Image)
        Me.pctClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctClose.Location = New System.Drawing.Point(746, 3)
        Me.pctClose.Name = "pctClose"
        Me.pctClose.Size = New System.Drawing.Size(28, 28)
        Me.pctClose.TabIndex = 3
        Me.pctClose.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'pnlStatusBar
        '
        Me.pnlStatusBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlStatusBar.BackgroundImage = CType(resources.GetObject("pnlStatusBar.BackgroundImage"), System.Drawing.Image)
        Me.pnlStatusBar.Controls.Add(Me.pnlButtons)
        Me.pnlStatusBar.Controls.Add(Me.pctStatus02)
        Me.pnlStatusBar.Controls.Add(Me.pctStatus01)
        Me.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Location = New System.Drawing.Point(3, 561)
        Me.pnlStatusBar.Name = "pnlStatusBar"
        Me.pnlStatusBar.Size = New System.Drawing.Size(794, 36)
        Me.pnlStatusBar.TabIndex = 2
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnBack)
        Me.pnlButtons.Controls.Add(Me.btnNext)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlButtons.Location = New System.Drawing.Point(514, 0)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(280, 36)
        Me.pnlButtons.TabIndex = 0
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
        Me.btnBack.Location = New System.Drawing.Point(43, 0)
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
        Me.btnNext.Location = New System.Drawing.Point(122, 0)
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
        Me.btnCancel.Location = New System.Drawing.Point(201, 0)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 36)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Ýptal"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pctStatus02
        '
        Me.pctStatus02.BackgroundImage = CType(resources.GetObject("pctStatus02.BackgroundImage"), System.Drawing.Image)
        Me.pctStatus02.Dock = System.Windows.Forms.DockStyle.Left
        Me.pctStatus02.Location = New System.Drawing.Point(450, 0)
        Me.pctStatus02.Name = "pctStatus02"
        Me.pctStatus02.Size = New System.Drawing.Size(64, 36)
        Me.pctStatus02.TabIndex = 22
        Me.pctStatus02.TabStop = False
        '
        'pctStatus01
        '
        Me.pctStatus01.BackgroundImage = CType(resources.GetObject("pctStatus01.BackgroundImage"), System.Drawing.Image)
        Me.pctStatus01.Dock = System.Windows.Forms.DockStyle.Left
        Me.pctStatus01.Location = New System.Drawing.Point(0, 0)
        Me.pctStatus01.Name = "pctStatus01"
        Me.pctStatus01.Size = New System.Drawing.Size(450, 36)
        Me.pctStatus01.TabIndex = 21
        Me.pctStatus01.TabStop = False
        '
        'pctTsprI
        '
        Me.pctTsprI.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pctTsprI.Dock = System.Windows.Forms.DockStyle.Top
        Me.pctTsprI.Location = New System.Drawing.Point(3, 38)
        Me.pctTsprI.Name = "pctTsprI"
        Me.pctTsprI.Size = New System.Drawing.Size(794, 3)
        Me.pctTsprI.TabIndex = 39
        Me.pctTsprI.TabStop = False
        '
        'pctIsprP
        '
        Me.pctIsprP.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pctIsprP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pctIsprP.Location = New System.Drawing.Point(3, 559)
        Me.pctIsprP.Name = "pctIsprP"
        Me.pctIsprP.Size = New System.Drawing.Size(794, 2)
        Me.pctIsprP.TabIndex = 40
        Me.pctIsprP.TabStop = False
        '
        'pnlInfoBar
        '
        Me.pnlInfoBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pnlInfoBar.BackgroundImage = CType(resources.GetObject("pnlInfoBar.BackgroundImage"), System.Drawing.Image)
        Me.pnlInfoBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlInfoBar.Controls.Add(Me.lblEleman)
        Me.pnlInfoBar.Controls.Add(Me.lblPageInfo)
        Me.pnlInfoBar.Controls.Add(Me.pctPagePict)
        Me.pnlInfoBar.Controls.Add(Me.lblPageName)
        Me.pnlInfoBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlInfoBar.Location = New System.Drawing.Point(3, 41)
        Me.pnlInfoBar.Name = "pnlInfoBar"
        Me.pnlInfoBar.Size = New System.Drawing.Size(794, 103)
        Me.pnlInfoBar.TabIndex = 0
        '
        'lblEleman
        '
        Me.lblEleman.AutoEllipsis = True
        Me.lblEleman.BackColor = System.Drawing.Color.Transparent
        Me.lblEleman.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblEleman.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.lblEleman.Location = New System.Drawing.Point(28, 60)
        Me.lblEleman.Name = "lblEleman"
        Me.lblEleman.Size = New System.Drawing.Size(314, 40)
        Me.lblEleman.TabIndex = 0
        Me.lblEleman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPageInfo
        '
        Me.lblPageInfo.AutoEllipsis = True
        Me.lblPageInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblPageInfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lblPageInfo.ForeColor = System.Drawing.Color.White
        Me.lblPageInfo.Location = New System.Drawing.Point(349, 3)
        Me.lblPageInfo.Name = "lblPageInfo"
        Me.lblPageInfo.Size = New System.Drawing.Size(330, 97)
        Me.lblPageInfo.TabIndex = 0
        Me.lblPageInfo.Text = "Seçenek 1 Ýçin Görüntülenmesini Ýstediðiniz Açýklamalarý Ýpuçlarýný Yardým Bilgil" & _
            "erini Buraya Yazabilirsiniz."
        Me.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pctPagePict
        '
        Me.pctPagePict.BackColor = System.Drawing.Color.Transparent
        Me.pctPagePict.BackgroundImage = CType(resources.GetObject("pctPagePict.BackgroundImage"), System.Drawing.Image)
        Me.pctPagePict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctPagePict.Location = New System.Drawing.Point(699, 15)
        Me.pctPagePict.Name = "pctPagePict"
        Me.pctPagePict.Size = New System.Drawing.Size(80, 77)
        Me.pctPagePict.TabIndex = 38
        Me.pctPagePict.TabStop = False
        '
        'lblPageName
        '
        Me.lblPageName.AutoEllipsis = True
        Me.lblPageName.BackColor = System.Drawing.Color.Transparent
        Me.lblPageName.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblPageName.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblPageName.Location = New System.Drawing.Point(28, 6)
        Me.lblPageName.Name = "lblPageName"
        Me.lblPageName.Size = New System.Drawing.Size(315, 42)
        Me.lblPageName.TabIndex = 0
        Me.lblPageName.Text = "Depo Hareketleri"
        Me.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitleBar.BackgroundImage = CType(resources.GetObject("pnlTitleBar.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitleBar.Controls.Add(Me.lblTitle)
        Me.pnlTitleBar.Controls.Add(Me.pctClose)
        Me.pnlTitleBar.Controls.Add(Me.pctTitle03)
        Me.pnlTitleBar.Controls.Add(Me.pctTitle04)
        Me.pnlTitleBar.Controls.Add(Me.pctTitle02)
        Me.pnlTitleBar.Controls.Add(Me.pctTitle01)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(3, 2)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(794, 36)
        Me.pnlTitleBar.TabIndex = 45
        '
        'pctTitle03
        '
        Me.pctTitle03.BackgroundImage = CType(resources.GetObject("pctTitle03.BackgroundImage"), System.Drawing.Image)
        Me.pctTitle03.Dock = System.Windows.Forms.DockStyle.Right
        Me.pctTitle03.Location = New System.Drawing.Point(666, 0)
        Me.pctTitle03.Name = "pctTitle03"
        Me.pctTitle03.Size = New System.Drawing.Size(64, 36)
        Me.pctTitle03.TabIndex = 7
        Me.pctTitle03.TabStop = False
        '
        'pctTitle04
        '
        Me.pctTitle04.BackgroundImage = CType(resources.GetObject("pctTitle04.BackgroundImage"), System.Drawing.Image)
        Me.pctTitle04.Dock = System.Windows.Forms.DockStyle.Right
        Me.pctTitle04.Location = New System.Drawing.Point(730, 0)
        Me.pctTitle04.Name = "pctTitle04"
        Me.pctTitle04.Size = New System.Drawing.Size(64, 36)
        Me.pctTitle04.TabIndex = 6
        Me.pctTitle04.TabStop = False
        '
        'pctTitle02
        '
        Me.pctTitle02.BackgroundImage = CType(resources.GetObject("pctTitle02.BackgroundImage"), System.Drawing.Image)
        Me.pctTitle02.Dock = System.Windows.Forms.DockStyle.Left
        Me.pctTitle02.Location = New System.Drawing.Point(64, 0)
        Me.pctTitle02.Name = "pctTitle02"
        Me.pctTitle02.Size = New System.Drawing.Size(64, 36)
        Me.pctTitle02.TabIndex = 5
        Me.pctTitle02.TabStop = False
        '
        'pctTitle01
        '
        Me.pctTitle01.BackgroundImage = CType(resources.GetObject("pctTitle01.BackgroundImage"), System.Drawing.Image)
        Me.pctTitle01.Dock = System.Windows.Forms.DockStyle.Left
        Me.pctTitle01.Location = New System.Drawing.Point(0, 0)
        Me.pctTitle01.Name = "pctTitle01"
        Me.pctTitle01.Size = New System.Drawing.Size(64, 36)
        Me.pctTitle01.TabIndex = 4
        Me.pctTitle01.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'pnlPages
        '
        Me.pnlPages.BackColor = System.Drawing.Color.Transparent
        Me.pnlPages.BackgroundImage = CType(resources.GetObject("pnlPages.BackgroundImage"), System.Drawing.Image)
        Me.pnlPages.Location = New System.Drawing.Point(3, 144)
        Me.pnlPages.Name = "pnlPages"
        Me.pnlPages.Size = New System.Drawing.Size(794, 417)
        Me.pnlPages.TabIndex = 46
        '
        'Form
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pctIsprP)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlInfoBar)
        Me.Controls.Add(Me.pctTsprI)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.pnlRszDwn)
        Me.Controls.Add(Me.pnlRszRght)
        Me.Controls.Add(Me.pnlRszLft)
        Me.Controls.Add(Me.pnlRszUp)
        Me.Controls.Add(Me.pnlPages)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form"
        Me.Opacity = 0
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatusBar.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.pctStatus02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctStatus01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTsprI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIsprP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfoBar.ResumeLayout(False)
        CType(Me.pctPagePict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleBar.ResumeLayout(False)
        CType(Me.pctTitle03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTitle04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTitle02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTitle01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRszDwn As New System.Windows.Forms.Panel
    Friend WithEvents pnlRszRght As New System.Windows.Forms.Panel
    Friend WithEvents pnlRszLft As New System.Windows.Forms.Panel
    Friend WithEvents pnlRszUp As New System.Windows.Forms.Panel
    Friend WithEvents lblTitle As New System.Windows.Forms.Label
    Friend WithEvents pctClose As New System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As New System.Windows.Forms.Timer
    Friend WithEvents pnlStatusBar As New System.Windows.Forms.Panel
    Friend WithEvents btnCancel As New System.Windows.Forms.Button
    Friend WithEvents btnNext As New System.Windows.Forms.Button
    Friend WithEvents btnBack As New System.Windows.Forms.Button
    Friend WithEvents pctTsprI As New System.Windows.Forms.PictureBox
    Friend WithEvents pctIsprP As New System.Windows.Forms.PictureBox
    Friend WithEvents pnlInfoBar As New System.Windows.Forms.Panel
    Friend WithEvents lblPageName As New System.Windows.Forms.Label
    Friend WithEvents pctPagePict As New System.Windows.Forms.PictureBox
    Friend WithEvents pctStatus02 As New System.Windows.Forms.PictureBox
    Friend WithEvents pctStatus01 As New System.Windows.Forms.PictureBox
    Friend WithEvents pnlTitleBar As New System.Windows.Forms.Panel
    Friend WithEvents pctTitle03 As New System.Windows.Forms.PictureBox
    Friend WithEvents pctTitle04 As New System.Windows.Forms.PictureBox
    Friend WithEvents pctTitle02 As New System.Windows.Forms.PictureBox
    Friend WithEvents pctTitle01 As New System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As New System.Windows.Forms.Timer
    Friend WithEvents lblEleman As New System.Windows.Forms.Label
    Friend WithEvents lblPageInfo As New System.Windows.Forms.Label
    Friend WithEvents pnlPages As New System.Windows.Forms.Panel
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel

End Class
