Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Pengumuman
    Inherits System.Web.UI.Page

    'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    If Not Me.IsPostBack Then
    '        Me.BindGrid()
    '    End If
    'End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not Me.IsPostBack Then
            Dim dt As DataTable = New DataTable()
            dt.Columns.AddRange(New DataColumn(2) {New DataColumn("Id_pengumuman"), New DataColumn("Judul_pengumuman"), New DataColumn("Isi_pengumuman")})
            'dt.Rows.Add(1, "John Hammond", "United States")
            'dt.Rows.Add(2, "Mudassar Khan", "India")
            'dt.Rows.Add(3, "Suzanne Mathews", "France")
            'dt.Rows.Add(4, "Robert Schidner", "Russia")
            all_pengumuman.DataSource = dt
            all_pengumuman.DataBind()
            Me.BindGrid()
            Me.SearchPengumuman()
        End If
    End Sub
    Private Sub SearchPengumuman()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT id_pengumuman, judul_pengumuman, isi_pengumuman, waktu_unggah, file_pengumuman FROM Pengumuman"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE judul_pengumuman LIKE @judul_pengumuman + '%'"
                    cmd.Parameters.AddWithValue("@judul_pengumuman", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    all_pengumuman.DataSource = dt
                    all_pengumuman.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchPengumuman()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        all_pengumuman.PageIndex = e.NewPageIndex
        Me.SearchPengumuman()
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Pengumuman_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT")
                cmd.Parameters.AddWithValue("@id_pengumuman", "")
                cmd.Parameters.AddWithValue("@judul_pengumuman", "")
                cmd.Parameters.AddWithValue("@isi_pengumuman", "")
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Parameters.AddWithValue("@file_pengumuman", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        all_pengumuman.DataSource = dt
                        all_pengumuman.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        all_pengumuman.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        all_pengumuman.EditIndex = -1
        Me.BindGrid()
    End Sub

    Protected Sub OnRowUpdating(sender As Object, e As GridViewUpdateEventArgs)
        Dim row As GridViewRow = all_pengumuman.Rows(e.RowIndex)
        Dim id_pengumuman As Integer = Convert.ToInt32(all_pengumuman.DataKeys(e.RowIndex).Values(0))
        Dim judul As String = TryCast(row.FindControl("txtjudul"), TextBox).Text
        Dim isi As String = TryCast(row.FindControl("txtisi"), TextBox).Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Pengumuman_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "UPDATE")
                cmd.Parameters.AddWithValue("@id_pengumuman", id_pengumuman)
                cmd.Parameters.AddWithValue("@judul_pengumuman", judul)
                cmd.Parameters.AddWithValue("@isi_pengumuman", isi)
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Parameters.AddWithValue("@file_pengumuman", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        all_pengumuman.EditIndex = -1
        Me.BindGrid()
    End Sub

    'Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
    '    If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> all_pengumuman.EditIndex Then
    '        TryCast(e.Row.Cells(2).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
    '    End If
    'End Sub

    Protected Sub OnRowDeleting(sender As Object, e As GridViewDeleteEventArgs)
        Dim id_pengumuman As Integer = Convert.ToInt32(all_pengumuman.DataKeys(e.RowIndex).Values(0))
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Pengumuman_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "DELETE")
                cmd.Parameters.AddWithValue("@id_pengumuman", id_pengumuman)
                cmd.Parameters.AddWithValue("@judul_pengumuman", "")
                cmd.Parameters.AddWithValue("@isi_pengumuman", "")
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Parameters.AddWithValue("@file_pengumuman", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    'Protected Sub all_pengumuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles all_pengumuman.SelectedIndexChanged
    '    Session("id") = all_pengumuman.SelectedRow.Cells(1).Text.ToString
    '    id.Text = Session("id")
    'End Sub
End Class




