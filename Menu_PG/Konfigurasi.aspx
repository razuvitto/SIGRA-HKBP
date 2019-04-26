<%@ Page Title="Konfigurasi" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site_konfigurasi.Master" AutoEventWireup="true" CodeFile="Konfigurasi.aspx.vb" Inherits="Konfigurasi" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="konfigurasi" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting">
    </asp:GridView>
    <center><div class="jumbotron" style="width:700px;align-content:center">
    <table align="center" border="0" style="border-spacing: 0px; border-color: #EEEEEE">
    <h2><%: Title %></h2>       
    <hr style="width:auto" />
  <tr>
    <td>Nama Gereja</td>
    <td><asp:TextBox runat="server" ID="txtNama" CssClass="form-control" Width="255px" /></td>
    <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnama" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
  </tr>
  <tr>
    <td>Alamat Gereja</td>
    <td><asp:TextBox runat="server" ID="txtAlamat" CssClass="form-control" Width="255px" /></td>
      <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtalamat" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
  </tr>
  <tr>
    <td>Distrik</td>
    <td><asp:TextBox runat="server" ID="txtDistrik" CssClass="form-control" Width="255px" /></td>
      <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdistrik" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
  </tr>
  <tr>
    <td>No Telepon</td>
    <td><asp:TextBox runat="server" ID="txtTelepon" CssClass="form-control" Width="255px" /></td>
  </tr>
        <tr>
    <td>Tentang Gereja</td>
    <td><asp:TextBox runat="server" ID="txtTentang" CssClass="form-control" Width="255px" /></td>
            <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="txttentang" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
  </tr>
  <tr>
    <td>Logo Gereja</td>
    <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
      <td> <asp:RequiredFieldValidator runat="server" ControlToValidate="fileupload1" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
  </tr>            
  </table>
    <asp:Button ID="btnSimpan" runat="server" Text="Simpan" CssClass="btn btn-primary" />
        <br />
    </div>
</asp:Content>
