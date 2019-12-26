Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ucBaoCaoSachTre
    Dim tsBus As New ThamSoBUS
    Dim sachBus As New DauSachBUS
    Dim thoigian As New DateTime
    Dim result As New Result

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        

    End Sub

    Private Sub showresult(listten As List(Of String), listngay As List(Of DateTime))

        If (listten.Count = 0) Then
            MessageBox.Show("Không có sách trả trễ vào ngày " + thoigian.Day.ToString() + "/" + thoigian.Month.ToString() + "/" + thoigian.Year.ToString() + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For i As Integer = 0 To listten.Count - 1
            Dim s As String()
            Dim thoigiantre = (thoigian - listngay.ElementAt(i)).TotalDays
            Console.WriteLine(thoigiantre)
            s = New String() {listten.ElementAt(i), listngay.ElementAt(i), thoigiantre.ToString()}
            dgThongKe.Rows.Add(s)
        Next
    End Sub

    Private Sub dgThongKe_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgThongKe.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgThongKe.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgThongKe.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 1)
        End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        
    End Sub

    Private Sub ucBaoCaoSachTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor = Color.FromArgb(89, 94, 241)
        dtpNgay.Value = Today
    End Sub

    Private Sub btnXuatBaoCao_Click(sender As Object, e As EventArgs) Handles btnXuatBaoCao.Click
       
    End Sub
End Class
