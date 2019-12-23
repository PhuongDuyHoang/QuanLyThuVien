Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef thamso As ThamSoDTO) As Result

        Dim query As String = String.Empty
        query &= " SELECT * "
        query &= " FROM [tblThamSo]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            thamso = New ThamSoDTO(reader("tuoitoithieu"), reader("sosachmuontoida"), reader("sosachmuontoida1lan"), reader("hanmuonsach"),
                                                   reader("mucgiaphat"), reader("mucgiacoban"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    Return New Result(False, "Lấy danh sách quy định không thành công!", ex.StackTrace) ' that bai
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function update(thamso As ThamSoDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblThamSo] SET"
        query &= " [tuoitoithieu] = @tuoitoithieu "
        query &= " ,[sosachmuontoida] = @sosachmuontoida "
        query &= " ,[sosachmuontoida1lan] = @sosachmuontoida1lan "
        query &= " ,[hanmuonsach] = @hanmuonsach "
        query &= " ,[mucgiaphat] = @mucgiaphat "
        query &= " ,[mucgiacoban] = @mucgiacoban "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tuoitoithieu", thamso.TuoiToiThieu)
                    .Parameters.AddWithValue("@sosachmuontoida", thamso.SoSachMuonToiDa)
                    .Parameters.AddWithValue("@sosachmuontoida1lan", thamso.SoSachMuonToiDa1Lan)
                    .Parameters.AddWithValue("@hanmuonsach", thamso.HanMuonSach)
                    .Parameters.AddWithValue("@mucgiaphat", thamso.MucGiaPhat)
                    .Parameters.AddWithValue("@mucgiacoban", thamso.MucGiaCoBan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' cap nhat that bai
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
