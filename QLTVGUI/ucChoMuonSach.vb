Imports QLTVDTO
Imports QLTVBus
Imports Utility
Imports System.Drawing
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ucChoMuonSach
    Public dangnhap As New DangNhapDTO

    Dim thamso As New ThamSoDTO
    Dim thamsoBus As New ThamSoBUS
    Dim docgia As New NguoiDungDTO
    Dim nguoidungBus As New NguoiDungBUS
    Dim phieumuon As New PhieuMuonDTO
    Dim phieumuonBus As New PhieuMuonBUS
    Dim chitietphieumuon As New ChiTietPhieuMuonDTO
    Dim chitietphieumuonBus As New ChiTietPhieuMuonBUS
    Dim cuonsach As New CuonSachDTO
    Dim cuonsachBus As New CuonSachBUS
    Dim dausach As New DauSachDTO
    Dim dausachBus As New DauSachBUS
    Dim dstgBus As New DauSach_TacGiaBus
    Dim dstlBus As New DauSach_TheLoaiBus

    Dim listMaSachDangMuon As New List(Of String)
    Dim listTenSachDangMuon As New List(Of String)
    Dim listNgayMuon As New List(Of Date)

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieumuonBus.build_maphieumuon(lbMaPhieuMuon.Text)
        lbNgayMuon.Text = Today.ToString("dd/MM/yyyy")
        lbThuThu.Text = dangnhap.NguoiDung

        thamsoBus.selectALL(thamso)

        lbHoTenDocGia.Text = ""
        lbThongBao.Text = ""
        lbTong.Text = "0"
        Me.Height = 366
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucChoMuonSach
        parent = sender.Parent
        Dim parent2 As ucQuanLySach
        parent2 = parent.Parent
        Dim parent3 = New FlowLayoutPanel
        parent3 = parent2.Parent
        Dim parent4 = New frmHome
        parent4 = parent3.Parent
        Dim quanlysach As New ucQuanLySach With {
            .dangnhap = parent4.dangnhap
        }
        parent3.Controls.Clear()
        parent3.Controls.Add(quanlysach)
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Back(sender)
    End Sub

    Private Sub lbTroVe_MouseHover(sender As Object, e As EventArgs) Handles lbTroVe.MouseHover
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
    End Sub

    Private Sub lbTroVe_MouseLeave(sender As Object, e As EventArgs) Handles lbTroVe.MouseLeave
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    

    Private Sub KiemTraDieuKienMuonSach()
        If listMaSachDangMuon.Count = thamso.SoSachMuonToiDa Then
            lbThongBao.Text = "Đã đạt giới hạn được mượn sách!"
            Return
        End If

        Dim strSachTraTre As String
        strSachTraTre = Nothing
        For i As Integer = 0 To listMaSachDangMuon.Count - 1
            If (Today - listNgayMuon.ElementAt(i)).TotalDays > thamso.HanMuonSach Then
                strSachTraTre = strSachTraTre + listMaSachDangMuon.ElementAt(i) + " "
            End If
        Next

        If strSachTraTre <> Nothing Then
            lbThongBao.Text = "Sách trả trễ hạn: " + strSachTraTre
            Return
        End If

        ' OK
        Me.Height = 683
    End Sub

    Private Sub ThemSachMuon()
        If tbThemMaSach.Text.Length <> 8 Then
            Return
        End If

        If dgDSCanMuon.Rows.Count + listMaSachDangMuon.Count = thamso.SoSachMuonToiDa Then
            MessageBox.Show("Vượt quá giới hạn mượn sách tối đa!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        If dgDSCanMuon.Rows.Count = thamso.SoSachMuonToiDa1Lan Then
            MessageBox.Show("Vượt quá giới hạn mượn sách 1 lần!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        'Kiem tra trung
        For i As Integer = 0 To dgDSCanMuon.Rows.Count - 1
            If tbThemMaSach.Text = dgDSCanMuon.Item(0, i).Value Then
                MessageBox.Show("Sách đã được thêm vào bảng!", "Lỗi", MessageBoxButtons.OK)
                Return
            End If
        Next

        cuonsach = New CuonSachDTO
        cuonsachBus.getByMaCuonSach(tbThemMaSach.Text, cuonsach)

        If cuonsach.MaCuonSach Is Nothing Then
            MessageBox.Show("Lấy thông tin cuốn sách không thành công!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        'hien thi
        dausachBus.getByMaDauSach(cuonsach.DauSach, dausach)

        Dim nhaxuatban As New NhaXuatBanDTO
        Dim nhaxuatbanBus As New NhaXuatBanBUS
        nhaxuatbanBus.getByMaNhaXuatBan(dausach.NhaXuatBan, nhaxuatban)

        Dim strTacGia As String
        strTacGia = Nothing
        dstgBus.getListTacGiaAsString_ByMaDauSach(dausach.MaDauSach, strTacGia)
        strTacGia.Substring(0, strTacGia.Length - 2)

        Dim strTheLoai As String
        strTheLoai = Nothing
        dstlBus.getListTheLoaiAsString_ByMaDauSach(dausach.MaDauSach, strTheLoai)
        strTheLoai.Substring(0, strTheLoai.Length - 2)

        Dim s As String()
        s = New String() {cuonsach.MaCuonSach, dausach.TenDauSach, nhaxuatban.TenNhaXuatBan, strTacGia, strTheLoai, dausach.TriGia.ToString("###,###,###")}
        dgDSCanMuon.Rows.Add(s)
    End Sub

    Private Sub btAddTheLoai_Click(sender As Object, e As EventArgs) Handles btAddTheLoai.Click
        ThemSachMuon()
    End Sub

    Private Sub tbThemMaSach_KeyDown(sender As Object, e As KeyEventArgs) Handles tbThemMaSach.KeyDown
        If e.KeyCode = Keys.Enter Then
            ThemSachMuon()
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If dgDSCanMuon.Rows.Count = 0 Then
            MessageBox.Show("Danh sách sách cần mượn trống!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        LuuPhieuMuon()
        Back(sender)
    End Sub

    Private Sub btnLuuVaxuat_Click(sender As Object, e As EventArgs) Handles btnLuuVaxuat.Click
        If dgDSCanMuon.Rows.Count = 0 Then
            MessageBox.Show("Danh sách sách cần mượn trống!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        LuuPhieuMuon()
        XuatPhieuMuon()
        Back(sender)
    End Sub
    Private Sub tbMaDocGia_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMaDocGia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim result = nguoidungBus.getByMaNguoiDung(tbMaDocGia.Text, docgia)
            If result.FlagResult = False Then
                MessageBox.Show("Lấy thông tin độc giả không thành công!", "Lỗi", MessageBoxButtons.OK)
                Return
            End If

            lbHoTenDocGia.Text = docgia.HoTen
            LayThongTinMuonSach()
            KiemTraDieuKienMuonSach()
        End If
    End Sub

    Private Sub LayThongTinMuonSach()
        If docgia.MaNguoiDung Is Nothing Then
            Return
        End If

        phieumuonBus.getAll_SachDangMuon_ByMaDocGia(docgia.MaNguoiDung, listMaSachDangMuon, listTenSachDangMuon, listNgayMuon)
        lbTong.Text = listMaSachDangMuon.Count.ToString

        For i As Integer = 0 To listMaSachDangMuon.Count - 1
            Dim s As String()
            s = New String() {listMaSachDangMuon.ElementAt(i), listTenSachDangMuon.ElementAt(i), listNgayMuon(i).ToString("dd/MM/yyyy")}
            dgDanhSach.Rows.Add(s)
        Next

    End Sub

    Private Sub LuuPhieuMuon()
        'Luu phieu muon
        phieumuon.MaPhieuMuon = lbMaPhieuMuon.Text
        phieumuon.NgayMuon = Today
        phieumuon.ThuThu = dangnhap.NguoiDung
        phieumuon.DocGia = docgia.MaNguoiDung

        Dim result = phieumuonBus.insert(phieumuon)
        If result.FlagResult = False Then
            MessageBox.Show("Thêm phiếu mượn thất bại!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        'Luu chi tiet phieu muon
        For i As Integer = 0 To dgDSCanMuon.Rows.Count - 1
            chitietphieumuon.MaPhieuMuon = lbMaPhieuMuon.Text
            chitietphieumuon.MaCuonSach = dgDSCanMuon.Item(0, i).Value

            result = chitietphieumuonBus.insert(chitietphieumuon)
            If result.FlagResult = False Then
                MessageBox.Show("Thêm chi tiết phiếu mượn thất bại: " + chitietphieumuon.MaCuonSach, "Lỗi", MessageBoxButtons.OK)
            Else
                'Cap nhat lai tinh trang
                cuonsachBus.updateTinhTrang(chitietphieumuon.MaCuonSach, "TT000004")
            End If
        Next

        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK)
    End Sub

    Private Sub XuatPhieuMuon()

    End Sub

    Private Sub lbXoaDanhSach_MouseHover(sender As Object, e As EventArgs) Handles lbXoaDanhSach.MouseHover
        lbXoaDanhSach.ForeColor = Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
    End Sub

    Private Sub lbXoaDanhSach_MouseLeave(sender As Object, e As EventArgs) Handles lbXoaDanhSach.MouseLeave
        lbXoaDanhSach.ForeColor = Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    Private Sub lbXoaDanhSach_Click(sender As Object, e As EventArgs) Handles lbXoaDanhSach.Click
        dgDSCanMuon.Rows.Clear()
    End Sub

    Private Sub tbThemMaSach_OnValueChanged(sender As Object, e As EventArgs) Handles tbThemMaSach.OnValueChanged

    End Sub
End Class
