Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuTraBus
    Private pt As PhieuTraDAL
    Public Sub New()
        pt = New PhieuTraDAL()
    End Sub
    Public Sub New(connectionString As String)
        pt = New PhieuTraDAL(connectionString)
    End Sub

    Public Function build_maphieutra(ByRef nextMaPhieuTra As String) As Result
        Return pt.build_maphieutra(nextMaPhieuTra)
    End Function

    Public Function insert(value As PhieuTraDTO) As Result
        Return pt.insert(value)
    End Function

    Public Function selectALL(ByRef listPhieuTra As List(Of PhieuTraDTO)) As Result
        Return pt.selectALL(listPhieuTra)
    End Function
End Class
