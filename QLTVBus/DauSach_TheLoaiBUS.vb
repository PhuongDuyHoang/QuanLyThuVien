Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DauSach_TheLoaiBus
    Private dstl As DauSach_TheLoaiDAL
    Public Sub New()
        dstl = New DauSach_TheLoaiDAL()
    End Sub
    Public Sub New(connectionString As String)
        dstl = New DauSach_TheLoaiDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSach_TheLoaiDTO)) As Result
        Return dstl.selectALL(list)
    End Function

    Public Function selectALL_ByMaTheLoai(matheloai As String, ByRef list As List(Of DauSach_TheLoaiDTO)) As Result
        Return dstl.selectALL_ByMaTheLoai(matheloai, list)
    End Function

    Public Function selectALL_ByMaDauSach(madausach As String, ByRef list As List(Of DauSach_TheLoaiDTO)) As Result
        Return dstl.selectALL_ByMaDauSach(madausach, list)
    End Function

    Public Function insert(value As DauSach_TheLoaiDTO) As Result
        Return dstl.insert(value)
    End Function

    Public Function getListTheLoaiAsString_ByMaDauSach(madausach As String, ByRef value As String) As Result
        Return dstl.getListTheLoaiAsString_ByMaDauSach(madausach, value)
    End Function

End Class

