Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuNhapBUS
    Private ctmnDAL As ChiTietPhieuNhapDAL

    Public Sub New()
        ctmnDAL = New ChiTietPhieuNhapDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctmnDAL = New ChiTietPhieuNhapDAL(connectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of ChiTietPhieuNhapDTO)) As Result
        Return ctmnDAL.selectALL(list)
    End Function

    Public Function getAllByMaPhieuNhap(maphieunhap As String, ByRef list As List(Of ChiTietPhieuNhapDTO)) As Result
        Return ctmnDAL.getAllByMaPhieuNhap(maphieunhap, list)
    End Function

    Public Function insert(ctpm As ChiTietPhieuNhapDTO) As Result
        Return ctmnDAL.insert(ctpm)
    End Function
End Class
