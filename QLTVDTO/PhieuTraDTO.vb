Public Class PhieuTraDTO
    Private strMaPhieuTra As String
    Private strDocGia As String
    Private strThuThu As String
    Private dtNgayTra As String

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuTra As String, strDocGia As String, strThuThu As String, dtNgayTra As String)
        Me.strMaPhieuTra = strMaPhieuTra
        Me.strDocGia = strDocGia
        Me.strThuThu = strThuThu
        Me.dtNgayTra = dtNgayTra
    End Sub

    Public Property MaPhieuTra As String
        Get
            Return strMaPhieuTra
        End Get
        Set(value As String)
            strMaPhieuTra = value
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

    Public Property NgayTra As String
        Get
            Return dtNgayTra
        End Get
        Set(value As String)
            dtNgayTra = value
        End Set
    End Property
End Class
