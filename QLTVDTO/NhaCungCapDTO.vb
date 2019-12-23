Public Class NhaCungCapDTO
    Private strMaNhaCungCap As String
    Private strTenNhaCungCap As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Private strSoFax As String

    Public Sub New()
    End Sub

    Public Sub New(strMaNhaCungCap As String, strTenNhaCungCap As String, strDiaChi As String, strSoDienThoai As String, strSoFax As String)
        Me.strMaNhaCungCap = strMaNhaCungCap
        Me.strTenNhaCungCap = strTenNhaCungCap
        Me.strDiaChi = strDiaChi
        Me.strSoDienThoai = strSoDienThoai
        Me.strSoFax = strSoFax
    End Sub

    Public Property MaNhaCungCap As String
        Get
            Return strMaNhaCungCap
        End Get
        Set(value As String)
            strMaNhaCungCap = value
        End Set
    End Property

    Public Property TenNhaCungCap As String
        Get
            Return strTenNhaCungCap
        End Get
        Set(value As String)
            strTenNhaCungCap = value
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
