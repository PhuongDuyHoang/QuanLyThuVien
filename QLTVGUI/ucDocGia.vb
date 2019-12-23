Public Class ucDocGia
    Private Sub btnThemDocGia_Click(sender As Object, e As EventArgs) Handles btnThemDocGia.Click
        Me.Controls.Clear()
        Dim ucThemNguoiDung As New ucThemNguoiDung With {
            .isLapTheDocGia = True
        }
        Me.Controls.Add(ucThemNguoiDung)
        ucThemNguoiDung.BringToFront()
    End Sub

    Private Sub btnTimDocGia_Click(sender As Object, e As EventArgs) Handles btnTimDocGia.Click

    End Sub
End Class
