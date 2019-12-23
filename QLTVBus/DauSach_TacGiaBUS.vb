Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DauSach_TacGiaBus
    Private dstg As DauSach_TacGiaDAL
    Public Sub New()
        dstg = New DauSach_TacGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dstg = New DauSach_TacGiaDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSach_TacGiaDTO)) As Result
        Return dstg.selectALL(list)
    End Function

    Public Function selectALL_ByMaTacGia(matacgia As String, ByRef list As List(Of DauSach_TacGiaDTO)) As Result
        Return dstg.selectALL_ByMaTacGia(matacgia, list)
    End Function

    Public Function selectALL_ByMaDauSach(madausach As String, ByRef list As List(Of DauSach_TacGiaDTO)) As Result
        Return dstg.selectALL_ByMaDauSach(madausach, list)
    End Function

    Public Function getListTacGiaAsString_ByMaDauSach(madausach As String, ByRef value As String) As Result
        Return dstg.getListTacGiaAsString_ByMaDauSach(madausach, value)
    End Function

    Public Function insert(value As DauSach_TacGiaDTO) As Result
        Return dstg.insert(value)
    End Function

End Class
