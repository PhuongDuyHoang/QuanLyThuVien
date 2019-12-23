Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class DangNhapBus
    Private dn As DangNhapDAL
    Private ng As NguoiDungDAL
    Private vt As VaiTroDAL

    Public Sub New()
        dn = New DangNhapDAL()
        ng = New NguoiDungDAL()
        vt = New VaiTroDAL()
    End Sub
    Public Sub New(connectionString As String)
        dn = New DangNhapDAL(connectionString)
        ng = New NguoiDungDAL()
        vt = New VaiTroDAL()
    End Sub

    Public Function update(value As DangNhapDTO) As Result
        Return dn.update(value)
    End Function

    Public Function kiemTra(tendangnhap As String, matkhau As String, ByRef value As DangNhapDTO) As Result
        Return dn.kiemTra(tendangnhap, matkhau, value)
    End Function

    Public Function getVaiTro(dangnhap As DangNhapDTO, ByRef vaitro As VaiTroDTO) As Result
        Dim nguoidung As New NguoiDungDTO
        ng.getByMaNguoiDung(dangnhap.NguoiDung, nguoidung)
        Return vt.getByMaVaiTro(nguoidung.VaiTro, vaitro)
    End Function

    Public Function insert(value As DangNhapDTO) As Result
        Return dn.insert(value)
    End Function

    Public Function buildMaDangNhap(ByRef value As String) As Result
        Return dn.buildMaDangNhap(value)
    End Function

End Class
