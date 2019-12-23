Public Class ChiTietPhieuNhapDTO
    Private strMaPhieuNhap As String
    Private strMaDauSach As String
    Private iSoLuong As Integer
    Private strGhiChu As String
    Private strThanhTien As Integer

    Public Sub New()

    End Sub

    Public Sub New(strMaPhieuNhap As String, strMaDauSach As String, iSoLuong As Integer, strGhiChu As String, strThanhTien As Integer)
        Me.strMaPhieuNhap = strMaPhieuNhap
        Me.strMaDauSach = strMaDauSach
        Me.iSoLuong = iSoLuong
        Me.strGhiChu = strGhiChu
        Me.strThanhTien = strThanhTien
    End Sub

    Public Property MaPhieuNhap As String
        Get
            Return strMaPhieuNhap
        End Get
        Set(value As String)
            strMaPhieuNhap = value
        End Set
    End Property

    Public Property MaDauSach As String
        Get
            Return strMaDauSach
        End Get
        Set(value As String)
            strMaDauSach = value
        End Set
    End Property

    Public Property SoLuong As Integer
        Get
            Return iSoLuong
        End Get
        Set(value As Integer)
            iSoLuong = value
        End Set
    End Property

    Public Property GhiChu As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property

    Public Property ThanhTien As Integer
        Get
            Return strThanhTien
        End Get
        Set(value As Integer)
            strThanhTien = value
        End Set
    End Property
End Class
