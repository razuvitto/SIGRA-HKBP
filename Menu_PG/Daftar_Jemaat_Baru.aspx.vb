Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Daftar_Jemaat_Baru
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Insert()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("daftar_jemaat_baru_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_jemaat", "")
                cmd.Parameters.AddWithValue("@id_sektor", DDWijk.Text)
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@jenis_kelamin", DDKelamin.Text)
                cmd.Parameters.AddWithValue("@tanggal_lahir", txtlahir.Text)
                cmd.Parameters.AddWithValue("@tanggal_baptis", txtbaptis.Text)
                cmd.Parameters.AddWithValue("@tanggal_sidi", txtsidi.Text)
                cmd.Parameters.AddWithValue("@tanggal_meninggal", "")
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
                cmd.Parameters.AddWithValue("@pekerjaan", txtPekerjaan.Text)
                cmd.Parameters.AddWithValue("@tempat_lahir", txtTempatLahir.Text)
                cmd.Parameters.AddWithValue("@no_registrasi", txtnoreg.Text)
                cmd.Parameters.AddWithValue("@nama_keluarga", txtNama.Text)
                cmd.Parameters.AddWithValue("@jumlah_anggota", "")
                cmd.Parameters.AddWithValue("@waktu_registrasi", Date.Now)
                cmd.Parameters.AddWithValue("@status", "Request")
                cmd.Parameters.AddWithValue("@nama_sektor", "")
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Parameters.AddWithValue("@jenis_registrasi", DDJenis_Registrasi.Text)
                cmd.Parameters.AddWithValue("@gereja_asal", txtAsal.Text)
                cmd.Parameters.AddWithValue("@no_telepon", txtTelp.Text)
                cmd.Parameters.AddWithValue("@status_di_keluarga", DropDownList1.Text)
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
End Class