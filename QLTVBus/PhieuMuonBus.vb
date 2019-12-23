Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class PhieuMuonBUS
    Private pms As PhieuMuonDAL
    Public Sub New()
        pms = New PhieuMuonDAL()
    End Sub
    Public Sub New(connectionString As String)
        pms = New PhieuMuonDAL(connectionString)
    End Sub

    Public Function build_maphieumuon(ByRef nextMaPhieuMuon As String) As Result
        Return pms.build_maphieumuon(nextMaPhieuMuon)
    End Function

    Public Function insert(value As PhieuMuonDTO) As Result
        Return pms.insert(value)
    End Function

    Public Function selectALL(ByRef listPhieuMuon As List(Of PhieuMuonDTO)) As Result
        Return pms.selectALL(listPhieuMuon)
    End Function

    Public Function getAll_SachDangMuon_ByMaDocGia(madocgia As String, ByRef listMaSach As List(Of String), ByRef listTenSach As List(Of String), ByRef listNgayMuon As List(Of Date)) As Result
        Return pms.getAll_SachDangMuon_ByMaDocGia(madocgia, listMaSach, listTenSach, listNgayMuon)
    End Function
End Class
