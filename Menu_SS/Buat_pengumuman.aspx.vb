Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_pengumuman
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
        Dim isi As String = txtisi.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Pengumuman_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_pengumuman", "")
                cmd.Parameters.AddWithValue("@judul_pengumuman", judul)
                cmd.Parameters.AddWithValue("@file_pengumuman", "")
                cmd.Parameters.AddWithValue("@isi_pengumuman", isi)
                cmd.Parameters.AddWithValue("@waktu_unggah", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
        Server.Transfer("pengumuman.aspx", True)
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

    Protected Sub OnRowDataBound(sender As Object, e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow AndAlso e.Row.RowIndex <> all_pengumuman.EditIndex Then
            TryCast(e.Row.Cells(2).Controls(2), LinkButton).Attributes("onclick") = "return confirm('Do you want to delete this row?');"
        End If
    End Sub

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
    Protected Sub UploadFile(sender As Object, e As EventArgs)
        Dim folderPath As String = Server.MapPath("~/Files/")

        'Check whether Directory (Folder) exists.
        If Not Directory.Exists(folderPath) Then
            'If Directory (Folder) does not exists. Create it.
            Directory.CreateDirectory(folderPath)
        End If

        'Save the File to the Directory (Folder).
        FileUpload.SaveAs(folderPath & Path.GetFileName(FileUpload.FileName))
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("Pengumuman.aspx")
    End Sub

End Class