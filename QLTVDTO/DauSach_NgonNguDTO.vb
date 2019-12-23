Public Class DauSach_NgonNguDTO
    Private strMaDauSach As String
    Private strMaNgonNgu As String

    Public Sub New()
    End Sub

    Public Sub New(strMaDauSach As String, strMaNgonNgu As String)
        Me.strMaDauSach = strMaDauSach
        Me.strMaNgonNgu = strMaNgonNgu
    End Sub

    Public Property MaDauSach As String
        Get
            Return strMaDauSach
        End Get
        Set(value As String)
            strMaDauSach = value
        End Set
    End Property

    Public Property MaNgonNgu As String
        Get
            Return strMaNgonNgu
        End Get
        Set(value As String)
            strMaNgonNgu = value
        End Set
    End Property
End Class
