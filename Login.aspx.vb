Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web.Security
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Session("username") = "" Then
            Response.Redirect("~/Menu_Bendahara/index.aspx")
        End If
    End Sub
    Private Sub BindGrid()
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Dim dt As New DataTable
        Dim con As New SqlConnection(constr)
        Dim cmd As New SqlCommand("LoginSP")
        cmd.Parameters.AddWithValue("@username", UserName.Text)
        cmd.Parameters.AddWithValue("@password", Password.Text)
        Dim sda As New SqlDataAdapter()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = con
        sda.SelectCommand = cmd
        sda.Fill(dt)
        If dt.Rows.Count > 0 Then
            Session("username") = dt.Rows(0)(0)
            Session("id_role") = dt.Rows(0)(2)
            Session("id_akun") = dt.Rows(0)(3)
        Else
            FailureText.Text = "Username atau Password Salah"
            ErrorMessage.Visible = True
        End If
    End Sub
    Protected Sub buat_kegiatan_Click(sender As Object, e As EventArgs) Handles buat_kegiatan.Click
        BindGrid()
        If Session("id_role") = 1 Then
            Response.Redirect("~/Menu_TU/index_TU.aspx")
        ElseIf Session("id_role") = 2 Then
            Response.Redirect("~/Menu_Bendahara/index.aspx")
        ElseIf Session("id_role") = 3 Then
            Response.Redirect("~/Menu_SS/Index_SS.aspx")
        ElseIf Session("id_role") = 4 Then
            Response.Redirect("~/Menu_PG/Index_PG.aspx")
        End If
    End Sub
End Class
