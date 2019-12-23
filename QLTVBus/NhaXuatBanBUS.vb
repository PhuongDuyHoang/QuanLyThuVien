Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class NhaXuatBanBUS
    Private nxbDAL As NhaXuatBanDAL

    Public Sub New()
        nxbDAL = New NhaXuatBanDAL()
    End Sub

    Public Sub New(connectionString As String)
        nxbDAL = New NhaXuatBanDAL(connectionString)
    End Sub

    Public Function selectAll(ByRef listNXB As List(Of NhaXuatBanDTO)) As Result
        Return nxbDAL.selectAll(listNXB)
    End Function

    Public Function buildMaNhaXuatBan(ByRef value As String) As Result
        Return nxbDAL.buildMaNhaXuatBan(value)
    End Function

    Public Function insert(value As NhaXuatBanDTO) As Result
        Return nxbDAL.insert(value)
    End Function

    Public Function getByMaNhaXuatBan(manhaxuatban As String, ByRef value As NhaXuatBanDTO) As Result
        Return nxbDAL.getByMaNhaXuatBan(manhaxuatban, value)
    End Function
End Class
