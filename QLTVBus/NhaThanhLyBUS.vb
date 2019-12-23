Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class NhaThanhLyBUS
    Private ntl As NhaThanhLyDAL
    Public Sub New()
        ntl = New NhaThanhLyDAL()
    End Sub
    Public Sub New(connectionString As String)
        ntl = New NhaThanhLyDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of NhaThanhLyDTO)) As Result
        Return ntl.selectAll(list)
    End Function

    Public Function buildMaNhaThanhLy(ByRef value As String) As Result
        Return ntl.buildMaNhaThanhLy(value)
    End Function

    Public Function insert(value As NhaThanhLyDTO) As Result
        Return ntl.insert(value)
    End Function
End Class



