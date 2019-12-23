Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class NgonNguBUS
    Private nn As NgonNguDAL
    Public Sub New()
        nn = New NgonNguDAL()
    End Sub
    Public Sub New(connectionString As String)
        nn = New NgonNguDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of NgonNguDTO)) As Result
        Return nn.selectALL(list)
    End Function

    Public Function selectALL_ByMaNgonNgu(mangonngu As String, ByRef list As List(Of NgonNguDTO)) As Result
        Return nn.selectALL_ByMaNgonNgu(mangonngu, list)
    End Function

    Public Function buildMaNgonNgu(ByRef value As String) As Result
        Return nn.buildMaNgonNgu(value)
    End Function

    Public Function insert(value As NgonNguDTO) As Result
        Return nn.insert(value)
    End Function

    Public Function update(value As NgonNguDTO) As Result
        Return nn.update(value)
    End Function
End Class

