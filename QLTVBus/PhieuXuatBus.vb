Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuXuatBUS
    Private px As PhieuXuatDAL
    Public Sub New()
        px = New PhieuXuatDAL()
    End Sub
    Public Sub New(connectionString As String)
        px = New PhieuXuatDAL(connectionString)
    End Sub

    Public Function build_maphieuxuat(ByRef nextMaPhieuXuat As String) As Result
        Return px.build_maphieuxuat(nextMaPhieuXuat)
    End Function

    Public Function insert(value As PhieuXuatDTO) As Result
        Return px.insert(value)
    End Function

    Public Function selectALL(ByRef listPhieuXuat As List(Of PhieuXuatDTO)) As Result
        Return px.selectALL(listPhieuXuat)
    End Function
End Class
