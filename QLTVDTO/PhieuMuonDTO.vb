Public Class PhieuMuonDTO
    Private strMaPhieuMuon As String
    Private strDocGia As String
    Private strThuThu As String
    Private dtNgayMuon As DateTime

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuMuon As String, strDocGia As String, strThuThu As String, dtNgayMuon As Date)
        Me.strMaPhieuMuon = strMaPhieuMuon
        Me.strDocGia = strDocGia
        Me.strThuThu = strThuThu
        Me.dtNgayMuon = dtNgayMuon
    End Sub

    Public Property MaPhieuMuon As String
        Get
            Return strMaPhieuMuon
        End Get
        Set(value As String)
            strMaPhieuMuon = value
        End Set
    End Property

    Public Property DocGia As String
        Get
            Return strDocGia
        End Get
        Set(value As String)
            strDocGia = value
        End Set
    End Property

    Public Property ThuThu As String
        Get
            Return strThuThu
        End Get
        Set(value As String)
            strThuThu = value
        End Set
    End Property

    Public Property NgayMuon As Date
        Get
            Return dtNgayMuon
        End Get
        Set(value As Date)
            dtNgayMuon = value
        End Set
    End Property
End Class
