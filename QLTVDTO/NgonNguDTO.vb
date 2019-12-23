Public Class NgonNguDTO
    Private strMaNgonNgu As String
    Private strTenNgonNgu As String

    Public Sub New()
    End Sub

    Public Sub New(strMaNgonNgu As String, strTenNgonNgu As String)
        Me.strMaNgonNgu = strMaNgonNgu
        Me.strTenNgonNgu = strTenNgonNgu
    End Sub

    Public Property MaNgonNgu As String
        Get
            Return strMaNgonNgu
        End Get
        Set(value As String)
            strMaNgonNgu = value
        End Set
    End Property

    Public Property TenNgonNgu As String
        Get
            Return strTenNgonNgu
        End Get
        Set(value As String)
            strTenNgonNgu = value
        End Set
    End Property
End Class
