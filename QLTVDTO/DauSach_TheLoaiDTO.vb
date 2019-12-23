Public Class DauSach_TheLoaiDTO
    Private strMaDauSach As String
    Private strMaTheLoai As String

    Public Sub New()
    End Sub

    Public Sub New(strMaDauSach As String, strMaTheLoai As String)
        Me.strMaDauSach = strMaDauSach
        Me.strMaTheLoai = strMaTheLoai
    End Sub

    Public Property MaDauSach As String
        Get
            Return strMaDauSach
        End Get
        Set(value As String)
            strMaDauSach = value
        End Set
    End Property

    Public Property MaTheLoai As String
        Get
            Return strMaTheLoai
        End Get
        Set(value As String)
            strMaTheLoai = value
        End Set
    End Property
End Class
