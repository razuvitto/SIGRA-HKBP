
Partial Class DetailsVB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Page.PreviousPage IsNot Nothing Then
            Dim rowIndex As Integer = Integer.Parse(Request.QueryString("RowIndex"))
            Dim GridView1 As GridView = DirectCast(Me.Page.PreviousPage.FindControl("GridView1"), GridView)
            Dim row As GridViewRow = GridView1.Rows(rowIndex)
            lblId.Text = row.Cells(0).Text
            lblName.Text = CType(row.FindControl("lblName"), Label).Text
            lblCountry.Text = row.Cells(2).Text
        End If
    End Sub
End Class
