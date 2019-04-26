Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class pencarian_data_jemaat
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
                Dim sql As String = "	SELECT nama as 'Nama Jemaat', jenis_kelamin AS 'Jenis Kelamin',alamat AS 'Alamat',nama_sektor 'Nama Sektor'
		FROM jemaat AS A join sektor AS B
		ON A.id_sektor = B.id_sektor"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE nama LIKE @nama+ '%'"
                    cmd.Parameters.AddWithValue("@nama", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    jemaat.DataSource = dt
                    jemaat.DataBind()
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
            Using cmd As New SqlCommand("Jemaat_SP")
                cmd.Parameters.AddWithValue("@Action", "SELECT_JEMAAT")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        jemaat.DataSource = dt
                        jemaat.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class