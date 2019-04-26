Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Jemaat_Tambah_data
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
        End If
    End Sub

    Protected Sub Insert()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Input_JemaatBaru")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INPUT")
                cmd.Parameters.AddWithValue("@id_jemaat", "")
                cmd.Parameters.AddWithValue("@id_keluarga", "")
                cmd.Parameters.AddWithValue("@id_sektor", "")
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@jenis_kelamin", DDKelamin1.Text)
                cmd.Parameters.AddWithValue("@tanggal_lahir", txtDatelahir.Text)
                cmd.Parameters.AddWithValue("@tanggal_baptis", txtDatebaptis.Text)
                cmd.Parameters.AddWithValue("@tanggal_sidi", txtDatesidi.Text)
                cmd.Parameters.AddWithValue("@tanggal_meninggal", "")
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
                cmd.Parameters.AddWithValue("@pekerjaan", txtPekerjaan.Text)
                cmd.Parameters.AddWithValue("@tempat_lahir", txtTempatLahir.Text)
                cmd.Parameters.AddWithValue("@no_registrasi", txtnoreg.Text)
                cmd.Parameters.AddWithValue("@nama_keluarga", txtNama.Text)
                cmd.Parameters.AddWithValue("@jumlah_anggota", "")
                cmd.Parameters.AddWithValue("@waktu_registrasi", Date.Now)
                cmd.Parameters.AddWithValue("@status", "Accepted")
                cmd.Parameters.AddWithValue("@nama_sektor", DDWijk.Text)
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Parameters.AddWithValue("@jenis_registrasi", DDJenis_Registrasi.Text)
                cmd.Parameters.AddWithValue("@gereja_asal", txtAsal.Text)
                cmd.Parameters.AddWithValue("@no_telepon", txtTelp.Text)
                cmd.Parameters.AddWithValue("@pendeta_baptis", txt_pendetabaptis.Text)
                cmd.Parameters.AddWithValue("@pendeta_sidi", txt_pendetasidi.Text)
                cmd.Parameters.AddWithValue("@terlaksana_baptis", "Terlaksana")
                cmd.Parameters.AddWithValue("@terlaksana_sidi", "Terlaksana")
                cmd.Parameters.AddWithValue("@nama_gereja_baptis", txt_namagerejabaptis.Text)
                cmd.Parameters.AddWithValue("@nama_gereja_sidi", txt_namagerejasidi.Text)
                cmd.Parameters.AddWithValue("@status_di_keluarga", DDStatus.Text)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("~/Menu_TU/Jemaat_PendataanJemaat.aspx")
    End Sub
End Class