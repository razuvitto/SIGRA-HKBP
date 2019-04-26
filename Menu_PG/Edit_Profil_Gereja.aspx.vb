Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class Edit_Profil_Gereja
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Konfigurasi")
                cmd.Parameters.AddWithValue("@Action", "SELECT")
                cmd.Parameters.AddWithValue("@id_gereja", "")
                cmd.Parameters.AddWithValue("@nama_gereja", "")
                cmd.Parameters.AddWithValue("@alamat_gereja", "")
                cmd.Parameters.AddWithValue("@distrik_gereja", "")
                cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
                cmd.Parameters.AddWithValue("@logo_gereja", "")
                cmd.Parameters.AddWithValue("@path", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        profil_gereja.DataSource = dt
                        profil_gereja.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        profil_gereja.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        profil_gereja.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = profil_gereja.Rows(e.RowIndex)
        Dim id_gereja As Integer = Convert.ToInt32(profil_gereja.DataKeys(e.RowIndex).Values(0))
        Dim nama_gereja As String = TryCast(row.FindControl("txtNama"), TextBox).Text
        Dim alamat_gereja As String = TryCast(row.FindControl("txtAlamat"), TextBox).Text
        Dim distrik_gereja As String = TryCast(row.FindControl("txtDistrik"), TextBox).Text
        Dim no_telepon_gereja As String = TryCast(row.FindControl("txtTelepon"), TextBox).Text
        Dim deskripsi As String = TryCast(row.FindControl("txtdeskripsi"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Konfigurasi")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE")
                cmd.Parameters.AddWithValue("@id_gereja", id_gereja)
                cmd.Parameters.AddWithValue("@nama_gereja", nama_gereja)
                cmd.Parameters.AddWithValue("@alamat_gereja", alamat_gereja)
                cmd.Parameters.AddWithValue("@distrik_gereja", distrik_gereja)
                cmd.Parameters.AddWithValue("@no_telepon_gereja", no_telepon_gereja)
                cmd.Parameters.AddWithValue("@logo_gereja", "")
                cmd.Parameters.AddWithValue("@path ", "")
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        profil_gereja.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> profil_gereja.EditIndex Then
            TryCast(e.Row.Cells(5).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_gereja As Integer = Convert.ToInt32(profil_gereja.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Konfigurasi")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE")
                cmd.Parameters.AddWithValue("@id_gereja", id_gereja)
                cmd.Parameters.AddWithValue("@nama_gereja", "")
                cmd.Parameters.AddWithValue("@alamat_gereja", "")
                cmd.Parameters.AddWithValue("@distrik_gereja", "")
                cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
                cmd.Parameters.AddWithValue("@logo_gereja", "")
                cmd.Parameters.AddWithValue("@path ", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
End Class
