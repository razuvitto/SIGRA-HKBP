Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Jemaat_Sidi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
            Me.SearchKegiatan()
        End If
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
            TryCast(e.Row.Cells(3).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Apakah Anda yakin ingin menghapus data ini?');"
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
    Private Sub SearchKegiatan()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT id_kegiatan, judul, deskripsi, waktu_unggah FROM Kegiatan"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE judul LIKE @judul+ '%'"
                    cmd.Parameters.AddWithValue("@judul", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    kegiatan.DataSource = dt
                    kegiatan.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchKegiatan()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        kegiatan.PageIndex = e.NewPageIndex
        Me.SearchKegiatan()
    End Sub
End Class
