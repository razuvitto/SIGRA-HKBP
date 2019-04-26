Imports System.Data

Partial Class DefaultVB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim dt As New DataTable()
            dt.Columns.AddRange(New DataColumn(2) {New DataColumn("Id"), New DataColumn("Name"), New DataColumn("Country")})
            dt.Rows.Add(1, "John Hammond", "United States")
            dt.Rows.Add(2, "Mudassar Khan", "India")
            dt.Rows.Add(3, "Suzanne Mathews", "France")
            dt.Rows.Add(4, "Robert Schidner", "Russia")
            GridView1.DataSource = dt
            GridView1.DataBind()
        End If
    End Sub
End Class
