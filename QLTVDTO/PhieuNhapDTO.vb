Public Class PhieuNhapDTO
    Private strMaPhieuNhap As String
    Private dtNgayNhap As DateTime
    Private strNhaCungCap As String
    Private iTongTien As Integer
    Private strNguoiNhap As String

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuNhap As String, dtNgayNhap As Date, strNhaCungCap As String, iTongTien As Integer, strNguoiNhap As String)
        Me.strMaPhieuNhap = strMaPhieuNhap
        Me.dtNgayNhap = dtNgayNhap
        Me.strNhaCungCap = strNhaCungCap
        Me.iTongTien = iTongTien
        Me.strNguoiNhap = strNguoiNhap
    End Sub

    Public Property MaPhieuNhap As String
        Get
            Return strMaPhieuNhap
        End Get
        Set(value As String)
            strMaPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return dtNgayNhap
        End Get
        Set(value As Date)
            dtNgayNhap = value
        End Set
    End Property

    Public Property NhaCungCap As String
        Get
            Return strNhaCungCap
        End Get
        Set(value As String)
            strNhaCungCap = value
        End Set
    End Property

    Public Property TongTien As Integer
        Get
            Return iTongTien
        End Get
        Set(value As Integer)
            iTongTien = value
        End Set
    End Property

    Public Property NguoiNhap As String
        Get
            Return strNguoiNhap
        End Get
        Set(value As String)
            strNguoiNhap = value
        End Set
    End Property
End Class
