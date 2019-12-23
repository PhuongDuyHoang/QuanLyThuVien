Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuNhapBUS
    Private pn As PhieuNhapDAL
    Public Sub New()
        pn = New PhieuNhapDAL()
    End Sub
    Public Sub New(connectionString As String)
        pn = New PhieuNhapDAL(connectionString)
    End Sub

    Public Function build_maphieunhap(ByRef nextMaPhieuNhap As String) As Result
        Return pn.build_maphieunhap(nextMaPhieuNhap)
    End Function

    Public Function insert(value As PhieuNhapDTO) As Result
        Return pn.insert(value)
    End Function

    Public Function selectALL(ByRef listPhieuNhap As List(Of PhieuNhapDTO)) As Result
        Return pn.selectALL(listPhieuNhap)
    End Function

    Public Function getByMaPhieuNhap(maphieunhap As String, ByRef value As PhieuNhapDTO) As Result
        Return pn.getByMaPhieuNhap(maphieunhap, value)
    End Function

    Public Function update(value As PhieuNhapDTO) As Result
        Return pn.update(value)
    End Function
End Class
