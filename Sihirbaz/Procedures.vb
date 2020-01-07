Imports Sihirbaz.fnct
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class prcd


    Public Shared sayi As Integer

    Public Shared slctd As String

    Public Shared bbmp As Bitmap
    Public Shared pctrbox As New PictureBox
    Public Shared v_mtbmask As String
    Public Shared v_mtbchanged As Boolean
    Public Shared v_loca As Integer
    Public Shared addr As String
    Public Shared v_animyon As String
    Public Shared constr As String

#Region "Nesneler"

    Public Shared WithEvents dsCelebi As New DataSet
    Public Shared WithEvents bsEleman As System.Windows.Forms.BindingSource
    Public Shared WithEvents bsMarka As System.Windows.Forms.BindingSource
    Public Shared WithEvents bsMalzeme As System.Windows.Forms.BindingSource
    Public Shared WithEvents bsKan As System.Windows.Forms.BindingSource


    Public Shared Sub InitComp()
        dsCelebi = New DataSet
        bsEleman = New System.Windows.Forms.BindingSource
        bsMarka = New System.Windows.Forms.BindingSource
        bsMalzeme = New System.Windows.Forms.BindingSource
        bsKan = New System.Windows.Forms.BindingSource
        '
        'dsCelebi
        '
        dsCelebi.DataSetName = "dsCelebi"
        dsCelebi.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
        '
        'bsEleman
        '
        p_ConnectServer(dsCelebi, "personel", "SELECT * FROM personel ORDER BY ad ASC")
        bsEleman.DataSource = dsCelebi
        bsEleman.DataMember = "personel"
        bsEleman.Sort = ("ad ASC")
        '
        'bsMarka
        '
        p_ConnectServer(dsCelebi, "marka", "SELECT * FROM marka")
        bsMarka.DataSource = dsCelebi
        bsMarka.DataMember = "marka"
        bsMarka.Sort = ("ad ASC")
        '
        'bsMalzeme
        '
        p_ConnectServer(dsCelebi, "malzeme", "SELECT * FROM malzeme")
        bsMalzeme.DataSource = dsCelebi
        bsMalzeme.DataMember = "malzeme"
        bsMalzeme.Sort = ("ad ASC")
        '
        'bsKan
        '
        p_ConnectServer(dsCelebi, "kan_grup", "SELECT * FROM kan_grup")
        bsKan.DataSource = dsCelebi
        bsKan.DataMember = "kan_grup"
        bsKan.Sort = ("grup ASC")
       
    End Sub

#End Region

#Region "Option Button Procedures"



    Public Shared Sub p_WizardInfo(ByVal sender As Object, ByVal brwsr As WebBrowser, ByVal lbl As Label)
        With CurDir()
            Select Case sender.name
                Case "optSiparis"
                    addr = .ToString & "\Skins\Default\HTML\Siparis.htm"
                    If brwsr.Url.LocalPath <> addr Then
                        brwsr.Url = (New Uri(addr))
                        lbl.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "Siparis", "")
                    End If
                Case "optStkGrs"
                    addr = .ToString & "\Skins\Default\HTML\StokGiris.htm"
                    If brwsr.Url.LocalPath <> addr Then
                        brwsr.Url = (New Uri(addr))
                        lbl.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "StokGirisi", "")
                    End If
                Case "optStkKul"
                    addr = .ToString & "\Skins\Default\HTML\StokKullanim.htm"
                    If brwsr.Url.LocalPath <> addr Then
                        brwsr.Url = (New Uri(addr))
                        lbl.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "StokKullanýmý", "")
                    End If
                Case "optCepStkGrs"
                    addr = .ToString & "\Skins\Default\HTML\CepStokGiris.htm"
                    If brwsr.Url.LocalPath <> addr Then
                        brwsr.Url = (New Uri(addr))
                        lbl.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "CepStokGirisi", "")
                    End If
                Case "optCepStkKul"
                    addr = .ToString & "\Skins\Default\HTML\CepStokKullanim.htm"
                    If brwsr.Url.LocalPath <> addr Then
                        brwsr.Url = (New Uri(addr))
                        lbl.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Fredd Depo", "CepStokKullanýmý", "")
                    End If
            End Select
        End With
    End Sub

    Public Shared Sub p_OptionNonSelect(ByVal sender As Object)
        With sender.parent
            sayi = .Controls.Count
            For a As Integer = 0 To sayi - 1
                With .controls(a)
                    If .GetType.Name = "Button" Then
                        .image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormal.png")
                        .AutoEllipsis = False
                    End If
                End With
            Next
        End With
    End Sub

    Public Shared Sub p_OptionSelect(ByVal sender As Object, ByVal state As String, ByVal down As Boolean)
        With sender
            If .AutoEllipsis = True Then
                Select Case state
                    Case "Down"
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionTickOver.png")
                    Case "Over"
                        If down = False Then .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptiontickDown.png")
                    Case "Leave"
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionTick.png")
                    Case "Up"
                        Call p_OptionNonSelect(sender)
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionTickOver.png")
                        .AutoEllipsis = True

                End Select
            Else
                Select Case state
                    Case "Down"
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormalOver.png")
                    Case "Over"
                        If down = False Then .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormalDown.png")
                    Case "Leave"
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormal.png")
                    Case "Up"
                        Call p_OptionNonSelect(sender)
                        .Image = Image.FromFile(CurDir.ToString & "\Skins\Default\Images\OptionNormalOver.png")
                        .AutoEllipsis = True
                        slctd = sender.AccessibleDescription
                End Select
            End If
        End With
    End Sub

    Public Shared Sub p_WizAnim()

        bbmp = f_copyRect(Form.pnlPages, New RectangleF(0, 0, 794, 415)).Clone

        v_loca = 0
        pctrbox.Size = New System.Drawing.Size(794, 415)
        pctrbox.Location = New System.Drawing.Point(3, 144)
        'pctrbox.BackColor = Color.FromKnownColor(KnownColor.Transparent)
        'pctrbox.BackgroundImage = bbmp
        Form.pnlPages.Controls.Clear()
        Form.Controls.Add(pctrbox)
        pctrbox.BringToFront()
        Form.Timer2.Enabled = True

    End Sub

    Public Shared Sub p_Anim()
        Dim grfx As Graphics = pctrbox.CreateGraphics
        Select Case v_animyon
            Case "Left"
                If v_loca > -794 Then
                    v_loca -= 25

                    grfx.DrawImage(bbmp, v_loca, 0, 794, 415)
                    grfx.Dispose()
                Else
                    Form.Timer2.Enabled = False
                    Form.Controls.Remove(pctrbox)
                End If
            Case "Right"
                If v_loca < 794 Then
                    v_loca += 25
                    grfx.DrawImage(bbmp, v_loca, 0, 794, 415)
                    grfx.Dispose()
                Else
                    Form.Timer2.Enabled = False
                    Form.Controls.Remove(pctrbox)
                End If
            Case "Down"
                If v_loca < 415 Then
                    v_loca += 15
                    grfx.DrawImage(bbmp, 0, v_loca, 794, 415)
                    grfx.Dispose()
                Else
                    Form.Timer2.Enabled = False
                    Form.Controls.Remove(pctrbox)
                End If
            Case "Up"
                If v_loca > -415 Then
                    v_loca -= 15
                    grfx.DrawImage(bbmp, 0, v_loca, 794, 415)
                    grfx.Dispose()
                Else
                    Form.Timer2.Enabled = False
                    Form.Controls.Remove(pctrbox)
                End If
        End Select
    End Sub
#End Region

#Region "SQL Server Procedures"



    Public Shared Sub p_ConnectServer(ByVal ds As DataSet, ByVal tablename As String, ByVal sqlquery As String)

        Dim conn As New SqlConnection(constr)
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sqlquery, conn)
        Dim tables As String() = f_GetTables(constr)
        Dim table As String
        For Each table In tables
            If dsCelebi.Tables.Contains(table) = False Then
                dsCelebi.Tables.Add(table)
            End If
        Next
        ds.Tables(tablename).Rows.Clear()
        da.Fill(ds.Tables(tablename))
    End Sub

#End Region

#Region "MaskedTextBox Procedures"


    Public Shared Sub p_mtbEnter(ByVal mtb As MaskedTextBox)
        mtb.Select(0, mtb.TextLength)
        mtb.Mask = Nothing
    End Sub

    Public Shared Sub p_mtbGotFocus(ByVal mtb As MaskedTextBox)
        mtb.SelectAll()
    End Sub

    Public Shared Sub p_mtbLeave(ByVal mtb As MaskedTextBox)
        mtb.Mask = v_mtbmask
    End Sub

    Public Shared Sub p_mtbTextChanged(ByVal sender As MaskedTextBox)

        v_mtbmask = Nothing
        v_mtbchanged = True
        If sender.TextLength <> 0 Then
            For ccc As Integer = 1 To sender.TextLength Mod 3
                v_mtbmask += "0"
            Next
        End If
        If sender.TextLength >= 3 Then
            For aaa As Integer = 1 To (sender.TextLength - (sender.TextLength Mod 3)) \ 3

                If sender.TextLength Mod 3 = 0 And v_mtbchanged = True Then
                    v_mtbmask += "000"
                    v_mtbchanged = False
                Else
                    v_mtbmask += "/000"
                End If
            Next
        End If
    End Sub

#End Region

    Public Shared Sub p_cmblstMeasureItem(ByVal e As System.Windows.Forms.MeasureItemEventArgs, ByVal width As Integer, ByVal height As Integer)

        e.ItemHeight = height
        e.ItemWidth = width

    End Sub

    Public Shared Sub p_cmblstDrawItem(ByVal e As System.Windows.Forms.DrawItemEventArgs, ByVal pic As String, ByVal lstitem As String)

        Dim myFont As System.Drawing.Font

        e.DrawBackground()

        'Dim rectangle As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
        'e.Graphics.FillRectangle(New TextureBrush(System.Drawing.Image.FromFile("C:\Documents and Settings\3xplor3r\My Documents\PNG\doku.png")), rectangle)

        e.Graphics.DrawImage(System.Drawing.Image.FromFile(pic), 1, e.Bounds.Top + 2, e.Bounds.Height - 6, e.Bounds.Height - 6)

        myFont = New Font("candara", 12, FontStyle.Italic + FontStyle.Bold, GraphicsUnit.Point)

        e.Graphics.DrawString(lstitem, myFont, System.Drawing.Brushes.White, New RectangleF(e.Bounds.X + 48, e.Bounds.Y + 13, e.Bounds.Width, e.Bounds.Height))

        e.DrawFocusRectangle()

    End Sub

    Public Shared Sub p_DataGridColor(ByVal dgv As DataGridView)
        For a As Integer = 0 To dgv.Rows.Count - 1
            If a Mod 2 = 1 Then
                dgv.Rows(a).DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 240)
            Else
                dgv.Rows(a).DefaultCellStyle.BackColor = Color.FromArgb(237, 242, 249)
            End If
        Next
    End Sub

    Public Shared Sub p_DataGridEditColor(ByVal dgv As DataGridView, ByVal row As Integer)
        On Error Resume Next
        If row Mod 2 = 1 Then
            dgv.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 240)
        Else
            dgv.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(237, 242, 249)
        End If
    End Sub

    Public Shared Sub p_CtrlCopy(ByVal src As System.Windows.Forms.Panel, ByVal dest As System.Windows.Forms.Panel)
        dest.Controls.Clear()
        dest.Controls.Add(src)
    End Sub

    Public Shared Sub frms_Load()
        Select Case Home.tmp(2).Name
            Case "Home"
                Home.Home_Load()
            Case "Siparis"
                Siparis.Siparis_Load()
            Case "StkGrs"
                StkGrs.StkGrs_Load()
            Case "StkKul"
                StkKul.StkKul_Load()
            Case "CepStkGrs"
                CepStkGrs.CepStkGrs_Load()
            Case "CepStkKul"
                CepStkKul.CepStkKul_Load()
        End Select
    End Sub

    Public Shared Sub p_kayit_ekle()
        Select Case Home.tmp(2).Name
            Case "Siparis"
                p_siparis()
            Case "StkGrs"
                p_stkgrs()
            Case "StkKul"
                p_stkkul()
            Case "CepStkGrs"
                p_cepstkgrs()
            Case "CepStkKul"
                p_cepstkkul()
        End Select
    End Sub
    Dim mal, per As Integer
    Public Shared Sub p_siparis()
        Dim conn As New SqlConnection(constr)
        Dim da As New SqlDataAdapter
        conn.Open()
        For a As Integer = 0 To Rapor.dgvRapor.RowCount - 1
            Try
                If Rapor.dgvRapor.Rows(a).Cells(1).Value = True Then
                    Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(a).Cells(2).Value & "'")
                    Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                            "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")

                    da.InsertCommand = New SqlCommand( _
                                                    "INSERT INTO siparis " & _
                                                    "VALUES (" & mlzid & _
                                                    "," & perid & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(8).Value & _
                                                    "'," & Rapor.dgvRapor.Rows(a).Cells(7).Value & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(9).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(10).Value & _
                                                    "')", conn)
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        conn.Close()
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    Public Shared Sub p_stkgrs()

        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim da As New SqlDataAdapter
        conn.Open()
        For a As Integer = 0 To Rapor.dgvRapor.RowCount - 1
            Try
                If Rapor.dgvRapor.Rows(a).Cells(1).Value = True Then
                    Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(a).Cells(2).Value & "'")
                    Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                            "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")

                    da.InsertCommand = New SqlCommand( _
                                                    "INSERT INTO stok_giris (malzeme_id, eleman_id, siparis_id, fatura_no, fatura_tarihi, tarih, miktar, kargo_id, fiyat)" & _
                                                    "VALUES (" & mlzid & _
                                                    "," & perid & _
                                                    "," & "85" & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(11).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(12).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(10).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(8).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(7).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(9).Value & _
                                                    "')", conn)
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        conn.Close()
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub


    Public Shared Sub p_stkkul()
        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim da As New SqlDataAdapter
        conn.Open()
        For a As Integer = 0 To Rapor.dgvRapor.RowCount - 1
            Try
                If Rapor.dgvRapor.Rows(a).Cells(1).Value = True Then
                    Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(a).Cells(2).Value & "'")
                    Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                            "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")

                    da.InsertCommand = New SqlCommand( _
                                                    "INSERT INTO stok_kullanim (malzeme_id, eleman_id, miktar, tarih, aciklama)" & _
                                                    "VALUES (" & mlzid & _
                                                    "," & perid & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(6).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(7).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(8).Value & _
                                                    "')", conn)
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        conn.Close()
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    Public Shared Sub p_cepstkkul()
        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim da As New SqlDataAdapter
        conn.Open()
        For a As Integer = 0 To Rapor.dgvRapor.RowCount - 1
            Try
                If Rapor.dgvRapor.Rows(a).Cells(1).Value = True Then
                    Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(a).Cells(2).Value & "'")
                    Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                            "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")

                    da.InsertCommand = New SqlCommand( _
                                                    "INSERT INTO cepstok_kullanimi (malzeme_id, eleman_id, miktar, tarih, aciklama)" & _
                                                    "VALUES (" & mlzid & _
                                                    "," & perid & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(6).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(7).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(8).Value & _
                                                    "')", conn)
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        conn.Close()
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub



    Public Shared Sub p_cepstkgrs()
        Dim conn As New SqlConnection(constr)
        Dim komut As New SqlCommand
        Dim da As New SqlDataAdapter
        conn.Open()
        For a As Integer = 0 To Rapor.dgvRapor.RowCount - 1
            Try
                If Rapor.dgvRapor.Rows(a).Cells(1).Value = True Then
                    Dim mlzid As Integer = f_GetID("SELECT id FROM malzeme WHERE ad='" & Rapor.dgvRapor.Rows(a).Cells(2).Value & "'")
                    Dim perid As Integer = f_GetID("SELECT id FROM personel WHERE ad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(1).ToString.TrimEnd & _
                                                                            "' AND soyad='" & dsCelebi.Tables("personel").Rows(Home.cmbEleman.SelectedIndex).Item(2).ToString.TrimEnd & "'")

                    da.InsertCommand = New SqlCommand( _
                                                    "INSERT INTO cepstok_giris (malzeme_id, eleman_id, miktar, tarih, aciklama)" & _
                                                    "VALUES (" & mlzid & _
                                                    "," & perid & _
                                                    ",'" & Rapor.dgvRapor.Rows(a).Cells(6).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(7).Value & _
                                                    "','" & Rapor.dgvRapor.Rows(a).Cells(8).Value & _
                                                    "')", conn)
                    da.InsertCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Next
        conn.Close()
        Form.v_opac = "Close"
        Form.Timer1.Enabled = True
    End Sub

    

    

    Public Shared Sub btns_Next_Click()
        v_animyon = "Left"
        p_WizAnim()
        Rapor.Rapor_Load()
        p_CtrlCopy(Rapor.pnlRapor, Form.pnlPages)
        p_CtrlCopy(Rapor.pnlStatusBar, Form.pnlButtons)
    End Sub

    Public Shared Sub btns_Back_Click()
        v_animyon = "Right"
        p_WizAnim()
        Home.Home_Load()
        p_CtrlCopy(Home.pnlHome, Form.pnlPages)
        p_CtrlCopy(Home.pnlStatusBar, Form.pnlButtons)
    End Sub


    Public Shared Sub DrawBorder(ByVal sender As Control)

        Dim w As Integer = 1
        Dim r As Integer = 5 + w
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(214, 213, 217), w)
        Dim g As System.Drawing.Graphics
        g = sender.CreateGraphics()
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.DrawLine(myPen, r + (w - 1), 0 + (w - 1), sender.Width - (r + w - 1), 0 + (w - 1))
        g.DrawLine(myPen, 0 + (w - 1), r + (w - 1), 0 + (w - 1), sender.Height - (r + w - 1))
        g.DrawLine(myPen, sender.Width - (r + w - 1), sender.Height - w, r + (w - 1), sender.Height - (w))
        g.DrawLine(myPen, sender.Width - w, sender.Height - (r + w - 1), sender.Width - w, r + (w - 1))
        g.DrawArc(myPen, 0 + (w - 1), 0 + (w - 1), (r * 2), (r * 2), 180, 90)
        g.DrawArc(myPen, sender.Width - ((r * 2) + w), 0 + (w - 1), (r * 2), (r * 2), 270, 90)
        g.DrawArc(myPen, 0 + (w - 1), sender.Height - ((r * 2) + w), (r * 2), (r * 2), 90, 90)
        g.DrawArc(myPen, sender.Width - ((r * 2) + w), sender.Height - ((r * 2) + w), (r * 2), (r * 2), 360, 90)
        myPen.Dispose()
        g.Dispose()
    End Sub

End Class
