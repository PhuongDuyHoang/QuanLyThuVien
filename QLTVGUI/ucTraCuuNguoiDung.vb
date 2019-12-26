Imports QLTVBus
Imports QLTVDTO

Public Class ucTraCuuNguoiDung
    Private vaitroBus As New VaiTroBUS
    Private nguoidungBus As New NguoiDungBUS
    Dim timkiem As New List(Of NguoiDungDTO)

    Private Sub TraCuuNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbVaiTro
        Dim listVaiTro = New List(Of VaiTroDTO)
        listVaiTro.Add(New VaiTroDTO("", "Tất cả"))

        vaitroBus.selectAll(listVaiTro)
        cbVaiTro.DataSource = New BindingSource(listVaiTro, String.Empty)
        cbVaiTro.DisplayMember = "tenvaitro"
        cbVaiTro.ValueMember = "mavaitro"

        'dtp
        dtpNgayTaoCaoNhat.Value = Today

        Me.Height = 530
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Back(sender)
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucTraCuuNguoiDung
        parent = sender.Parent
        Dim parent2 As ucTraCuu
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim tracuu As New ucTraCuu
        parent3.Controls.Clear()
        parent3.Controls.Add(tracuu)
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        
    End Sub

    Private Sub dgDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDanhSach.CellContentClick
        Me.Height = 700

        Dim ngClick = timkiem.ElementAt(e.RowIndex)
        lbMaNguoiDung.Text = ngClick.MaNguoiDung
        lbHoTen.Text = ngClick.HoTen
        lbNgaySinh.Text = ngClick.NgaySinh.ToString("dd/MM/yyyy")
        lbCMND.Text = ngClick.CMND
        lbDiaChi.Text = ngClick.DiaChi
        lbEmail.Text = ngClick.Email
        lbSoDienThoai.Text = ngClick.SoDienThoai
        lbNgayTao.Text = ngClick.NgayTao.ToString("dd/MM/yyyy")

        Dim ngVaiTro As New VaiTroDTO
        vaitroBus.getByMaVaiTro(ngClick.VaiTro, ngVaiTro)

        lbVaiTro.Text = ngVaiTro.TenVaiTro

        If ngClick.GioiTinh = False Then
            lbGioiTinh.Text = "Nam"
        Else
            lbGioiTinh.Text = "Nữ"
        End If
    End Sub

    Private Sub dgDanhSach_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgDanhSach.RowHeaderMouseClick
        Me.Height = 700

        Dim ngClick = timkiem.ElementAt(e.RowIndex)
        lbMaNguoiDung.Text = ngClick.MaNguoiDung
        lbHoTen.Text = ngClick.HoTen
        lbNgaySinh.Text = ngClick.NgaySinh.ToString("dd/MM/yyyy")
        lbCMND.Text = ngClick.CMND
        lbDiaChi.Text = ngClick.DiaChi
        lbEmail.Text = ngClick.Email
        lbSoDienThoai.Text = ngClick.SoDienThoai
        lbNgayTao.Text = ngClick.NgayTao.ToString("dd/MM/yyyy")

        Dim ngVaiTro As New VaiTroDTO
        vaitroBus.getByMaVaiTro(ngClick.VaiTro, ngVaiTro)

        lbVaiTro.Text = ngVaiTro.TenVaiTro

        If ngClick.GioiTinh = False Then
            lbGioiTinh.Text = "Nam"
        Else
            lbGioiTinh.Text = "Nữ"
        End If
    End Sub
End Class
