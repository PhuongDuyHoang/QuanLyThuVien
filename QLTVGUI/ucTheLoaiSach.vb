Imports QLTVBus
Imports QLTVDTO

Public Class ucTheLoaiSach
    Dim theloaisachBus As New TheLoaiBUS
    Dim listTheLoai As New List(Of TheLoaiDTO)

    Private Sub ucTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        ClearFields()
        LoadDataGrid()
        theloaisachBus.buildMaTheLoai(lbMaTheLoai.Text)
    End Sub


    Private Sub LoadDataGrid()
        listTheLoai.Clear()
        dgDanhSach.Rows.Clear()
        theloaisachBus.selectAll(listTheLoai)

        For i As Integer = 0 To listTheLoai.Count - 1
            Dim ncc = listTheLoai.ElementAt(i)

            Dim s As String()
            s = New String() {ncc.MaTheLoai, ncc.TenTheLoai}
            dgDanhSach.Rows.Add(s)
        Next
    End Sub

    Private Sub ClearFields()
        tbTen.Text = ""
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Dim parent As ucTheLoaiSach
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

   
    Private Sub dgDanhSach_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgDanhSach.CellEndEdit
        Dim newValue = dgDanhSach.Item(1, e.RowIndex).Value

        If newValue = "" Then
            dgDanhSach.Item(1, e.RowIndex).Value = listTheLoai.ElementAt(e.RowIndex).TenTheLoai
            Return
        End If

        listTheLoai.ElementAt(e.RowIndex).TenTheLoai = newValue
        theloaisachBus.update(listTheLoai.ElementAt(e.RowIndex))
    End Sub
End Class
