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
       
    End Sub

    Private Sub btnAddNgonNgu_Click(sender As Object, e As EventArgs) Handles btnAddNgonNgu.Click
        
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
        
    End Sub
End Class
