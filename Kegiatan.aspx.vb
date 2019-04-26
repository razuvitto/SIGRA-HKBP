Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Kegiatan
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not Me.IsPostBack Then
            Dim dt As DataTable = New DataTable()
            dt.Columns.AddRange(New DataColumn(2) {New DataColumn("Id_kegiatan"), New DataColumn("Judul"), New DataColumn("deskripsi")})
            all_kegiatan.DataSource = dt
            all_kegiatan.DataBind()
            Me.BindGrid()
            Me.SearchPengumuman()
        End If
    End Sub
    Private Sub SearchPengumuman()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand()
                Dim sql As String = "SELECT Id_kegiatan, judul, deskripsi, waktu_unggah FROM kegiatan"
                If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                    sql += " WHERE judul LIKE @judul + '%'"
                    cmd.Parameters.AddWithValue("@judul", txtSearch.Text.Trim())
                End If
                cmd.CommandText = sql
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    sda.Fill(dt)
                    all_kegiatan.DataSource = dt
                    all_kegiatan.DataBind()
                End Using
            End Using
        End Using
    End Sub
    Protected Sub Search(sender As Object, e As EventArgs)
        Me.SearchPengumuman()
    End Sub

    Protected Sub OnPaging(sender As Object, e As GridViewPageEventArgs)
        all_kegiatan.PageIndex = e.NewPageIndex
        Me.SearchPengumuman()
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
                        all_kegiatan.DataSource = dt
                        all_kegiatan.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Protected Sub OnRowEditing(sender As Object, e As GridViewEditEventArgs)
        all_kegiatan.EditIndex = e.NewEditIndex
        Me.BindGrid()
    End Sub

    Protected Sub OnRowCancelingEdit(sender As Object, e As EventArgs)
        all_kegiatan.EditIndex = -1
        Me.BindGrid()
    End Sub
End Class




