<%@ Page Language="VB" AutoEventWireup="false" EnableEventValidation="false" CodeFile="TestUnit.aspx.vb" Inherits="Test_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="position:center;margin-top:auto;margin-left:20px;margin-right:20px">
        Search By:
    <asp:DropDownList ID="ddlSearchBy" runat="server" AutoPostBack="true" onselectedindexchanged="ddlSearchBy_SelectedIndexChanged">
        <asp:ListItem Text="All"></asp:ListItem>
    </asp:DropDownList><br />
    <asp:TextBox ID="searchValue" runat="server"></asp:TextBox>
    <asp:Button ID="searchBtn" runat="server" Text="Search" onclick="searchBtn_Click" />
    <asp:Button ID="clear" runat="server" Text="X" OnClick="clear_Click" />
    <asp:GridView ID="CustGrid" runat="server"
     Width="640px"
    AllowSorting="True" OnSorting="CustGrid_OnSorting"
    OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged"  
    AllowPaging="True" PageSize="5" OnPageIndexChanging="CustGrid_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
<asp:TextBox ID="test" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
