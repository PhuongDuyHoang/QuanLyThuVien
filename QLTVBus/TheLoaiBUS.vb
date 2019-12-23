Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TheLoaiBUS
    Private tlDAL As TheLoaiDAL

    Public Sub New()
        tlDAL = New TheLoaiDAL()
    End Sub

    Public Sub New(connectionString As String)
        tlDAL = New TheLoaiDAL(connectionString)
    End Sub

    Public Function buildMaTheLoai(ByRef nextMaTheLoai As String) As Result
        Return tlDAL.buildMaTheLoai(nextMaTheLoai)
    End Function

    Public Function selectAll(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return tlDAL.selectALL(listTheLoai)
    End Function

    Public Function update(value As TheLoaiDTO) As Result
        Return tlDAL.update(value)
    End Function

    Public Function insert(theloai As TheLoaiDTO) As Result
        Return tlDAL.insert(theloai)
    End Function

    Public Function getByMaTheLoai(matheloai As String, ByRef value As TheLoaiDTO) As Result
        Return tlDAL.getByMaTheLoai(matheloai, value)
    End Function
End Class
