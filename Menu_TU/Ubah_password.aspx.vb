Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class ubah_password
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim dt As New DataTable
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("LoginSP")
        cmd.Parameters.AddWithValue("@username", Session("username"))
        cmd.Parameters.AddWithValue("@password", pdlama.Text)
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        sda.Fill(dt)
        If dt.Rows.Count = 1 Then
            edit_password()
            Response.Redirect("~/Menu_TU/profil.aspx")
        Else
            FailureText.Text = "Password Lama Salah"
            ErrorMessage.Visible = True
        End If
    End Sub
    Private Sub edit_password()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim dt As New DataTable
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("Akun_CRUD")
        cmd.Parameters.AddWithValue("@Action", "UPDATE_PASSWORD_AKUN")
        cmd.Parameters.AddWithValue("@id_akun", Session("id_akun"))
        cmd.Parameters.AddWithValue("@username", "")
        cmd.Parameters.AddWithValue("@password", pdbaru.Text)
        cmd.Parameters.AddWithValue("@email", "")
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        sda.Fill(dt)
    End Sub
    Protected Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        BindGrid()
    End Sub
End Class
