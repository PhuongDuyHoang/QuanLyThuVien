Public Class NhaThanhLyDTO
    Private strMaNhaThanhLy As String
    Private strTenNhaThanhLy As String
    Private strDiaChi As String
    Private strSoDienThoai As String
    Private strSoFax As String

    Public Sub New()
    End Sub

    Public Sub New(strMaNhaThanhLy As String, strTenNhaThanhLy As String, strDiaChi As String, strSoDienThoai As String, strSoFax As String)
        Me.strMaNhaThanhLy = strMaNhaThanhLy
        Me.strTenNhaThanhLy = strTenNhaThanhLy
        Me.strDiaChi = strDiaChi
        Me.strSoDienThoai = strSoDienThoai
        Me.strSoFax = strSoFax
    End Sub

    Public Property MaNhaThanhLy As String
        Get
            Return strMaNhaThanhLy
        End Get
        Set(value As String)
            strMaNhaThanhLy = value
        End Set
    End Property

    Public Property TenNhaThanhLy As String
        Get
            Return strTenNhaThanhLy
        End Get
        Set(value As String)
            strTenNhaThanhLy = value
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
