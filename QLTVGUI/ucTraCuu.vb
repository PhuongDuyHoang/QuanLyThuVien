Public Class ucTraCuu
    Private Sub btnThemNguoiDung_Click(sender As Object, e As EventArgs) Handles btnThemNguoiDung.Click
        Me.Controls.Clear()
        Dim ucTraCuuSach As New ucTraCuuSach
        Me.Controls.Add(ucTraCuuSach)
        ucTraCuuSach.BringToFront()
    End Sub

    Private Sub btnTimKiemNguoiDung_Click(sender As Object, e As EventArgs) Handles btnTimKiemNguoiDung.Click
        Me.Controls.Clear()
        Dim ucTraCuuNguoiDung As New ucTraCuuNguoiDung
        Me.Controls.Add(ucTraCuuNguoiDung)
        ucTraCuuNguoiDung.BringToFront()
    End Sub
End Class
