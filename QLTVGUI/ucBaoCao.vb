Public Class ucBaoCao
    Private Sub btnThongKeTheLoai_Click(sender As Object, e As EventArgs) Handles btnThongKeTheLoai.Click
        Me.Controls.Clear()
        Dim ucBaoCaoSachMuon As New ucBaoCaoSachMuon
        Me.Controls.Add(ucBaoCaoSachMuon)
        ucBaoCaoSachMuon.BringToFront()
    End Sub

    Private Sub btnThongKeTraTre_Click(sender As Object, e As EventArgs) Handles btnThongKeTraTre.Click
        Me.Controls.Clear()
        Dim ucBaoCaoSachTre As New ucBaoCaoSachTre
        Me.Controls.Add(ucBaoCaoSachTre)
        ucBaoCaoSachTre.BringToFront()
    End Sub
End Class
