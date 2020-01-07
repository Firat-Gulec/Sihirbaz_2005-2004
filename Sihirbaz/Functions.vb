Imports Sihirbaz.prcd


Public Class fnct


    Declare Auto Function BitBlt Lib "GDI32.DLL" ( _
                         ByVal hdcDest As IntPtr, _
                         ByVal nXDest As Integer, _
                         ByVal nYDest As Integer, _
                         ByVal nWidth As Integer, _
                         ByVal nHeight As Integer, _
                         ByVal hdcSrc As IntPtr, _
                         ByVal nXSrc As Integer, _
                         ByVal nYSrc As Integer, _
                         ByVal dwRop As Int32) As Boolean

    Public Shared Function f_copyRect(ByVal src As Control, ByVal rect As RectangleF) As Bitmap

        Dim srcPic As Graphics = src.CreateGraphics
        Dim srcBmp As New Bitmap(rect.Width, rect.Height, srcPic)
        Dim srcMem As Graphics = Graphics.FromImage(srcBmp)
        Dim HDC1 As IntPtr = srcPic.GetHdc
        Dim HDC2 As IntPtr = srcMem.GetHdc

        BitBlt(HDC2, rect.X, rect.Y, rect.Width, rect.Height, HDC1, rect.X, rect.Y, 13369376)

        f_copyRect = srcBmp.Clone()

        srcMem.Dispose()
    End Function

    Public Shared Function f_SelectedOpt(ByVal parent As System.Windows.Forms.Panel, ByVal arr() As String) As System.Windows.Forms.Control()
        Dim tmp As Button
        Dim btntmp() As System.Windows.Forms.Control = New System.Windows.Forms.Control(2) {}
        For Each tmp In parent.Controls
            If tmp.AutoEllipsis = True Then
                Select Case tmp.Name
                    Case arr(0)
                        btntmp(0) = Siparis.pnlSiparis
                        btntmp(1) = Siparis.pnlStatusBar
                        btntmp(2) = Siparis
                    Case arr(1)
                        btntmp(0) = StkGrs.pnlStkGrs
                        btntmp(1) = StkGrs.pnlStatusBar
                        btntmp(2) = StkGrs
                    Case arr(2)
                        btntmp(0) = StkKul.pnlStkKul
                        btntmp(1) = StkKul.pnlStatusBar
                        btntmp(2) = StkKul
                    Case arr(3)
                        btntmp(0) = CepStkGrs.pnlCepStkGrs
                        btntmp(1) = CepStkGrs.pnlStatusBar
                        btntmp(2) = CepStkGrs
                    Case arr(4)
                        btntmp(0) = CepStkKul.pnlCepStkKul
                        btntmp(1) = CepStkKul.pnlStatusBar
                        btntmp(2) = CepStkKul
                End Select
            End If
        Next
        f_SelectedOpt = btntmp
    End Function

    Public Shared Function f_UserName(ByVal ds As DataSet, ByVal cmb As System.Windows.Forms.ComboBox) As String
        Dim tmp As String
        tmp = ds.Tables("personel").Rows(cmb.SelectedIndex).Item(1).ToString.TrimEnd & " " & _
        ds.Tables("personel").Rows(cmb.SelectedIndex).Item(2).ToString.TrimEnd()
        f_UserName = tmp
    End Function

    Public Shared Function f_GetTables(ByVal connString As String) As String()
        Dim cn As New SqlClient.SqlConnection(connString)
        Dim da As New SqlClient.SqlDataAdapter(" USE fredepo SELECT name FROM tables", cn)
        Dim dt As New DataTable

        da.Fill(dt)

        Dim tables(dt.Rows.Count - 1) As String
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            tables(i) = Trim(dt.Rows(i)(0))
        Next
        f_GetTables = tables
    End Function

    Public Shared Function f_GetID(ByVal query As String) As Integer
        Dim conn As New SqlClient.SqlConnection(constr)
        Dim da As New SqlClient.SqlDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt.Rows(0)(0)
    End Function
End Class
