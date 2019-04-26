
Imports System.Data
Imports System.Data.SqlClient

Partial Class login_baru
    Inherits System.Web.UI.Page

    Protected Sub LogIn(sender As Object, e As EventArgs)
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("Validate_User")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Username", Login1.UserName)
                cmd.Parameters.AddWithValue("@Password", Login1.Password)
                Using sda As New SqlDataAdapter()
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                    End Using
                End Using
                End Using
        End Using
    End Sub

    Private Sub checkRole(role As String)
        If role = "Sales" Then
            SalesForm.Show()
        ElseIf role = "Inventory" Then
            InventoryForm.Show()
        ElseIf role = "Produksi" Then
            ProductionForm.Show()
        ElseIf role = "Finance" Then
            FinanceForm.Show()
        End If
    End Sub
End Class
