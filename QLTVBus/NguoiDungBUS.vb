Imports QLTVDAL
Imports QLTVDTO
Imports Utility

Public Class NguoiDungBUS
    Private nd As NguoiDungDAL
    Public Sub New()
        nd = New NguoiDungDAL()
    End Sub
    Public Sub New(condectionString As String)
        nd = New NguoiDungDAL(condectionString)
    End Sub

    Public Function selectALL(ByRef list As List(Of NguoiDungDTO)) As Result
        Return nd.selectALL(list)
    End Function

    Public Function selectALL_ByFilters(manguoidung As String, hoten As String, diachi As String,
                                        tuoithapnhat As Integer, tuoicaonhat As Integer,
                                        vaitro As String,
                                        ngaytaothapnhat As Date, ngaytaocaonhat As Date,
                                        ByRef list As List(Of NguoiDungDTO)) As Result
        Return nd.selectALL_ByFilters(manguoidung, hoten, diachi,
                                        tuoithapnhat, tuoicaonhat,
                                        vaitro,
                                        ngaytaothapnhat, ngaytaocaonhat,
                                        list)
    End Function

    Public Function selectALL_ByMaNguoiDung(manguoidung As String, ByRef list As List(Of String)) As Result
        Return nd.selectALL_ByMaNguoiDung(manguoidung, list)
    End Function

    Public Function selectALL_ByHoTen(hoten As String, ByRef list As List(Of String)) As Result
        Return nd.selectAll_ByHoTen(hoten, list)
    End Function

    Public Function selectALL_ByEmail(email As String, ByRef list As List(Of String)) As Result
        Return nd.selectALL_ByEmail(email, list)
    End Function

    Public Function getByMaNguoiDung(manguoidung As String, ByRef value As NguoiDungDTO) As Result
        Return nd.getByMaNguoiDung(manguoidung, value)
    End Function

    Public Function buildMaNguoiDung(ByRef value As String) As Result
        Return nd.build_manguoidung(value)
    End Function

    Public Function insert(value As NguoiDungDTO) As Result
        Return nd.insert(value)
    End Function

    Public Function update(value As NguoiDungDTO) As Result
        Return nd.update(value)
    End Function

    Public Function selectALLDocGia(ByRef listDocGia As List(Of NguoiDungDTO)) As Result
        Return nd.selectALLDocGia(listDocGia)
    End Function

    Public Function getNgayTao_ByMaNguoiDung(manguoidung As String, ByRef ngaytao As Date)
        Return nd.getNgayTao_ByMaNguoiDung(manguoidung, ngaytao)
    End Function
End Class


