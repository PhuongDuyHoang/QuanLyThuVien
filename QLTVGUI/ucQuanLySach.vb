Imports QLTVBus
Imports QLTVDTO

Public Class ucQuanLySach
    Public dangnhap As DangNhapDTO

    Private Sub btnThemNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnThemNhaCungCap.Click
        Me.Controls.Clear()
        Dim nhacungcap As New ucNhaCungCap
        Me.Controls.Add(nhacungcap)
        nhacungcap.BringToFront()
    End Sub

    Private Sub btnThemNhaThanhLy_Click(sender As Object, e As EventArgs) Handles btnThemNhaThanhLy.Click
        Me.Controls.Clear()
        Dim nhathanhly As New ucNhaThanhLy
        Me.Controls.Add(nhathanhly)
        nhathanhly.BringToFront()
    End Sub

    Private Sub btnNhapSach_Click(sender As Object, e As EventArgs) Handles btnNhapSach.Click
        Me.Controls.Clear()
        Dim phieunhap As New ucPhieuNhap With {
            .dangnhap = dangnhap
        }
        Me.Controls.Add(phieunhap)
        phieunhap.BringToFront()
    End Sub

    Private Sub btnXuatSach_Click(sender As Object, e As EventArgs) Handles btnXuatSach.Click

    End Sub

    Private Sub btnMuonSach_Click(sender As Object, e As EventArgs) Handles btnMuonSach.Click
        Me.Controls.Clear()
        Dim phieumuon As New ucChoMuonSach With {
            .dangnhap = dangnhap
        }
        Me.Controls.Add(phieumuon)
        phieumuon.BringToFront()
    End Sub

    Private Sub btnTraSach_Click(sender As Object, e As EventArgs) Handles btnTraSach.Click

    End Sub

    Private Sub btnThemNhaXuatBan_Click(sender As Object, e As EventArgs) Handles btnThemNhaXuatBan.Click
        Me.Controls.Clear()
        Dim nhaxuatban As New ucNhaXuatBan
        Me.Controls.Add(nhaxuatban)
        nhaxuatban.BringToFront()
    End Sub

    Private Sub btnThemTheLoai_Click(sender As Object, e As EventArgs) Handles btnThemTheLoai.Click
        Me.Controls.Clear()
        Dim theloaisach As New ucTheLoaiSach
        Me.Controls.Add(theloaisach)
        theloaisach.BringToFront()
    End Sub

    Private Sub btnThemTacGia_Click(sender As Object, e As EventArgs) Handles btnThemTacGia.Click
        Me.Controls.Clear()
        Dim tacgia As New ucTacGia
        Me.Controls.Add(tacgia)
        tacgia.BringToFront()
    End Sub

    Private Sub btnThemNgonNgu_Click(sender As Object, e As EventArgs) Handles btnThemNgonNgu.Click
        Me.Controls.Clear()
        Dim ngonngu As New ucNgonNgu
        Me.Controls.Add(ngonngu)
        ngonngu.BringToFront()
    End Sub

    Private Sub btnTinhTrangSach_Click(sender As Object, e As EventArgs) Handles btnTinhTrangSach.Click
        Me.Controls.Clear()
        Dim tinhtrang As New ucTinhTrang
        Me.Controls.Add(tinhtrang)
        tinhtrang.BringToFront()
    End Sub
End Class
