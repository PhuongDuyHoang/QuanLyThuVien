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
        dgDanhSachSach.Rows.Clear()

        Dim ketqua As New List(Of String)
        Dim timkiem As New List(Of String)
        Dim listDSTL As New List(Of DauSach_TheLoaiDTO)
        Dim listDSTG As New List(Of DauSach_TacGiaDTO)


        ' lay tat ca ma sach
        result = dausachBus.selectAll_MaDauSach("%", ketqua)
        If result.FlagResult = False Then
            MessageBox.Show("Lấy danh sách mã đầu sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' tim kiem theo ma sach
        timkiem.Clear()
        If tbMaSach.Text.Length > 0 Then
            result = dausachBus.filter_MaSach("%" + tbMaSach.Text + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo mã sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem) ' giao 2 list
            End If
        End If

        ' tim kiem theo ten sach
        timkiem.Clear()
        If tbTenSach.Text.Length > 0 Then
            result = dausachBus.filter_TenSach("%" + tbTenSach.Text + "%", timkiem)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo ten sach không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                findCommon(ketqua, timkiem) ' giao 2 list
            End If
        End If

        ' tim kiem theo the loai
        If cbTheLoai.SelectedIndex > 1 Then
            result = dausach_theloai.selectALL_ByMaTheLoai("%" + cbTheLoai.SelectedValue.ToString() + "%", listDSTL)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo thể loại không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                timkiem.Clear()
                For i As Integer = 0 To listDSTL.Count - 1
                    timkiem.Add(listDSTL.ElementAt(i).MaDauSach)
                Next

                findCommon(ketqua, timkiem)
            End If
        End If

        ' tim kiem theo tac gia
        If cbTacGia.SelectedIndex > 1 Then
            result = dausach_tacgia.selectALL_ByMaTacGia("%" + cbTacGia.SelectedValue.ToString() + "%", listDSTG)
            If result.FlagResult = False Then
                MessageBox.Show("Tìm kiếm theo tác giả không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                timkiem.Clear()
                For i As Integer = 0 To listDSTG.Count - 1
                    timkiem.Add(listDSTG.ElementAt(i).MaDauSach)
                Next

                findCommon(ketqua, timkiem)
            End If
        End If

        If (ketqua.Count > 0) Then
            showResult(ketqua)
        Else
            MessageBox.Show("Không tìm thấy kết quả nào thoả mãn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        Dim parent As ucTraCuuSach
        parent = sender.Parent
        Dim parent2 As ucTraCuu
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim tracuu As New ucTraCuu
        parent3.Controls.Clear()
        parent3.Controls.Add(tracuu)
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
