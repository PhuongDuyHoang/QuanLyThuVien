Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ThamSoBUS
    Private tsDAL As ThamSoDAL
    Public Sub New()
        tsDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        tsDAL = New ThamSoDAL(connectionString)
    End Sub

    Public Function update(qd As ThamSoDTO) As Result
        Return tsDAL.update(qd)
    End Function

    Public Function selectALL(ByRef thamso As ThamSoDTO) As Result
        Return tsDAL.selectALL(thamso)
    End Function
End Class
