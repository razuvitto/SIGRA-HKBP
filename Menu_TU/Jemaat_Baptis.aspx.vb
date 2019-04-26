Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Jemaat_Baptis
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
            Using cmd As New SqlCommand("Jadwal_CRUD")
                cmd.Parameters.AddWithValue("@Action", "SELECT_JADWAL")
                cmd.Parameters.AddWithValue("@id_Jadwal", "")
                cmd.Parameters.AddWithValue("@nama_ibadah", "")
                cmd.Parameters.AddWithValue("@deskripsi", "")
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        pendataan_jemaat.DataSource = dt
                        pendataan_jemaat.DataBind()
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

    Protected Sub Insert()
        Dim no_registrasi As String = txtnoreg.Text
        Dim sektor As String = DDWijk.Text
        Dim nama_jemaat As String = txtNamapria.Text

        Dim jenis_kelamin_jemaat As String = DDKelamin.Text

        Dim tempat_lahir As String = txtTempatLahirPria.Text

        Dim tanggal_lahir As String = txtDatePria.Text


        Dim alamat As String = txtAlamatPria.Text

        Dim pekerjaan As String = txtPekerjaanPria.Text

        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Jemaat_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT")
                cmd.Parameters.AddWithValue("@id_Keluarga", "")
                cmd.Parameters.AddWithValue("@no_registrasi", no_registrasi)
                cmd.Parameters.AddWithValue("@waktu_registrasi", "")
                cmd.Parameters.AddWithValue("@nama_keluarga", nama_jemaat)
                cmd.Parameters.AddWithValue("@id_sektor", "")
                cmd.Parameters.AddWithValue("@nama_sektor", sektor)
                cmd.Parameters.AddWithValue("@jumlah_jemaat", "")
                cmd.Parameters.AddWithValue("@id_jemaat", "")
                cmd.Parameters.AddWithValue("@nama_jemaat", nama_jemaat)
                cmd.Parameters.AddWithValue("@jenis_kelamin_jemaat", jenis_kelamin_jemaat)
                cmd.Parameters.AddWithValue("@tempat_lahir", tempat_lahir)
                cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal_lahir)
                cmd.Parameters.AddWithValue("@tanggal_meninggal", "")
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@pekerjaan", pekerjaan)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("index.aspx")
    End Sub
End Class