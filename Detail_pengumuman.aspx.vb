Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class Detail_pengumuman
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BindGrid()
        Me.BindGrid2()
        Me.BindGrid3()
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("Pengumuman_CRUD")
        cmd.Parameters.AddWithValue("@Action", "Judul")
        cmd.Parameters.AddWithValue("@id_pengumuman", Session("select_pengumuman"))
        cmd.Parameters.AddWithValue("@judul_pengumuman", "")
        cmd.Parameters.AddWithValue("@isi_pengumuman", "")
        cmd.Parameters.AddWithValue("@file_pengumuman", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv.DataSource = dt
        gv.DataBind()
    End Sub
    Private Sub BindGrid2()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("Pengumuman_CRUD")
        cmd.Parameters.AddWithValue("@Action", "Isi")
        cmd.Parameters.AddWithValue("@id_pengumuman", Session("select_pengumuman"))
        cmd.Parameters.AddWithValue("@judul_pengumuman", "")
        cmd.Parameters.AddWithValue("@isi_pengumuman", "")
        cmd.Parameters.AddWithValue("@file_pengumuman", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv_isi.DataSource = dt
        gv_isi.DataBind()
    End Sub
    Private Sub BindGrid3()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("Pengumuman_CRUD")
        cmd.Parameters.AddWithValue("@Action", "waktu")
        cmd.Parameters.AddWithValue("@id_pengumuman", Session("select_pengumuman"))
        cmd.Parameters.AddWithValue("@judul_pengumuman", "")
        cmd.Parameters.AddWithValue("@isi_pengumuman", "")
        cmd.Parameters.AddWithValue("@file_pengumuman", "")
        cmd.Parameters.AddWithValue("@waktu_unggah", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        Dim dt As New DataTable()
        sda.Fill(dt)
        gv_waktu.DataSource = dt
        gv_waktu.DataBind()
    End Sub
End Class




