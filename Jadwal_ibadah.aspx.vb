Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class jadwal_ibadah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
            Me.SearchPengumuman()
        End If
    End Sub
    Private Sub SearchPengumuman()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT * FROM jadwal"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE nama_ibadah LIKE @nama_ibadah+ '%'"
                    cmd.Parameters.AddWithValue("@nama_ibadah", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    jadwal.DataSource = dt
                    jadwal.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchPengumuman()
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jadwal_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_JADWAL")
                cmd.Parameters.AddWithValue("@id_jadwal", "")
                cmd.Parameters.AddWithValue("@nama_ibadah", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        jadwal.DataSource = dt
                        jadwal.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class