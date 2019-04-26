Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Daftar_Jemaat_Baru
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Insert()
        Dim no_registrasi As String = txtnoreg.Text
        Dim sektor As String = DDWijk.Text
        Dim jenis_registrasi As String = DDJenis_Registrasi.Text
        Dim gereja_asal As String = txtAsal.Text
        Dim nama_jemaat As String = txtNama.Text
        Dim tanggal_lahir As String = txtDate.Text
        Dim tempat_lahir As String = txtTempatLahir.Text
        Dim jenis_kelamin_jemaat As String = DDKelamin.Text
        Dim no_telepon As String = txtTelp.Text
        Dim pekerjaan As String = txtPekerjaan.Text
        Dim alamat As String = txtAlamat.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("daftar_jemaat_baru_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_jemaat", "")
                cmd.Parameters.AddWithValue("@no_registrasi", no_registrasi)
                cmd.Parameters.AddWithValue("@sektor", sektor)
                'cmd.Parameters.AddWithValue("@id_sektor", "")
                cmd.Parameters.AddWithValue("@jenis_registrasi", jenis_registrasi)
                cmd.Parameters.AddWithValue("@gereja_asal", gereja_asal)
                cmd.Parameters.AddWithValue("@nama_jemaat", nama_jemaat)
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal_lahir)
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat_lahir)
                cmd.Parameters.AddWithValue("@jenis_kelamin_jemaat", jenis_kelamin_jemaat)
                cmd.Parameters.AddWithValue("@no_telepon", no_telepon)
                cmd.Parameters.AddWithValue("@pekerjaan", pekerjaan)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@jabatan", "Kepala Keluarga")
                cmd.Parameters.AddWithValue("@status", "Request")
                cmd.Parameters.AddWithValue("@waktu_mendaftar", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("jemaat_jemaatbaru.aspx")
    End Sub

    'Protected Sub DDWijk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDWijk.SelectedIndexChanged
    '    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
    '    Dim sda As New SqlDataAdapter()
    '    Dim dt As New DataTable
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("daftar_jemaat_baru_CRUD")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Parameters.AddWithValue("@Action", "get_id")
    '            cmd.Parameters.AddWithValue("@no_registrasi", "")
    '            cmd.Parameters.AddWithValue("@sektor", DDWijk.SelectedValue)
    '            cmd.Parameters.AddWithValue("@id_sektor", "")
    '            cmd.Parameters.AddWithValue("@jenis_registrasi", "")
    '            cmd.Parameters.AddWithValue("@gereja_asal", "")
    '            cmd.Parameters.AddWithValue("@nama_jemaat", "")
    '            cmd.Parameters.AddWithValue("@tanggal_lahir", "")
    '            cmd.Parameters.AddWithValue("@tempat_lahir", "")
    '            cmd.Parameters.AddWithValue("@jenis_kelamin_jemaat", "")
    '            cmd.Parameters.AddWithValue("@no_telepon", "")
    '            cmd.Parameters.AddWithValue("@pekerjaan", "")
    '            cmd.Parameters.AddWithValue("@alamat", "")
    '            cmd.Parameters.AddWithValue("@jabatan", "")
    '            cmd.Parameters.AddWithValue("@status", "")
    '            cmd.Parameters.AddWithValue("@waktu_mendaftar", "")
    '            cmd.Connection = con
    '            con.Open()
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '        End Using
    '    End Using
    '    sda.Fill(dt)
    '    id_sektor.Text = dt.Rows(0)(0)
    'End Sub
End Class