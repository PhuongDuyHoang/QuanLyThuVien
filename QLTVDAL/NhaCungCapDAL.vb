Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class NhaCungCapDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaNhaCungCap(ByRef value As String) As Result
        value = String.Empty
        value = "NCC"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manhacungcap] "
        query &= "FROM [tblNhaCungCap] "
        query &= "ORDER BY [manhacungcap] DESC "

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
                            msOnDB = reader("manhacungcap")
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

    Public Function selectAll(ByRef list As List(Of NhaCungCapDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT * FROM [tblNhaCungCap]"

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
                            list.Add(New NhaCungCapDTO(reader("manhacungcap"), reader("tennhacungcap"), reader("diachi"), reader("sodienthoai"), reader("sofax")))
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

    Public Function insert(value As NhaCungCapDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblNhaCungCap]"
        query &= " VALUES (@manhacungcap, @tennhacungcap, @diachi, @sodienthoai, @sofax)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhacungcap", value.MaNhaCungCap)
                    .Parameters.AddWithValue("@tennhacungcap", value.TenNhaCungCap)
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
