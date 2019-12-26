Imports QLTVBus
Imports QLTVDTO

Public Class ucPhieuNhap
    Public dangnhap As DangNhapDTO
    Public maphieunhap As String
    Public nhacungcap As String
    Dim tongtien As Integer

    Dim phieunhapBus As New PhieuNhapBUS
    Dim nhacungcapBus As New NhaCungCapBUS
    Dim chitietphieunhapBus As New ChiTietPhieuNhapBUS
    Dim dausachBus As New DauSachBUS

    Dim listNhaCungCap As New List(Of NhaCungCapDTO)
    Dim listChiTietPhieuNhap As New List(Of ChiTietPhieuNhapDTO)

    Private Sub ucPhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieunhapBus.build_maphieunhap(lbMaPhieuNhap.Text)
        lbNgayNhap.Text = Today.ToString("dd/MM/yyyy")
        lbNguoiNhap.Text = dangnhap.NguoiDung

        nhacungcapBus.selectALL(listNhaCungCap)
        cbNhaCungCap.DataSource = New BindingSource(listNhaCungCap, String.Empty)
        cbNhaCungCap.DisplayMember = "tennhacungcap"
        cbNhaCungCap.ValueMember = "manhacungcap"

        If (maphieunhap <> Nothing) Then
            lbMaPhieuNhap.Text = maphieunhap
            cbNhaCungCap.SelectedValue = nhacungcap
            cbNhaCungCap.Enabled = False
            LoadData()
        End If
    End Sub

    Private Sub LoadData()
        If maphieunhap Is Nothing Then
            Return
        End If

        chitietphieunhapBus.getAllByMaPhieuNhap(maphieunhap, listChiTietPhieuNhap)
        tongtien = 0

        For i As Integer = 0 To listChiTietPhieuNhap.Count - 1
            Dim value = listChiTietPhieuNhap.ElementAt(i)

            Dim dausach As New DauSachDTO
            dausachBus.getByMaDauSach(value.MaDauSach, dausach)

            Dim s As String()
            s = New String() {value.MaDauSach, dausach.TenDauSach, dausach.TriGia.ToString("###,###,###"), value.SoLuong, value.ThanhTien.ToString("###,###,###"), value.GhiChu}
            dgDanhSach.Rows.Add(s)

            tongtien = tongtien + value.ThanhTien
        Next

        lbTongTien.Text = tongtien.ToString("###,###,###")
    End Sub

    Private Sub Back(sender As Object)
        Dim parent As ucPhieuNhap
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

    Private Sub btnThemDauSach_Click(sender As Object, e As EventArgs) Handles btnThemDauSach.Click
        
    End Sub
End Class
