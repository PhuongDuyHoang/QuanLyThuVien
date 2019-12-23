Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DauSach_NgonNguBus
    Private dsnn As DauSach_NgonNguDAL
    Public Sub New()
        dsnn = New DauSach_NgonNguDAL()
    End Sub
    Public Sub New(connectionString As String)
        dsnn = New DauSach_NgonNguDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSach_NgonNguDTO)) As Result
        Return dsnn.selectALL(list)
    End Function

    Public Function selectALL_ByMaNgonNgu(mangonngu As String, ByRef list As List(Of DauSach_NgonNguDTO)) As Result
        Return dsnn.selectALL_ByMaNgonNgu(mangonngu, list)
    End Function

    Public Function selectALL_ByMaDauSach(madausach As String, ByRef list As List(Of DauSach_NgonNguDTO)) As Result
        Return dsnn.selectALL_ByMaDauSach(madausach, list)
    End Function

    Public Function insert(value As DauSach_NgonNguDTO) As Result
        Return dsnn.insert(value)
    End Function

End Class
