<%@ Page Title="Konfigurasi Sektor" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Konfigurasi_Sektor.aspx.vb" Inherits="Konfigurasi_sektor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="sektor" runat="server" AutoGenerateColumns="false" DataKeyNames="id_sektor"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting">
    </asp:GridView>
    <center><div class="jumbotron" style="width:550px;align-content:center">
    <table align="center" border="0" style="border-spacing: 0px; border-color: #EEEEEE">
    <h2><%: Title %></h2>       
    <br />
  <tr>
    <td>Nama Sektor</td>
    <td><asp:TextBox runat="server" ID="txtNama" CssClass="form-control" Width="255px" /></td>
  </tr>
<%--  <tr>
    <td>Jumlah Jemaat</td>
    <td><asp:TextBox runat="server" ID="txtAlamat" CssClass="form-control" Width="255px" type="number" min="1"/></td>
  </tr> --%>        
  </table>
    <asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" />
        <br />
    </div>
        
</asp:Content>
