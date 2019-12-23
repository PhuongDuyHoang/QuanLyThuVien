Imports QLTVBus
Imports QLTVDTO

Public Class ucChinhSuaNguoiDung
    Public dangnhap As New DangNhapDTO
    Public nguoidung As New NguoiDungDTO
    Public nguoidungBus As New NguoiDungBUS
    Public vaitro As New VaiTroDTO
    Public vaitroBus As New VaiTroBUS
    Public dangnhapBus As New DangNhapBus

    Private Sub ucChinhSuaNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbDangNhap.Height = 134

        nguoidungBus.getByMaNguoiDung(dangnhap.NguoiDung, nguoidung)
        vaitroBus.getByMaVaiTro(nguoidung.VaiTro, vaitro)

        lbMaNguoiDung.Text = nguoidung.MaNguoiDung
        lbHoTen.Text = nguoidung.HoTen
        lbNgaySinh.Text = nguoidung.NgaySinh.ToString("dd/MM/yyyy")
        lbCMND.Text = nguoidung.CMND
        tbDiaChi.Text = nguoidung.DiaChi
        tbEmail.Text = nguoidung.Email
        tbSoDienThoai.Text = nguoidung.SoDienThoai
        lbNgayTao.Text = nguoidung.NgayTao.ToString("dd/MM/yyyy")

        If nguoidung.GioiTinh = False Then
            lbGioiTinh.Text = "Nam"
        Else
            lbGioiTinh.Text = "Nữ"
        End If

        'cbVaiTro
        Dim listVaiTro = New List(Of VaiTroDTO)

        vaitroBus.selectAll(listVaiTro)
        cbVaiTro.DataSource = New BindingSource(listVaiTro, String.Empty)
        cbVaiTro.DisplayMember = "tenvaitro"
        cbVaiTro.ValueMember = "mavaitro"
        cbVaiTro.SelectedValue = nguoidung.VaiTro

        If vaitro.TenVaiTro <> "ADMIN" Then
            cbVaiTro.Enabled = False
        End If

        'Dang nhap
        tbTenDangNhap.Text = dangnhap.TenDangNhap
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Back(sender)
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucChinhSuaNguoiDung
        parent = sender.Parent
        Dim parent2 As ucThongTinNguoiDung
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim thongtin As New ucThongTinNguoiDung With {
            .dangnhap = parent4.dangnhap
        }
        parent3.Controls.Clear()
        parent3.Controls.Add(thongtin)
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim res
        Dim userLogin As New DangNhapDTO

        'Map data
        nguoidung.DiaChi = tbDiaChi.Text
        nguoidung.Email = tbEmail.Text
        nguoidung.SoDienThoai = tbSoDienThoai.Text
        nguoidung.VaiTro = cbVaiTro.SelectedValue.ToString

        If gbDangNhap.Height = 373 Then
            If tbMatKhau.Text = "" Or tbMatKhauMoi.Text = "" Or tbNhapLaiMatKhauMoi.Text = "" Then
                MessageBox.Show("Nhập đầy đủ các trường bắt buộc!", "Lỗi", MessageBoxButtons.OK)
                Return
            End If
            If tbMatKhauMoi.Text <> tbNhapLaiMatKhauMoi.Text Then
                MessageBox.Show("Nhập lại mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK)
                Return
            End If
            If tbTenDangNhap.Text <> dangnhap.TenDangNhap And tbMatKhau.Text <> dangnhap.MatKhau Then
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK)
                Return
            End If

            dangnhap.MatKhau = tbMatKhauMoi.Text
        End If

        dangnhap.TenDangNhap = tbTenDangNhap.Text

        res = dangnhapBus.update(dangnhap)
        If res.FlagResult = False Then
            Dim mes = "Cập nhật tài khoản đăng nhập thất bại!" + "\n" + res.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Back(sender)
            Return
        End If

        res = nguoidungBus.update(nguoidung)
        If res.FlagResult = False Then
            Dim mes = "Cập nhật người dùng thất bại!" + "\n" + res.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Back(sender)
            Return
        End If

        MessageBox.Show("Cập nhật thành công!" + res.SystemMessage, "Thông tin", MessageBoxButtons.OK)
        Back(sender)
    End Sub

    Private Sub lbDoiMatKhau_Click(sender As Object, e As EventArgs) Handles lbDoiMatKhau.Click
        If gbDangNhap.Height = 134 Then
            gbDangNhap.Height = 373
        Else
            gbDangNhap.Height = 134
        End If

        tbMatKhau.Clear()
        tbMatKhauMoi.Clear()
        tbNhapLaiMatKhauMoi.Clear()
    End Sub
End Class
