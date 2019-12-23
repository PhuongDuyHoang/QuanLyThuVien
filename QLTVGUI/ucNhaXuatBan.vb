Imports QLTVBus
Imports QLTVDTO

Public Class ucNhaXuatBan
    Dim nhaxuatbanBus As New NhaXuatBanBUS
    Dim listNhaXuatBan As New List(Of NhaXuatBanDTO)

    Private Sub ucNhaXuatBan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        ClearFields()
        LoadDataGrid()
        nhaxuatbanBus.buildMaNhaXuatBan(lbMaNhaXuatBan.Text)
    End Sub


    Private Sub LoadDataGrid()
        listNhaXuatBan.Clear()
        dgDanhSach.Rows.Clear()
        nhaxuatbanBus.selectAll(listNhaXuatBan)

        For i As Integer = 0 To listNhaXuatBan.Count - 1
            Dim ncc = listNhaXuatBan.ElementAt(i)

            Dim s As String()
            s = New String() {ncc.MaNhaXuatBan, ncc.TenNhaXuatBan, ncc.DiaChi, ncc.SoDienThoai, ncc.SoFax}
            dgDanhSach.Rows.Add(s)
        Next
    End Sub

    Private Sub ClearFields()
        tbTen.Text = ""
        tbDiaChi.Text = ""
        tbSoDienThoai.Text = ""
        tbSoFax.Text = ""
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Dim parent As ucNhaXuatBan
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

    Private Sub lbTroVe_MouseHover(sender As Object, e As EventArgs) Handles lbTroVe.MouseHover
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(60, Byte), Integer))
    End Sub

    Private Sub lbTroVe_MouseLeave(sender As Object, e As EventArgs) Handles lbTroVe.MouseLeave
        lbTroVe.ForeColor = Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If tbTen.Text = "" Or tbDiaChi.Text = "" Or tbSoDienThoai.Text = "" Then
            MessageBox.Show("Nhập đầy đủ các trường bắt buộc!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        Dim nhaxuatban As New NhaXuatBanDTO
        nhaxuatban.MaNhaXuatBan = lbMaNhaXuatBan.Text
        nhaxuatban.TenNhaXuatBan = tbTen.Text
        nhaxuatban.DiaChi = tbDiaChi.Text
        nhaxuatban.SoDienThoai = tbSoDienThoai.Text
        nhaxuatban.SoFax = tbSoFax.Text

        Dim res = nhaxuatbanBus.insert(nhaxuatban)
        If res.FlagResult = False Then
            Dim mes = "Thêm nhà thanh lý lỗi!" + "\n" + res.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        MessageBox.Show("Thêm nhà thanh lý thành công!", "Thông báo", MessageBoxButtons.OK)
        Reset()
    End Sub
End Class
