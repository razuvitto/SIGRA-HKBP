Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Partial Class Buat_jadwal_ibadah
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
                        jadwal_ibadah.DataSource = dt
                        jadwal_ibadah.DataBind()
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
        Dim nama As String = txtnama.Text
        Dim isi As String = txtisi.Text
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Jadwal_CRUD")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Action", "INSERT_JADWAL")
                cmd.Parameters.AddWithValue("@id_jadwal", "")
                cmd.Parameters.AddWithValue("@nama_ibadah", nama)
                cmd.Parameters.AddWithValue("@deskripsi", isi)
                cmd.Parameters.AddWithValue("@waktu_unggah_jadwal", "")
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Me.BindGrid()
        'Server.Transfer("pengumuman.aspx", True)
    End Sub
    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Insert()
        Response.Redirect("~/Menu_TU/Jadwal_ibadah.aspx")
    End Sub
End Class