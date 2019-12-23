Public Class VaiTroDTO
    Private strMaVaiTro As String
    Private strTenVaiTro As String

    Public Sub New()
    End Sub

    Public Sub New(strMaVaiTro As String, strTenVaiTro As String)
        Me.strMaVaiTro = strMaVaiTro
        Me.strTenVaiTro = strTenVaiTro
    End Sub

    Public Property MaVaiTro As String
        Get
            Return strMaVaiTro
        End Get
        Set(value As String)
            strMaVaiTro = value
        End Set
    End Property

    Public Property TenVaiTro As String
        Get
            Return strTenVaiTro
        End Get
        Set(value As String)
            strTenVaiTro = value
        End Set
    End Property
End Class
