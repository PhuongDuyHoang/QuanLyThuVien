Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class ChiTietPhieuNhapDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function selectALL(ByRef list As List(Of ChiTietPhieuNhapDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblChiTietPhieuNhap]"


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
                            list.Add(New ChiTietPhieuNhapDTO(reader("maphieunhap"), reader("madausach"), reader("soluong"), reader("ghichu"), reader("thanhtien")))
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

    Public Function getAllByMaPhieuNhap(maphieunhap As String, ByRef list As List(Of ChiTietPhieuNhapDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT *"
        query &= "FROM [tblChiTietPhieuNhap] "
        query &= "WHERE [maphieunhap] = @maphieunhap "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", maphieunhap)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        list.Clear()
                        While reader.Read()
                            list.Add(New ChiTietPhieuNhapDTO(reader("maphieunhap"), reader("madausach"), reader("soluong"), reader("ghichu"), reader("thanhtien")))
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

    Public Function insert(value As ChiTietPhieuNhapDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblChiTietPhieuNhap]"
        query &= " VALUES (@maphieunhap, @madausach, @soluong, @ghichu, @thanhtien)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maphieunhap", value.MaPhieuNhap)
                    .Parameters.AddWithValue("@madausach", value.MaDauSach)
                    .Parameters.AddWithValue("@soluong", value.SoLuong)
                    .Parameters.AddWithValue("@ghichu", value.GhiChu)
                    .Parameters.AddWithValue("@thanhtien", value.ThanhTien)
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
