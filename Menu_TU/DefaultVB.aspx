<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DefaultVB.aspx.vb" Inherits="DefaultVB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
    runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" ItemStyle-Width="30" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Country" HeaderText="Country" ItemStyle-Width="150" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lnkDetails" runat="server" Text="Send Details" PostBackUrl='<%# "~/DetailsVB.aspx?RowIndex=" & Container.DataItemIndex %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
