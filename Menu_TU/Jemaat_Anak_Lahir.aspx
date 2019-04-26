<%@ Page Title="Anak Lahir" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Jemaat_Anak_Lahir.aspx.vb" Inherits="Jemaat_Anak_Lahir" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
    <%--<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />--%>
     <script src="Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtDate]").datepicker({
                showOn: "focus"
            });
        });
    </script>

<body>
   
  <asp:GridView ID="anak_lahir" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja">
    </asp:GridView>
   <div class="jumbotron">
       <h2><%: Title %></h2> 
    <table border="0" style="border-spacing: 0px; border-color: #EEEEEE">
          
  <tr>
    <td>Nama Anak Lahir</td>
    <td><asp:TextBox runat="server" ID="txtNama" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>Tanggal Lahir</td>
    <td><asp:TextBox ID="txtDate" runat="server" CssClass="form-control" Width="255px"></asp:TextBox></td>
  </tr>
  <tr>
    <td>Tempat Lahir</td>
    <td><asp:TextBox runat="server" ID="txttempat" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>Jenis Kelamin</td>
    <td><asp:TextBox runat="server" ID="txtkelamin" CssClass="form-control" Width="255px" /></td>
  </tr>
  </table>
     <asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" />
   
</body>
</html>



  
</asp:Content>
