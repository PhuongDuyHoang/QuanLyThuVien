Public Class NguoiDungDTO
    Private strMaNguoiDung As String
    Private strHoTen As String
    Private strCMND As String
    Private strGioiTinh As Boolean
    Private dtNgaySinh As DateTime
    Private strDiaChi As String
    Private strEmail As String
    Private strSoDienThoai As String
    Private strVaiTro As String
    Private dtNgayTao As DateTime

    Public Sub New()
    End Sub

    Public Sub New(strMaNguoiDung As String, strHoTen As String, strCMND As String, strGioiTinh As Boolean, dtNgaySinh As Date, strDiaChi As String, strEmail As String, strSoDienThoai As String, strVaiTro As String, dtNgayTao As Date)
        Me.strMaNguoiDung = strMaNguoiDung
        Me.strHoTen = strHoTen
        Me.strCMND = strCMND
        Me.strGioiTinh = strGioiTinh
        Me.dtNgaySinh = dtNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.strSoDienThoai = strSoDienThoai
        Me.strVaiTro = strVaiTro
        Me.dtNgayTao = dtNgayTao
    End Sub

    Public Property MaNguoiDung As String
        Get
            Return strMaNguoiDung
        End Get
        Set(value As String)
            strMaNguoiDung = value
        End Set
    End Property

    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property CMND As String
        Get
            Return strCMND
        End Get
        Set(value As String)
            strCMND = value
        End Set
    End Property

    Public Property GioiTinh As Boolean
        Get
            Return strGioiTinh
        End Get
        Set(value As Boolean)
            strGioiTinh = value
        End Set
    End Property

    Public Property NgaySinh As Date
        Get
            Return dtNgaySinh
        End Get
        Set(value As Date)
            dtNgaySinh = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property SoDienThoai As String
        Get
            Return strSoDienThoai
        End Get
        Set(value As String)
            strSoDienThoai = value
        End Set
    End Property

    Public Property VaiTro As String
        Get
            Return strVaiTro
        End Get
        Set(value As String)
            strVaiTro = value
        End Set
    End Property

    Public Property NgayTao As Date
        Get
            Return dtNgayTao
        End Get
        Set(value As Date)
            dtNgayTao = value
        End Set
    End Property
End Class
