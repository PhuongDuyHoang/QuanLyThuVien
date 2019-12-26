Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ucTraCuuSach

    Private vaitroBus As New VaiTroBUS
    Private dausachBus As New DauSachBUS

    Private tinhtrangBus As New TinhTrangBUS
    Dim listTinhTrang As New List(Of TinhTrangDTO)


    Private CuonSachBus As New CuonSachBUS


    Dim tacgiaBus As New TacGiaBUS
    Dim listTacGia As New List(Of TacGiaDTO)

    Dim theloaisachBus As New TheLoaiBUS
    Dim listTheLoai As New List(Of TheLoaiDTO)
    Private this As Object

    Dim result As New Result
    Dim dausach_theloai As New DauSach_TheLoaiBus
    Dim dausach_tacgia As New DauSach_TacGiaBus


    Private Sub findCommon(ketqua As List(Of String), timkiem As List(Of String))
        For i As Integer = ketqua.Count - 1 To 0 Step -1
            If timkiem.Contains(ketqua(i)) = False Then
                ketqua.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
       
    End Sub

    Private Sub ucTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theloaisachBus.selectAll(listTheLoai)
        cbTheLoai.DataSource = New BindingSource(listTheLoai, String.Empty)
        cbTheLoai.DisplayMember = "tentheloai"
        cbTheLoai.ValueMember = "matheloai"

        TacGiaBUS.selectAll(listTacGia)
        cbTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        cbTacGia.DisplayMember = "tentacgia"
        cbTacGia.ValueMember = "matacgia"

        tinhtrangBus.selectAll(listTinhTrang)
    End Sub

    Private Sub btnXuatKetQua_Click(sender As Object, e As EventArgs) Handles btnXuatKetQua.Click

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
       
    End Sub

    Private Sub showResult(ketqua As List(Of String))
        For i As Integer = 0 To ketqua.Count - 1
            Dim madausach = ketqua.ElementAt(i)
            Dim dausach As New DauSachDTO

            result = dausachBus.getByMaDauSach(madausach, dausach)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin tên của mã sách " + madausach + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim listTheLoai As New List(Of DauSach_TheLoaiDTO)
            Dim theloai As New TheLoaiDTO
            Dim theloaiStr = ""
            result = dausach_theloai.selectALL_ByMaDauSach(madausach, listTheLoai)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin thể loại của mã sách " + madausach + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For j As Integer = 0 To listTheLoai.Count - 1
                    Dim matheloai = listTheLoai.ElementAt(j).MaTheLoai
                    result = theloaisachBus.getByMaTheLoai(matheloai, theloai)
                    If result.FlagResult = False Then
                        MessageBox.Show("Lấy thông tin tên thể loại của mã thể loại" + matheloai + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        theloaiStr = theloaiStr + theloai.TenTheLoai
                        If j < listTheLoai.Count - 1 Then
                            theloaiStr = theloaiStr + ", "
                        End If
                    End If
                Next
            End If

            Dim listTacGia As New List(Of DauSach_TacGiaDTO)
            Dim tacgia As New TacGiaDTO
            Dim tacgiaStr = ""
            result = dausach_tacgia.selectALL_ByMaDauSach(madausach, listTacGia)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm thông tin tác giả của mã sách " + madausach + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For j As Integer = 0 To listTacGia.Count - 1
                    Dim matacgia = listTacGia.ElementAt(j).MaTacGia
                    result = tacgiaBus.getByMaTacGia(matacgia, tacgia)
                    If result.FlagResult = False Then
                        MessageBox.Show("Lấy thông tin tên tác giả của mã tác giả" + matacgia + " không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        tacgiaStr = tacgiaStr + tacgia.TenTacGia
                        If j < listTacGia.Count - 1 Then
                            tacgiaStr = tacgiaStr + ", "
                        End If
                    End If
                Next
            End If

            Dim s As String()
            s = New String() {madausach, dausach.TenDauSach, theloaiStr, tacgiaStr}
            dgDanhSachSach.Rows.Add(s)
        Next

    End Sub

    Private Sub dgDanhSachSach_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles dgDanhSachSach.RowPostPaint
        Using b As SolidBrush = New SolidBrush(dgDanhSachSach.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), dgDanhSachSach.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 2)
        End Using
    End Sub

    Private Sub tbMaSach_OnValueChanged(sender As Object, e As EventArgs) Handles tbMaSach.OnValueChanged

    End Sub
End Class
