Public Class DangNhapDTO
    Private strMaDangNhap As String
    Private strNguoiDung As String
    Private strTenDangNhap As String
    Private strMatKhau As String
    Private blDangNhapLanDau As Boolean

    Public Sub New()
    End Sub

    Public Sub New(strMaDangNhap As String, strNguoiDung As String, strTenDangNhap As String, strMatKhau As String, blDangNhapLanDau As Boolean)
        Me.strMaDangNhap = strMaDangNhap
        Me.strNguoiDung = strNguoiDung
        Me.strTenDangNhap = strTenDangNhap
        Me.strMatKhau = strMatKhau
        Me.blDangNhapLanDau = blDangNhapLanDau
    End Sub

    Public Property MaDangNhap As String
        Get
            Return strMaDangNhap
        End Get
        Set(value As String)
            strMaDangNhap = value
        End Set
    End Property

    Public Property NguoiDung As String
        Get
            Return strNguoiDung
        End Get
        Set(value As String)
            strNguoiDung = value
        End Set
    End Property

    Public Property TenDangNhap As String
        Get
            Return strTenDangNhap
        End Get
        Set(value As String)
            strTenDangNhap = value
        End Set
    End Property

    Public Property MatKhau As String
        Get
            Return strMatKhau
        End Get
        Set(value As String)
            strMatKhau = value
        End Set
    End Property

    Public Property DangNhapLanDau As Boolean
        Get
            Return blDangNhapLanDau
        End Get
        Set(value As Boolean)
            blDangNhapLanDau = value
        End Set
    End Property
End Class
