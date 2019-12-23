Imports QLTVBus
Imports QLTVDTO

Public Class ucTinhTrang
    Dim tinhtrangBus As New TinhTrangBUS
    Dim listTinhTrang As New List(Of TinhTrangDTO)

    Private Sub ucTinhTrang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        ClearFields()
        LoadDataGrid()
        tinhtrangBus.buildMaTinhTrang(lbMaTinhTrang.Text)
    End Sub


    Private Sub LoadDataGrid()
        listTinhTrang.Clear()
        dgDanhSach.Rows.Clear()
        tinhtrangBus.selectAll(listTinhTrang)

        For i As Integer = 0 To listTinhTrang.Count - 1
            Dim ncc = listTinhTrang.ElementAt(i)

            Dim s As String()
            s = New String() {ncc.MaTinhTrang, ncc.TenTinhTrang}
            dgDanhSach.Rows.Add(s)
        Next
    End Sub

    Private Sub ClearFields()
        tbTen.Text = ""
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Dim parent As ucTinhTrang
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
        If tbTen.Text = "" Then
            MessageBox.Show("Nhập tên tình trạng!", "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        Dim tinhtrang As New TinhTrangDTO
        tinhtrang.MaTinhTrang = lbMaTinhTrang.Text
        tinhtrang.TenTinhTrang = tbTen.Text

        Dim res = tinhtrangBus.insert(tinhtrang)
        If res.FlagResult = False Then
            Dim mes = "Thêm tình trạng lỗi!" + "\n" + res.SystemMessage
            MessageBox.Show(mes, "Lỗi", MessageBoxButtons.OK)
            Return
        End If

        MessageBox.Show("Thêm tình trạng thành công!", "Thông báo", MessageBoxButtons.OK)
        Reset()
    End Sub

    Private Sub dgDanhSach_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgDanhSach.CellEndEdit
        Dim newValue = dgDanhSach.Item(1, e.RowIndex).Value

        If newValue = "" Then
            dgDanhSach.Item(1, e.RowIndex).Value = listTinhTrang.ElementAt(e.RowIndex).TenTinhTrang
            Return
        End If

        listTinhTrang.ElementAt(e.RowIndex).TenTinhTrang = newValue
        tinhtrangBus.update(listTinhTrang.ElementAt(e.RowIndex))
    End Sub
End Class
