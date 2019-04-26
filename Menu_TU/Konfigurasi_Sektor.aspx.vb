Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Konfigurasi_sektor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Sektor_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT")
                cmd.Parameters.AddWithValue("@id_sektor", "")
                cmd.Parameters.AddWithValue("@nama_sektor", "")
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        sektor.DataSource = dt
                        sektor.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub Insert()
        Dim nama_sektor As String = txtNama.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Sektor_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_sektor", "")
                cmd.Parameters.AddWithValue("@nama_sektor", nama_sektor)
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub

    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        sektor.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        sektor.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = sektor.Rows(e.RowIndex)
        Dim id_sektor As Integer = Convert.ToInt32(sektor.DataKeys(e.RowIndex).Values(0))
        Dim nama_sektor As String = TryCast(row.FindControl("txtNama"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Sektor_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE")
                cmd.Parameters.AddWithValue("@id_sektor", id_sektor)
                cmd.Parameters.AddWithValue("@nama_sektor", nama_sektor)
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        sektor.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> sektor.EditIndex Then
            TryCast(e.Row.Cells(3).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_sektor As Integer = Convert.ToInt32(sektor.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Sektor_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE")
                cmd.Parameters.AddWithValue("@id_gereja", id_sektor)
                cmd.Parameters.AddWithValue("@nama_sektor", "")
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    Protected Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Insert()
        Response.Redirect("~Menu_TU/Index_TU.aspx")
    End Sub
End Class
