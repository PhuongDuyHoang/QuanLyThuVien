Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class TinhTrangBUS
    Private ttDAL As TinhTrangDAL
    Public Sub New()
        ttDAL = New TinhTrangDAL()
    End Sub

    Public Sub New(connectionString As String)
        ttDAL = New TinhTrangDAL(connectionString)
    End Sub

    Public Function buildMaTinhTrang(ByRef value As String) As Result
        Return ttDAL.buildMaTinhTrang(value)
    End Function

    Public Function selectAll(ByRef listTT As List(Of TinhTrangDTO)) As Result
        Return ttDAL.selectAll(listTT)
    End Function

    Public Function insert(value As TinhTrangDTO) As Result
        Return ttDAL.insert(value)
    End Function

    Public Function update(value As TinhTrangDTO) As Result
        Return ttDAL.update(value)
    End Function
End Class
