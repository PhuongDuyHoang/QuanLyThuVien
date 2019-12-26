Imports QLTVBus
Imports QLTVDTO

Public Class ucTacGia
    Dim tacgiaBus As New TacGiaBUS
    Dim listTacGia As New List(Of TacGiaDTO)

    Private Sub ucTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        ClearFields()
        LoadDataGrid()
        tacgiaBus.buildMaTacGia(lbMaTacGia.Text)
    End Sub


    Private Sub LoadDataGrid()
        listTacGia.Clear()
        dgDanhSach.Rows.Clear()
        tacgiaBus.selectAll(listTacGia)

        For i As Integer = 0 To listTacGia.Count - 1
            Dim ncc = listTacGia.ElementAt(i)

            Dim s As String()
            s = New String() {ncc.MaTacGia, ncc.TenTacGia}
            dgDanhSach.Rows.Add(s)
        Next
    End Sub

    Private Sub ClearFields()
        tbTen.Text = ""
    End Sub

    Private Sub lbTroVe_Click(sender As Object, e As EventArgs) Handles lbTroVe.Click
        Dim parent As ucTacGia
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

    Private Sub dgDanhSach_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgDanhSach.CellEndEdit
        Dim newValue = dgDanhSach.Item(1, e.RowIndex).Value

        If newValue = "" Then
            dgDanhSach.Item(1, e.RowIndex).Value = listTacGia.ElementAt(e.RowIndex).TenTacGia
            Return
        End If

        listTacGia.ElementAt(e.RowIndex).TenTacGia = newValue
        tacgiaBus.update(listTacGia.ElementAt(e.RowIndex))
    End Sub
End Class
