<%@ Page Title="Profil_Gereja" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Profil_Gereja.aspx.vb" Inherits="Profil_Gereja" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="konfigurasi" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." >
    </asp:GridView>
    <center><div class="jumbotron" style="width:550px;align-content:center">
    <table align="center" border="0" style="border-spacing: 0px; border-color: #EEEEEE">
    <h2><%: Title %></h2>       
  <tr>
    <td>Nama Gereja</td>
    <td><asp:TextBox runat="server" ID="txtNama" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>Alamat Gereja</td>
    <td><asp:TextBox runat="server" ID="txtAlamat" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>Distrik</td>
    <td><asp:TextBox runat="server" ID="txtDistrik" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>No Telepon</td>
    <td><asp:TextBox runat="server" ID="txtTelepon" CssClass="form-control" Width="255px" /></td>
  </tr>
  <tr>
    <td>Foto</td>
    <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
  </tr>          
  </table>
    <asp:Button ID="btnBatal" runat="server" Text="Batal" CssClass="btn btn-primary" />
    <asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" />
        <br />
    </div>
</asp:Content>
