Imports QLTVDTO
Imports QLTVBus

Public Class ucThemNguoiDung
    Private vaitroBus As New VaiTroBUS
    Private nguoidungBus As New NguoiDungBUS
    Public isLapTheDocGia As New Boolean

    Private Sub ucThemNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbVaiTro
        Dim listVaiTro = New List(Of VaiTroDTO)

        vaitroBus.selectAll(listVaiTro)
        cbVaiTro.DataSource = New BindingSource(listVaiTro, String.Empty)
        cbVaiTro.DisplayMember = "tenvaitro"
        cbVaiTro.ValueMember = "mavaitro"

        If isLapTheDocGia = True Then
            cbVaiTro.SelectedValue = "VT000006"
            cbVaiTro.Enabled = False
        End If

        'lbMaNguoiDung
        nguoidungBus.buildMaNguoiDung(lbMaNguoiDung.Text)

        'lbNgayTao
        lbNgayTao.Text = Today.ToString("dd/MM/yyyy")

        'dtpNgaySinh
        dtpNgaySinh.Value = New Date(2000, 1, 1)

        'cbGioiTinh
        cbGioiTinh.Items.Insert(0, "Nam")
        cbGioiTinh.Items.Insert(1, "Nữ")
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
       
    End Sub

    Private Sub TaoTaiKhoanDangNhap()
        Dim dangnhap As New DangNhapDTO
        Dim dangnhapBus As New DangNhapBus

        Dim result = dangnhapBus.buildMaDangNhap(dangnhap.MaDangNhap)
        If result.FlagResult = False Then
            MessageBox.Show("Tạo tài khoản đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        dangnhap.NguoiDung = lbMaNguoiDung.Text
        dangnhap.TenDangNhap = tbHoTen.Text
        dangnhap.MatKhau = CInt(Math.Ceiling(Rnd() * 999999)) + 1
        dangnhap.DangNhapLanDau = True

        result = dangnhapBus.insert(dangnhap)
        If result.FlagResult = False Then
            MessageBox.Show("Tạo tài khoản đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK)
        Else
            Dim mes = "Tạo tài khoản đăng nhập thành công!" + Environment.NewLine
            mes = mes + "Tên đăng nhập: " + dangnhap.TenDangNhap + Environment.NewLine
            mes = mes + "Mật khẩu: " + dangnhap.MatKhau
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
      
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucThemNguoiDung
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

    Private Sub Back2(sender As Object)
        Dim parent As ucThemNguoiDung
        parent = sender.Parent
        Dim parent2 As ucDocGia
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim ucdocgia As New ucDocGia
        parent3.Controls.Clear()
        parent3.Controls.Add(ucdocgia)
    End Sub
End Class
