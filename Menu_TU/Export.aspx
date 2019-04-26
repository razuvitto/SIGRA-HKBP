<%@ Page Title="Export" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Export.aspx.vb" Inherits="Export" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head runat="server">
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
    <asp:GridView ID="all_pengumuman" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
        RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
        runat="server" AutoGenerateColumns="false" AllowPaging="true" OnPageIndexChanging="OnPageIndexChanging">
        <Columns>
            <asp:BoundField DataField="judul_pengumuman" HeaderText="Judul" ItemStyle-Width="150px" />
            <asp:BoundField DataField="waktu_unggah" HeaderText="Waktu" ItemStyle-Width="100px" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnExport" runat="server" Text="Export To PDF" OnClick = "ExportToPDF" />
    </form>
</body>
</html>


</asp:Content>
