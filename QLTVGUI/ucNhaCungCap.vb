Imports QLTVBus
Imports QLTVDTO

Public Class ucNhaCungCap
    Dim nhacungcapBus As New NhaCungCapBUS
    Dim listNhaCungCap As New List(Of NhaCungCapDTO)

    Private Sub ucNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        ClearFields()
        LoadDataGrid()
        nhacungcapBus.buildMaNhaCungCap(lbMaNhaCungCap.Text)
    End Sub


    Private Sub LoadDataGrid()
        listNhaCungCap.Clear()
        dgDanhSach.Rows.Clear()
        nhacungcapBus.selectALL(listNhaCungCap)

        For i As Integer = 0 To listNhaCungCap.Count - 1
            Dim ncc = listNhaCungCap.ElementAt(i)

            Dim s As String()
            s = New String() {ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.DiaChi, ncc.SoDienThoai, ncc.SoFax}
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
        Dim parent As ucNhaCungCap
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
       
    End Sub
End Class
