Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuXuatDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of ChiTietPhieuXuatDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblChiTietPhieuXuat]"


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
                        list.Clear()
                        While reader.Read()
                            list.Add(New ChiTietPhieuXuatDTO(reader("maphieuxuat"), reader("macuonsach"), reader("thanhtien"), reader("ghichu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(value As ChiTietPhieuXuatDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblChiTietPhieuXuat]"
        query &= " VALUES (@maphieuxuat, @macuonsach, @thanhtien, @ghichu)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieuxuat", value.MaPhieuXuat)
                    .Parameters.AddWithValue("@macuonsach", value.MaCuonSach)
                    .Parameters.AddWithValue("@thanhtien", value.ThanhTien)
                    .Parameters.AddWithValue("@ghichu", value.GhiChu)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

End Class
