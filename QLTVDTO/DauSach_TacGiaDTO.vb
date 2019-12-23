Public Class DauSach_TacGiaDTO
    Private strMaDauSach As String
    Private strMaTacGia As String

    Public Sub New()
    End Sub

    Public Sub New(strMaDauSach As String, strMaTacGia As String)
        Me.strMaDauSach = strMaDauSach
        Me.strMaTacGia = strMaTacGia
    End Sub

    Public Property MaDauSach As String
        Get
            Return strMaDauSach
        End Get
        Set(value As String)
            strMaDauSach = value
        End Set
    End Property

    Public Property MaTacGia As String
        Get
            Return strMaTacGia
        End Get
        Set(value As String)
            strMaTacGia = value
        End Set
    End Property
End Class
