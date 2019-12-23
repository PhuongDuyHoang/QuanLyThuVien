Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuMuonBUS
    Private ctpmDAL As ChiTietPhieuMuonDAL

    Public Sub New()
        ctpmDAL = New ChiTietPhieuMuonDAL()
    End Sub
    Public Sub New(connectionString As String)
        ctpmDAL = New ChiTietPhieuMuonDAL(connectionString)
    End Sub

    Public Function build_mactpm(ByRef value As String) As Result
        Return ctpmDAL.build_mactpm(value)
    End Function

    Public Function selectALL(ByRef list As List(Of ChiTietPhieuMuonDTO)) As Result
        Return ctpmDAL.selectALL(list)
    End Function

    Public Function insert(ctpm As ChiTietPhieuMuonDTO) As Result
        Return ctpmDAL.insert(ctpm)
    End Function

    Public Function baocao_TheoTheLoai_ThangNam(month As Integer, year As Integer, ByRef list As List(Of TheLoaiDTO), ByRef listsoluotmuon As List(Of Integer))
        Return ctpmDAL.baocao_TheoTheLoai_ThangNam(month, year, list, listsoluotmuon)
    End Function

    Public Function baocao_TheoTheLoai_Thang(month As Integer, ByRef list As List(Of TheLoaiDTO), ByRef listsoluotmuon As List(Of Integer))
        Return ctpmDAL.baocao_TheoTheLoai_Thang(month, list, listsoluotmuon)
    End Function
    Public Function baocao_TheoTheLoai_Nam(year As Integer, ByRef list As List(Of TheLoaiDTO), ByRef listsoluotmuon As List(Of Integer))
        Return ctpmDAL.baocao_TheoTheLoai_Nam(year, list, listsoluotmuon)
    End Function
    Public Function baocao_TheoTheLoai(ByRef list As List(Of TheLoaiDTO), ByRef listsoluotmuon As List(Of Integer))
        Return ctpmDAL.baocao_TheoTheLoai(list, listsoluotmuon)
    End Function

End Class
