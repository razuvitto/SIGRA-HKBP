<%@ Page Language="VB" AutoEventWireup="false" EnableEventValidation="false" CodeFile="DetailsVB.aspx.vb" Inherits="DetailsVB" %>

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
    <table>
        <tr>
            <td>
                <b>Id</b>
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <b>Name</b>
            </td>
            <td>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td>
                <b>Country</b>
            </td>
            <td>
                <asp:Label ID="lblCountry" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
