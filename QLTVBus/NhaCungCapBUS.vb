Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class NhaCungCapBUS
    Private ncc As NhaCungCapDAL
    Public Sub New()
        ncc = New NhaCungCapDAL()
    End Sub
    Public Sub New(connectionString As String)
        ncc = New NhaCungCapDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of NhaCungCapDTO)) As Result
        Return ncc.selectAll(list)
    End Function

    Public Function buildMaNhaCungCap(ByRef value As String) As Result
        Return ncc.buildMaNhaCungCap(value)
    End Function

    Public Function insert(value As NhaCungCapDTO) As Result
        Return ncc.insert(value)
    End Function
End Class


