Public Class PhieuXuatDTO
    Private strMaPhieuXuat As String
    Private dtNgayXuat As DateTime
    Private strNhaThanhLy As String
    Private iTongTien As Integer
    Private strNguoiXuat As Integer

    Public Sub New()
    End Sub

    Public Sub New(strMaPhieuXuat As String, dtNgayXuat As Date, strNhaThanhLy As String, iTongTien As Integer, strNguoiXuat As Integer)
        Me.strMaPhieuXuat = strMaPhieuXuat
        Me.dtNgayXuat = dtNgayXuat
        Me.strNhaThanhLy = strNhaThanhLy
        Me.iTongTien = iTongTien
        Me.strNguoiXuat = strNguoiXuat
    End Sub

    Public Property MaPhieuXuat As String
        Get
            Return strMaPhieuXuat
        End Get
        Set(value As String)
            strMaPhieuXuat = value
        End Set
    End Property

    Public Property NgayXuat As Date
        Get
            Return dtNgayXuat
        End Get
        Set(value As Date)
            dtNgayXuat = value
        End Set
    End Property

    Public Property NhaThanhLy As String
        Get
            Return strNhaThanhLy
        End Get
        Set(value As String)
            strNhaThanhLy = value
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

    Public Property NguoiXuat As Integer
        Get
            Return strNguoiXuat
        End Get
        Set(value As Integer)
            strNguoiXuat = value
        End Set
    End Property
End Class
