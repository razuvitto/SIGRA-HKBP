Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Partial Class [default]
    Inherits System.Web.UI.Page
    Protected Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Response.Redirect("konfigurasi.aspx")
    End Sub
End Class
