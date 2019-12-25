    Imports QLTVDTO
    Imports QLTVBus
    Imports Utility
    Imports System.Drawing
    Imports System.IO
    Imports iTextSharp.text
    Imports iTextSharp.text.pdf

    Public Class ucBaoCaoSachMuon
        Dim month = 0
        Dim year = 0
        Dim result As New Result
        Dim ctpmBus As New ChiTietPhieuMuonBUS

     Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click

           
        End Function

        Private Function showresult(listten As List(Of TheLoaiDTO), listsoluotmuon As List(Of Integer))
            dgThongKe.Rows.Clear()

            If listten.Count = 0 Then
                Dim s = "Không có lượt mượn nào"
                If month > 0 Then
                    s += " vào tháng " + month.ToString()
                End If
                If year > 1900 And year <= 2100 Then
                    s += " năm " + year.ToString()
                End If
                s += "!"
                MessageBox.Show(s, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' sum all
            Dim sum = 0
            For Each i As Integer In listsoluotmuon
                sum += i
            Next
            lbTongLuotMuon.Text = sum.ToString()

            For i As Integer = 0 To listten.Count - 1
                Dim tile As Double = listsoluotmuon.ElementAt(i) * 100 / sum
                Dim phantram As String = Math.Round(tile, 2).ToString + "%"
                Dim s As String()
                s = New String() {listten.ElementAt(i).MaTheLoai, listten.ElementAt(i).TenTheLoai, listsoluotmuon.ElementAt(i).ToString(), phantram}
                dgThongKe.Rows.Add(s)
            Next

        End Function

        Private Sub dgThongKe_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
            Using b As SolidBrush = New SolidBrush(dgThongKe.RowHeadersDefaultCellStyle.ForeColor)
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgThongKe.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 1)
            End Using
        End Sub

        Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
           
        End Sub

        Private Sub ucBaoCaoSachMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Label1.ForeColor = Color.FromArgb(89, 94, 241)
            tbThang.Text = Today.Month.ToString()
            tbNam.Text = Today.Year.ToString()
        End Sub

        Private Sub btnXuatBaoCao_Click(sender As Object, e As EventArgs) Handles btnXuatBaoCao.Click
            
        End Sub
    End Class
