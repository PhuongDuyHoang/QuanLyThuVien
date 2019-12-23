Public Class NhaXuatBanDTO
    Private strMaNhaXuatBan As String
    Private strTenNhaXuatBan As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Private strSoFax As String

    Public Sub New()

    End Sub

    Public Sub New(strMaNhaXuatBan As String, strTenNhaXuatBan As String, strDiaChi As String, strSoDienThoai As String, strSoFax As String)
        Me.strMaNhaXuatBan = strMaNhaXuatBan
        Me.strTenNhaXuatBan = strTenNhaXuatBan
        Me.strDiaChi = strDiaChi
        Me.strSoDienThoai = strSoDienThoai
        Me.strSoFax = strSoFax
    End Sub

    Property MaNhaXuatBan() As String
        Get
            Return strMaNhaXuatBan
        End Get
        Set(ByVal value As String)
            strMaNhaXuatBan = value
        End Set
    End Property

    Property TenNhaXuatBan() As String
        Get
            Return strTenNhaXuatBan
        End Get
        Set(ByVal value As String)
            strTenNhaXuatBan = value
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

    Public Property SoDienThoai As String
        Get
            Return strSoDienThoai
        End Get
        Set(value As String)
            strSoDienThoai = value
        End Set
    End Property

    Public Property SoFax As String
        Get
            Return strSoFax
        End Get
        Set(value As String)
            strSoFax = value
        End Set
    End Property
End Class
