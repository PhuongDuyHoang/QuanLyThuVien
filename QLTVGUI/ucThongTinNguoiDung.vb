Imports QLTVDTO
Imports QLTVBus


Public Class ucThongTinNguoiDung
    Public dangnhap As New DangNhapDTO
    Public nguoidung As New NguoiDungDTO
    Public nguoidungBus As New NguoiDungBUS
    Public vaitro As New VaiTroDTO
    Public vaitroBus As New VaiTroBUS

    Private Sub ucThongTinNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nguoidungBus.getByMaNguoiDung(dangnhap.NguoiDung, nguoidung)
        vaitroBus.getByMaVaiTro(nguoidung.VaiTro, vaitro)

        lbMaNguoiDung.Text = nguoidung.MaNguoiDung
        lbHoTen.Text = nguoidung.HoTen
        lbNgaySinh.Text = nguoidung.NgaySinh.ToString("dd/MM/yyyy")
        lbCMND.Text = nguoidung.CMND
        lbDiaChi.Text = nguoidung.DiaChi
        lbEmail.Text = nguoidung.Email
        lbSoDienThoai.Text = nguoidung.SoDienThoai
        lbNgayTao.Text = nguoidung.NgayTao.ToString("dd/MM/yyyy")
        lbVaiTro.Text = vaitro.TenVaiTro

        If nguoidung.GioiTinh = False Then
            lbGioiTinh.Text = "Nam"
        Else
            lbGioiTinh.Text = "Nữ"
        End If

        If vaitro.TenVaiTro <> "ADMIN" Then
            btnThemNguoiDung.Enabled = False
        End If

        If vaitro.TenVaiTro <> "ĐỘC GIẢ" Then
            btnLichSuMuonTra.Enabled = False
        End If
    End Sub

    Private Sub btnThemNguoiDung_Click(sender As Object, e As EventArgs) Handles btnThemNguoiDung.Click
     
    End Sub

    Private Sub btnTimKiemNguoiDung_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnChinhSuaThongTin_Click(sender As Object, e As EventArgs) Handles btnChinhSuaThongTin.Click
      
    End Sub

    Private Sub btnLichSuMuonTra_Click(sender As Object, e As EventArgs) Handles btnLichSuMuonTra.Click

    End Sub
End Class
