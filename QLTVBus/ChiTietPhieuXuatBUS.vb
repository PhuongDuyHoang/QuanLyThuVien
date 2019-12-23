Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuXuatBUS
    Private ctpxDAL As ChiTietPhieuXuatDAL

    Public Sub New()
        ctpxDAL = New ChiTietPhieuXuatDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctpxDAL = New ChiTietPhieuXuatDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of ChiTietPhieuXuatDTO)) As Result
        Return ctpxDAL.selectALL(list)
    End Function

    Public Function insert(ctpm As ChiTietPhieuXuatDTO) As Result
        Return ctpxDAL.insert(ctpm)
    End Function
End Class
