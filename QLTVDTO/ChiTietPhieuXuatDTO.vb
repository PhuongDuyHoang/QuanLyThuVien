Public Class ChiTietPhieuXuatDTO
    Private strMaPhieuXuat As String
    Private strMaCuonSach As String
    Private iThanhTien As Integer
    Private strGhiChu As String

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuXuat As String, strMaCuonSach As String, iThanhTien As Integer, strGhiChu As String)
        Me.strMaPhieuXuat = strMaPhieuXuat
        Me.strMaCuonSach = strMaCuonSach
        Me.iThanhTien = iThanhTien
        Me.strGhiChu = strGhiChu
    End Sub

    Public Property MaPhieuXuat As String
        Get
            Return strMaPhieuXuat
        End Get
        Set(value As String)
            strMaPhieuXuat = value
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

    Public Property ThanhTien As Integer
        Get
            Return iThanhTien
        End Get
        Set(value As Integer)
            iThanhTien = value
        End Set
    End Property

    Public Property GhiChu As String
        Get
            Return strGhiChu
        End Get
        Set(value As String)
            strGhiChu = value
        End Set
    End Property
End Class
