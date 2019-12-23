Public Class DauSachDTO
    Private strMaDauSach As String
    Private strTenDauSach As String
    Private strTomTat As String
    Private strNhaXuatBan As String
    Private strNamXuatBan As Integer
    Private strTriGia As Integer

    Public Sub New()
    End Sub

    Public Sub New(strMaDauSach As String, strTenDauSach As String, strTomTat As String, strNhaXuatBan As String, strNamXuatBan As Integer, strTriGia As Integer)
        Me.strMaDauSach = strMaDauSach
        Me.strTenDauSach = strTenDauSach
        Me.strTomTat = strTomTat
        Me.strNhaXuatBan = strNhaXuatBan
        Me.strNamXuatBan = strNamXuatBan
        Me.strTriGia = strTriGia
    End Sub

    Public Property MaDauSach As String
        Get
            Return strMaDauSach
        End Get
        Set(value As String)
            strMaDauSach = value
        End Set
    End Property

    Public Property TenDauSach As String
        Get
            Return strTenDauSach
        End Get
        Set(value As String)
            strTenDauSach = value
        End Set
    End Property

    Public Property TomTat As String
        Get
            Return strTomTat
        End Get
        Set(value As String)
            strTomTat = value
        End Set
    End Property

    Public Property NhaXuatBan As String
        Get
            Return strNhaXuatBan
        End Get
        Set(value As String)
            strNhaXuatBan = value
        End Set
    End Property

    Public Property NamXuatBan As Integer
        Get
            Return strNamXuatBan
        End Get
        Set(value As Integer)
            strNamXuatBan = value
        End Set
    End Property

    Public Property TriGia As Integer
        Get
            Return strTriGia
        End Get
        Set(value As Integer)
            strTriGia = value
        End Set
    End Property
End Class
