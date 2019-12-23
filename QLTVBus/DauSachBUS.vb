Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DauSachBUS
    Private s As DauSachDAL
    Public Sub New()
        s = New DauSachDAL()
    End Sub
    Public Sub New(connectionString As String)
        s = New DauSachDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of DauSachDTO)) As Result
        Return s.selectALL(list)
    End Function

    Public Function getByMaDauSach(madausach As String, ByRef value As DauSachDTO) As Result
        Return s.getByMaDauSach(madausach, value)
    End Function

    Public Function buildMaDauSach(ByRef value As String) As Result
        Return s.buildMaDauSach(value)
    End Function

    Public Function update(value As DauSachDTO) As Result
        Return s.update(value)
    End Function

    Public Function insert(value As DauSachDTO) As Result
        Return s.insert(value)
    End Function

    Public Function filter_MaSach(madausach As String, ByRef listSach As List(Of String)) As Result
        Return s.filter_MaSach(madausach, listSach)
    End Function

    Public Function filter_TenSach(tendausach As String, ByRef listSach As List(Of String)) As Result
        Return s.filter_TenSach(tendausach, listSach)
    End Function

    Public Function selectAll_MaDauSach(madausach As String, ByRef listDauSach As List(Of String)) As Result
        Return s.selectAll_MaDauSach(madausach, listDauSach)
    End Function
End Class

