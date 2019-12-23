Public Class ChiTietPhieuTraDTO
    Private strMaPhieuTra As String
    Private strMaCuonSach As String

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuTra As String, strMaCuonSach As String)
        Me.strMaPhieuTra = strMaPhieuTra
        Me.strMaCuonSach = strMaCuonSach
    End Sub

    Public Property MaPhieuTra As String
        Get
            Return strMaPhieuTra
        End Get
        Set(value As String)
            strMaPhieuTra = value
        End Set
    End Property

    Public Property MaCuonSach As String
        Get
            Return strMaCuonSach
        End Get
        Set(value As String)
            strMaCuonSach = value
        End Set
    End Property
End Class
