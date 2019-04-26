Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_kegiatan
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
        'txtjudul.Text = ""
        'txtisi.Text = ""
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Kegiatan_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_KEGIATAN")
                cmd.Parameters.AddWithValue("@id_kegiatan", "")
                cmd.Parameters.AddWithValue("@judul", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        kegiatan.DataSource = dt
                        kegiatan.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    'Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    '    Dim judul As String = txtjudul.Text
    '    Dim isi As String = txtisi.Text
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("Pengumuman_CRUD")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.AddWithValue("@Action", "INSERT")
    '            cmd.Parameters.AddWithValue("@id_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@judul_pengumuman", judul)
    '            cmd.Parameters.AddWithValue("@file_pengumuman", "")
    '            cmd.Parameters.AddWithValue("@isi_pengumuman", isi)
    '            cmd.Parameters.AddWithValue("@waktu_unggah", "")
    '            cmd.Connection = con
    '            con.Open()
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End Using
    '    End Using
    '    Me.BindGrid()
    '    Server.Transfer("pengumuman.aspx", True)
    'End Sub

    Private Sub Insert()
        Dim judul As String = txtjudul.Text
        Dim deskripsi As String = txtdeskripsi.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Kegiatan_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT_KEGIATAN")
                cmd.Parameters.AddWithValue("@id_kegiatan", "")
                cmd.Parameters.AddWithValue("@judul", judul)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub


    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        kegiatan.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        kegiatan.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = kegiatan.Rows(e.RowIndex)
        Dim id_kegiatan As Integer = Convert.ToInt32(kegiatan.DataKeys(e.RowIndex).Values(0))
        Dim judul As String = TryCast(row.FindControl("txtjudul"), TextBox).Text
        Dim deskripsi As String = TryCast(row.FindControl("txtdeskripsi"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Kegiatan_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE_KEGIATAN")
                cmd.Parameters.AddWithValue("@id_kegiatan", id_kegiatan)
                cmd.Parameters.AddWithValue("@judul", judul)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        kegiatan.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> kegiatan.EditIndex Then
            TryCast(e.Row.Cells(2).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_kegiatan As Integer = Convert.ToInt32(kegiatan.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Kegiatan_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE_KEGIATAN")
                cmd.Parameters.AddWithValue("@id_kegiatan", id_kegiatan)
                cmd.Parameters.AddWithValue("@judul", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("~/Menu_TU/Kegiatan.aspx")
    End Sub

End Class