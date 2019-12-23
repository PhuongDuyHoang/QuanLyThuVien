Public Class ThamSoDTO
    Private iTuoiToiThieu As Integer
    Private iSoSachMuonToiDa As Integer
    Private iSoSachMuonToiDa1Lan As Integer
    Private iHanMuonSach As Integer
    Private iMucGiaPhat As Integer
    Private iMucGiaCoBan As Integer

    Public Sub New()
    End Sub

    Public Sub New(iTuoiToiThieu As Integer, iSoSachMuonToiDa As Integer, iSoSachMuonToiDa1Lan As Integer, iHanMuonSach As Integer, iMucGiaPhat As Integer, iMucGiaCoBan As Integer)
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iSoSachMuonToiDa = iSoSachMuonToiDa
        Me.iSoSachMuonToiDa1Lan = iSoSachMuonToiDa1Lan
        Me.iHanMuonSach = iHanMuonSach
        Me.iMucGiaPhat = iMucGiaPhat
        Me.iMucGiaCoBan = iMucGiaCoBan
    End Sub

    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set(value As Integer)
            iTuoiToiThieu = value
        End Set
    End Property

    Public Property SoSachMuonToiDa As Integer
        Get
            Return iSoSachMuonToiDa
        End Get
        Set(value As Integer)
            iSoSachMuonToiDa = value
        End Set
    End Property

    Public Property SoSachMuonToiDa1Lan As Integer
        Get
            Return iSoSachMuonToiDa1Lan
        End Get
        Set(value As Integer)
            iSoSachMuonToiDa1Lan = value
        End Set
    End Property

    Public Property HanMuonSach As Integer
        Get
            Return iHanMuonSach
        End Get
        Set(value As Integer)
            iHanMuonSach = value
        End Set
    End Property

    Public Property MucGiaPhat As Integer
        Get
            Return iMucGiaPhat
        End Get
        Set(value As Integer)
            iMucGiaPhat = value
        End Set
    End Property

    Public Property MucGiaCoBan As Integer
        Get
            Return iMucGiaCoBan
        End Get
        Set(value As Integer)
            iMucGiaCoBan = value
        End Set
    End Property
End Class
