Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Jemaat_Anak_Lahir
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'Me.BindGrid()
        End If
    End Sub

    'Private Sub BindGrid()
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("anak_lahir_CRUD")
    '            cmd.Parameters.AddWithValue("@Action", "SELECT")
    '            cmd.Parameters.AddWithValue("@id_gereja", "")
    '            cmd.Parameters.AddWithValue("@nama_gereja", "")
    '            cmd.Parameters.AddWithValue("@alamat_gereja", "")
    '            cmd.Parameters.AddWithValue("@distrik_gereja", "")
    '            cmd.Parameters.AddWithValue("@no_telepon_gereja", "")
    '            cmd.Parameters.AddWithValue("@logo_gereja", "")
    '            cmd.Parameters.AddWithValue("@path", "")
    '            cmd.Parameters.AddWithValue("@wallpaper_gereja", "")
    '            cmd.Parameters.AddWithValue("@path_wallpaper", "")
    '            cmd.Parameters.AddWithValue("@deskripsi", "")
    '            cmd.Parameters.AddWithValue("@waktu_konfigurasi", "")
    '            Using sda As New SqlDataAdapter()
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dt As New DataTable()
    '                    sda.Fill(dt)
    '                    anak_lahir.DataSource = dt
    '                    anak_lahir.DataBind()
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Sub
    Private Sub Insert()
        Dim nama As String = txtNama.Text
        Dim tanggal As String = txtDate.Text
        Dim tempat As String = txttempat.Text
        Dim kelamin As String = txtkelamin.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("anak_lahir_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_jemaat", "")
                cmd.Parameters.AddWithValue("@nama_jemaat", nama)
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal)
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat)
                cmd.Parameters.AddWithValue("@jenis_kelamin", kelamin)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        'Me.BindGrid()
    End Sub
    Protected Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Insert()
        Response.Redirect("Index.aspx")
    End Sub
End Class
