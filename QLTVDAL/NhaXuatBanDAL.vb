Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTVDTO
Imports Utility

Public Class NhaXuatBanDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function buildMaNhaXuatBan(ByRef value As String) As Result
        value = String.Empty
        value = "NXB"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [manhaxuatban] "
        query &= "FROM [tblNhaXuatBan] "
        query &= "ORDER BY [manhaxuatban] DESC "

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
                            msOnDB = reader("manhaxuatban")
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

    Public Function selectAll(ByRef listNXB As List(Of NhaXuatBanDTO)) As Result
        Dim query As String = String.Empty
        query &= " SELECT * FROM [tblNhaXuatBan]"

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
                        listNXB.Clear()
                        While reader.Read()
                            listNXB.Add(New NhaXuatBanDTO(reader("manhaxuatban"), reader("tennhaxuatban"), reader("diachi"), reader("sodienthoai"), reader("sofax")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function getByMaNhaXuatBan(manhaxuatban As String, ByRef value As NhaXuatBanDTO) As Result
        Dim query As String = String.Empty
        query &= " SELECT * FROM [tblNhaXuatBan] WHERE [manhaxuatban] = @manhaxuatban"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", manhaxuatban)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            value = New NhaXuatBanDTO(reader("manhaxuatban"), reader("tennhaxuatban"), reader("diachi"), reader("sodienthoai"), reader("sofax"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả nhà xuất bản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function insert(value As NhaXuatBanDTO) As Result

        Dim query As String = String.Empty
        query &= " INSERT INTO [tblNhaXuatBan]"
        query &= " VALUES (@manhaxuatban, @tennhaxuatban, @diachi, @sodienthoai, @sofax)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhaxuatban", value.MaNhaXuatBan)
                    .Parameters.AddWithValue("@tennhaxuatban", value.TenNhaXuatBan)
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
