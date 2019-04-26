Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Partial Class jadwal_ibadah
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.BindGrid()
        End If
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

    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        jadwal.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        jadwal.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = jadwal.Rows(e.RowIndex)
        Dim id_jadwal As Integer = Convert.ToInt32(jadwal.DataKeys(e.RowIndex).Values(0))
        Dim nama_ibadah As String = TryCast(row.FindControl("txtNama"), TextBox).Text
        Dim deskripsi As String = TryCast(row.FindControl("txtDeskripsi"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jadwal_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE_JADWAL")
                cmd.Parameters.AddWithValue("@id_jadwal", id_jadwal)
                cmd.Parameters.AddWithValue("@nama_ibadah", nama_ibadah)
                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        jadwal.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> jadwal.EditIndex Then
            TryCast(e.Row.Cells(2).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Apakah Anda yakin ingin menghapus data ini?');"
        End If
    End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_jadwal As Integer = Convert.ToInt32(jadwal.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("jadwal_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE_JADWAL")
                cmd.Parameters.AddWithValue("@id_jadwal", id_jadwal)
                cmd.Parameters.AddWithValue("@nama_ibadah", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
End Class


'Imports System.Data
'Imports System.Configuration
'Imports System.Data.SqlClient
'Partial Class Jadwal_ibadah
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        If Not Me.IsPostBack Then
'            Me.BindGrid()
'            Me.SearchJadwalIbadah()
'        End If
'    End Sub

'    Private Sub BindGrid()
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Jadwal_CRUD")
'                cmd.Parameters.AddWithValue("@Action", "SELECT_JADWAL")
'                cmd.Parameters.AddWithValue("@id_jadwal", "")
'                cmd.Parameters.AddWithValue("@nama_ibadah", "")
'                cmd.Parameters.AddWithValue("@deskripsi", "")
'                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
'                Using sda As New SqlDataAdapter()
'                    cmd.CommandType = CommandType.StoredProcedure
'                    cmd.Connection = con
'                    sda.SelectCommand = cmd
'                    Using dt As New DataTable()
'                        sda.Fill(dt)
'                        jadwal.DataSource = dt
'                        jadwal.DataBind()
'                    End Using
'                End Using
'            End Using
'        End Using
'    End Sub

'    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
'        jadwal.EditIndex = e.NewEditIndex
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
'        jadwal.EditIndex = -1
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
'        Dim row As GridViewRow = jadwal.Rows(e.RowIndex)
'        Dim id_jadwal As Integer = Convert.ToInt32(jadwal.DataKeys(e.RowIndex).Values(0))
'        Dim nama_ibadah As String = TryCast(row.FindControl("txtnama"), TextBox).Text
'        Dim deskripsi As String = TryCast(row.FindControl("txtdeskripsi"), TextBox).Text
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Jadwal_CRUD")
'                cmd.CommandType = CommandType.StoredProcedure
'                cmd.Parameters.AddWithValue("@Action", "UPDATE_JADWAL")
'                cmd.Parameters.AddWithValue("@id_jadwal", id_jadwal)
'                cmd.Parameters.AddWithValue("@nama_ibadah", nama_ibadah)
'                cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
'                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
'                cmd.Connection = con
'                con.Open()
'                cmd.ExecuteNonQuery()
'                con.Close()
'            End Using
'        End Using
'        jadwal.EditIndex = -1
'        Me.BindGrid()
'    End Sub

'    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
'        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> jadwal.EditIndex Then
'            TryCast(e.Row.Cells(3).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
'        End If
'    End Sub

'    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
'        Dim id_jadwal As Integer = Convert.ToInt32(jadwal.DataKeys(e.RowIndex).Values(0))
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand("Jadwal_CRUD")
'                cmd.CommandType = CommandType.StoredProcedure
'                cmd.Parameters.AddWithValue("@Action", "DELETE_JADWAL")
'                cmd.Parameters.AddWithValue("@id_jadwal", id_jadwal)
'                cmd.Parameters.AddWithValue("@nama_ibadah", "")
'                cmd.Parameters.AddWithValue("@deskripsi", "")
'                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
'                cmd.Connection = con
'                con.Open()
'                cmd.ExecuteNonQuery()
'                con.Close()
'            End Using
'        End Using
'        Me.BindGrid()
'    End Sub
'    Private Sub SearchJadwalIbadah()
'        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Using con As New SqlConnection(constr)
'            Using cmd As New SqlCommand()
'                Dim sql As String = "SELECT id_jadwal, nama_ibadah, deskripsi, waktu_unggah_jadwal FROM jadwal"
'                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
'                    sql += " WHERE nama_ibadah LIKE @nama_ibadah + '%'"
'                    cmd.Parameters.AddWithValue("@nama_ibadah", txtSearch.Text.Trim())
'                End If
'                cmd.CommandText = sql
'                cmd.Connection = con
'                Using sda As New SqlDataAdapter(cmd)
'                    Dim dt As New DataTable()
'                    sda.Fill(dt)
'                    jadwal.DataSource = dt
'                    jadwal.DataBind()
'                End Using
'            End Using
'        End Using
'    End Sub
'    Protected Sub Search(sender As Object, e As EventArgs)
'        Me.SearchJadwalIbadah()
'    End Sub

'    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
'        jadwal.PageIndex = e.NewPageIndex
'        Me.SearchJadwalIbadah()
'    End Sub
'End Class
