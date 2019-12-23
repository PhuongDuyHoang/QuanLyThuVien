Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing

Public Class ucTiepNhanSachMoi
    Public maphieunhap As String
    Public nhacungcap As String
    Public nguoinhap As String

    Dim dausach As New DauSachDTO
    Dim dausachBus As New DauSachBUS
    Dim nhaxuatbanBus As New NhaXuatBanBUS
    Dim theloaiBus As New TheLoaiBUS
    Dim ngonnguBus As New NgonNguBUS
    Dim tacgiaBus As New TacGiaBUS
    Dim tinhtrangBus As New TinhTrangBUS
    Dim dausach_theloaiBus As New DauSach_TheLoaiBus
    Dim dausach_tacgiaBus As New DauSach_TacGiaBus
    Dim dausach_ngonnguBus As New DauSach_NgonNguBus
    Dim chitietphieunhapBus As New ChiTietPhieuNhapBUS
    Dim cuonsachBus As New CuonSachBUS
    Dim phieunhapBus As New PhieuNhapBUS

    Dim listNhaXuatBan As New List(Of NhaXuatBanDTO)
    Dim listTheLoai As New List(Of TheLoaiDTO)
    Dim listNgonNgu As New List(Of NgonNguDTO)
    Dim listTacGia As New List(Of TacGiaDTO)
    Dim listTinhTrang As New List(Of TinhTrangDTO)

    Dim listChonTheLoai As New List(Of TheLoaiDTO)
    Dim listChonNgonNgu As New List(Of NgonNguDTO)
    Dim listChonTacGia As New List(Of TacGiaDTO)

    Private Sub ucTiepNhanSachMoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dausachBus.buildMaDauSach(lbMaDauSach.Text)

        nhaxuatbanBus.selectAll(listNhaXuatBan)
        cbNhaXuatBan.DataSource = New BindingSource(listNhaXuatBan, String.Empty)
        cbNhaXuatBan.DisplayMember = "tennhaxuatban"
        cbNhaXuatBan.ValueMember = "manhaxuatban"

        theloaiBus.selectAll(listTheLoai)
        cbTheLoai.DataSource = New BindingSource(listTheLoai, String.Empty)
        cbTheLoai.DisplayMember = "tentheloai"
        cbTheLoai.ValueMember = "matheloai"

        tacgiaBus.selectAll(listTacGia)
        cbTacGia.DataSource = New BindingSource(listTacGia, String.Empty)
        cbTacGia.DisplayMember = "tentacgia"
        cbTacGia.ValueMember = "matacgia"

        ngonnguBus.selectALL(listNgonNgu)
        cbNgonNgu.DataSource = New BindingSource(listNgonNgu, String.Empty)
        cbNgonNgu.DisplayMember = "tenngonngu"
        cbNgonNgu.ValueMember = "mangonngu"

        tinhtrangBus.selectAll(listTinhTrang)
        cbTinhTrang.DataSource = New BindingSource(listTinhTrang, String.Empty)
        cbTinhTrang.DisplayMember = "tentinhtrang"
        cbTinhTrang.ValueMember = "matinhtrang"

        cbNhaXuatBan.SelectedIndex = -1
        cbNgonNgu.SelectedIndex = -1
        cbTheLoai.SelectedIndex = -1
        cbTacGia.SelectedIndex = -1
        cbTinhTrang.SelectedIndex = -1

        lbDSTheLoai.Text = ""
        lbDSTacGia.Text = ""
        lbDSNgonNgu.Text = ""
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Back(sender)
    End Sub

    Private Sub Back(sender As Object)
        Dim current As ucTiepNhanSachMoi
        current = sender.Parent
        Dim parent As ucPhieuNhap
        parent = current.Parent
        Dim parent2 As ucQuanLySach
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim phieunhap As New ucPhieuNhap With {
            .dangnhap = parent4.dangnhap
        }
        parent2.Controls.Clear()
        parent2.Controls.Add(phieunhap)
    End Sub

    Private Sub BackWithData(sender As Object)
        Dim current As ucTiepNhanSachMoi
        current = sender.Parent
        Dim parent As ucPhieuNhap
        parent = current.Parent
        Dim parent2 As ucQuanLySach
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim phieunhap As New ucPhieuNhap With {
            .dangnhap = parent4.dangnhap,
            .maphieunhap = maphieunhap,
            .nhacungcap = nhacungcap
        }
        parent2.Controls.Clear()
        parent2.Controls.Add(phieunhap)
    End Sub

    Private Sub btAddTheLoai_Click(sender As Object, e As EventArgs) Handles btAddTheLoai.Click
        If cbTheLoai.SelectedIndex > -1 Then
            If (listChonTheLoai.Contains(cbTheLoai.SelectedItem) = False) Then
                listChonTheLoai.Add(cbTheLoai.SelectedItem)

                If (lbDSTheLoai.Text <> "") Then
                    lbDSTheLoai.Text = lbDSTheLoai.Text + ", "
                End If
                lbDSTheLoai.Text = lbDSTheLoai.Text + cbTheLoai.SelectedText
            End If
        End If
    End Sub

    Private Sub btnAddTacGia_Click(sender As Object, e As EventArgs) Handles btnAddTacGia.Click
        If cbTacGia.SelectedIndex > -1 Then
            If (listChonTacGia.Contains(cbTacGia.SelectedItem) = False) Then
                listChonTacGia.Add(cbTacGia.SelectedItem)

                If (lbDSTacGia.Text <> "") Then
                    lbDSTacGia.Text = lbDSTacGia.Text + ", "
                End If
                lbDSTacGia.Text = lbDSTacGia.Text + cbTacGia.SelectedText
            End If
        End If
    End Sub

    Private Sub btnAddNgonNgu_Click(sender As Object, e As EventArgs) Handles btnAddNgonNgu.Click
        If cbNgonNgu.SelectedIndex > -1 Then
            If (listChonNgonNgu.Contains(cbNgonNgu.SelectedItem) = False) Then
                listChonNgonNgu.Add(cbNgonNgu.SelectedItem)

                If (lbDSNgonNgu.Text <> "") Then
                    lbDSNgonNgu.Text = lbDSNgonNgu.Text + ", "
                End If
                lbDSNgonNgu.Text = lbDSNgonNgu.Text + cbNgonNgu.SelectedText
            End If
        End If
    End Sub

    Private Sub lbXoaTheLoai_Click(sender As Object, e As EventArgs) Handles lbXoaTheLoai.Click
        listChonTheLoai.Clear()
        lbDSTheLoai.Text = ""
    End Sub

    Private Sub lbXoaTacGia_Click(sender As Object, e As EventArgs) Handles lbXoaTacGia.Click
        listChonTacGia.Clear()
        lbDSTacGia.Text = ""
    End Sub

    Private Sub lbXoaNgonNgu_Click(sender As Object, e As EventArgs) Handles lbXoaNgonNgu.Click
        listChonNgonNgu.Clear()
        lbDSNgonNgu.Text = ""
    End Sub

    Private Sub tbTriGia_OnValueChanged(sender As Object, e As EventArgs) Handles tbTriGia.OnValueChanged
        ThanhTien()
    End Sub

    Private Sub nudSoLuong_ValueChanged(sender As Object, e As EventArgs) Handles nudSoLuong.ValueChanged
        ThanhTien()
    End Sub

    Private Function ThanhTien() As Integer
        If tbTriGia.Text = "" Then
            Return 0
        End If
        Dim tongtien = Convert.ToInt64(tbTriGia.Text) * nudSoLuong.Value
        lbThanhTien.Text = tongtien.ToString("###,###,###")

        Return tongtien
    End Function

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If (tbTenDauSach.Text = "" Or cbNhaXuatBan.SelectedIndex = -1 Or listChonTheLoai.Count = 0 Or
            listChonTacGia.Count = 0 Or listChonNgonNgu.Count = 0 Or cbTinhTrang.SelectedIndex = -1) Then
            MessageBox.Show("Nhập các trường bắt buộc!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        Dim result As New Result

        'Them dau sach
        Dim dausach As New DauSachDTO
        dausach.MaDauSach = lbMaDauSach.Text
        dausach.TenDauSach = tbTenDauSach.Text
        dausach.TomTat = tbTomTat.Text
        dausach.NhaXuatBan = cbNhaXuatBan.SelectedValue.ToString()
        dausach.NamXuatBan = nudNamXuatBan.Value
        dausach.TriGia = Convert.ToInt64(tbTriGia.Text)

        result = dausachBus.insert(dausach)
        If result.FlagResult = False Then
            Dim mes = "Thêm đầu sách thất bại!" + "\n" + result.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        'Them dau sach-the loai
        For i As Integer = 0 To listChonTheLoai.Count - 1
            Dim x As New DauSach_TheLoaiDTO(lbMaDauSach.Text, listChonTheLoai.ElementAt(i).MaTheLoai)
            result = dausach_theloaiBus.insert(x)
            If result.FlagResult = False Then
                Dim mes = "Thêm đầu sách - thể loại thất bại: " + listChonTheLoai.ElementAt(i).MaTheLoai + "\n" + result.SystemMessage
                MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            End If
        Next

        'Them dau sach-tac gia
        For i As Integer = 0 To listChonTacGia.Count - 1
            Dim x As New DauSach_TacGiaDTO(lbMaDauSach.Text, listChonTacGia.ElementAt(i).MaTacGia)
            result = dausach_tacgiaBus.insert(x)
            If result.FlagResult = False Then
                Dim mes = "Thêm đầu sách - tác giả thất bại: " + listChonTacGia.ElementAt(i).MaTacGia + "\n" + result.SystemMessage
                MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            End If
        Next

        'Them dau sach-ngon ngu
        For i As Integer = 0 To listChonNgonNgu.Count - 1
            Dim x As New DauSach_NgonNguDTO(lbMaDauSach.Text, listChonNgonNgu.ElementAt(i).MaNgonNgu)
            result = dausach_ngonnguBus.insert(x)
            If result.FlagResult = False Then
                Dim mes = "Thêm đầu sách - ngôn ngữ thất bại: " + listChonNgonNgu.ElementAt(i).MaNgonNgu + "\n" + result.SystemMessage
                MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            End If
        Next

        'NOTE: Trước khi thêm chi tiết phiếu nhập, phải đảm bảo trong CSDL đã có mã phiếu nhập rồi,
        'vì mã phiếu nhập là FK của chi tiết phiếu nhập
        'Them phieu nhap
        Dim phieunhap As New PhieuNhapDTO
        result = phieunhapBus.getByMaPhieuNhap(maphieunhap, phieunhap)
        If result.FlagResult = False Then ' Chua tao phieu nhap
            phieunhap.MaPhieuNhap = maphieunhap
            phieunhap.NgayNhap = Today
            phieunhap.NguoiNhap = nguoinhap
            phieunhap.NhaCungCap = nhacungcap
            phieunhapBus.insert(phieunhap)
        End If

        'Them chi tiet phieu nhap
        Dim chitietphieunhap As New ChiTietPhieuNhapDTO
        chitietphieunhap.MaPhieuNhap = maphieunhap
        chitietphieunhap.MaDauSach = lbMaDauSach.Text
        chitietphieunhap.SoLuong = nudSoLuong.Value
        chitietphieunhap.GhiChu = tbGhiChu.Text
        chitietphieunhap.ThanhTien = ThanhTien()

        result = chitietphieunhapBus.insert(chitietphieunhap)
        If result.FlagResult = False Then
            Dim mes = "Thêm chi tiết phiếu nhập thất bại!" + "\n" + result.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        'Them cuon sach
        For i As Integer = 1 To nudSoLuong.Value
            Dim cuonsach As New CuonSachDTO
            Dim macuonsach As String
            macuonsach = ""
            cuonsachBus.buildMaCuonSach(macuonsach)

            cuonsach.MaCuonSach = macuonsach
            cuonsach.TinhTrang = cbTinhTrang.SelectedValue.ToString
            cuonsach.DauSach = lbMaDauSach.Text
            cuonsach.SoKe = nudViTriKe.Value

            result = cuonsachBus.insert(cuonsach)
            If result.FlagResult = False Then
                Dim mes = "Thêm cuốn sách thất bại: " + macuonsach + "\n" + result.SystemMessage
                MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            End If
        Next

        MessageBox.Show("Tiếp nhận sách thành công!", "Thông báo", MessageBoxButtons.OK)
        BackWithData(sender)
    End Sub
End Class
