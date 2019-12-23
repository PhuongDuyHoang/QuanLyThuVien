Public Class ChiTietPhieuMuonDTO
    Private strMaPhieuMuon As String
    Private strMaCuonSach As String

    Public Sub New()

    End Sub

    Public Sub New(strMaPhieuMuon As String, strMaCuonSach As String)
        Me.strMaPhieuMuon = strMaPhieuMuon
        Me.strMaCuonSach = strMaCuonSach
    End Sub

    Public Property MaPhieuMuon As String
        Get
            Return strMaPhieuMuon
        End Get
        Set(value As String)
            strMaPhieuMuon = value
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
