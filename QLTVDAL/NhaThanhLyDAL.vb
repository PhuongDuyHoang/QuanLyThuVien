Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class NhaThanhLyDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaNhaThanhLy(ByRef value As String) As Result
        value = String.Empty
        value = "NTL"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manhathanhly] "
        query &= "FROM [tblNhaThanhLy] "
        query &= "ORDER BY [manhathanhly] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("manhathanhly")
                        End While
                    Else
                        value = value + "00001"
                        Return New Result(True)
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim v = msOnDB.Substring(3)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 3, "0")
                        value = value + tmp
                        System.Console.WriteLine(value)
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function selectAll(ByRef list As List(Of NhaThanhLyDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT * FROM [tblNhaThanhLy]"

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
                            list.Add(New NhaThanhLyDTO(reader("manhathanhly"), reader("tennhathanhly"), reader("diachi"), reader("sodienthoai"), reader("sofax")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà thanh lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(value As NhaThanhLyDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblNhaThanhLy]"
        query &= " VALUES (@manhathanhly, @tennhathanhly, @diachi, @sodienthoai, @sofax)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhathanhly", value.MaNhaThanhLy)
                    .Parameters.AddWithValue("@tennhathanhly", value.TenNhaThanhLy)
                    .Parameters.AddWithValue("@diachi", value.DiaChi)
                    .Parameters.AddWithValue("@sodienthoai", value.SoDienThoai)
                    .Parameters.AddWithValue("@sofax", value.SoFax)
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
