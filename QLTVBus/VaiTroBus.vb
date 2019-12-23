Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class VaiTroBUS
    Private vt As VaiTroDAL
    Public Sub New()
        vt = New VaiTroDAL()
    End Sub

    Public Sub New(connectionString As String)
        vt = New VaiTroDAL(connectionString)
    End Sub

    Public Function buildMaVaiTro(ByRef value As String) As Result
        Return vt.buildMaVaiTro(value)
    End Function

    Public Function selectAll(ByRef listTT As List(Of VaiTroDTO)) As Result
        Return vt.selectALL(listTT)
    End Function

    Public Function getByMaVaiTro(mavaitro As String, ByRef value As VaiTroDTO) As Result
        Return vt.getByMaVaiTro(mavaitro, value)
    End Function

    Public Function insert(value As VaiTroDTO) As Result
        Return vt.insert(value)
    End Function

    Public Function update(value As VaiTroDTO) As Result
        Return vt.update(value)
    End Function
End Class
