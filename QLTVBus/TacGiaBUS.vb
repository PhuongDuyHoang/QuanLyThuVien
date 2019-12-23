Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TacGiaBUS
    Private tgDAL As TacGiaDAL

    Public Sub New()
        tgDAL = New TacGiaDAL()
    End Sub

    Public Sub New(connectionString As String)
        tgDAL = New TacGiaDAL(connectionString)
    End Sub

    Public Function buildMaTacGia(ByRef value As String) As Result
        Return tgDAL.buildMaTacGia(value)
    End Function

    Public Function selectAll(ByRef listtacgia As List(Of TacGiaDTO)) As Result
        Return tgDAL.selectALL(listtacgia)
    End Function

    Public Function insert(value As TacGiaDTO) As Result
        Return tgDAL.insert(value)
    End Function

    Public Function update(value As TacGiaDTO) As Result
        Return tgDAL.update(value)
    End Function

    Public Function getByMaTacGia(matacgia As String, ByRef value As TacGiaDTO) As Result
        Return tgDAL.getByMaTacGia(matacgia, value)
    End Function
End Class
