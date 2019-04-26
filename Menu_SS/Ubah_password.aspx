<%@ Page Title="Ubah Password" Language="VB" MasterPageFile="~/Menu_SS/Site_SS.master" AutoEventWireup="true" CodeFile="~/Menu_SS/Ubah_password.aspx.vb" Inherits="ubah_password" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
    <div class="jumbotron" style="font-size:medium">
        <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
        <table style="border:none">
            <tr>
                <td>
                    <asp:TextBox ID="pdlama" runat="server" placeholder="Password Lama" CssClass="form-control"  Width="700px"></asp:TextBox> 
                </td>
                <td><asp:RequiredFieldValidator runat="server" ControlToValidate="pdlama" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="pdbaru" runat="server" placeholder="Password Baru" CssClass="form-control"  Width="700px"></asp:TextBox> 
                </td>
                <td><asp:RequiredFieldValidator runat="server" ControlToValidate="pdbaru" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="confirmpdbaru" runat="server" placeholder="Ulangi Password Baru" CssClass="form-control"  Width="700px"></asp:TextBox> 
                </td>
                <td><asp:RequiredFieldValidator runat="server" ControlToValidate="confirmpdbaru" CssClass="text-danger" ErrorMessage="* Harap isi bidang ini" Font-size="Small" /></td>
            </tr>
            <tr>
                <td>
                     <asp:Button ID="simpan" runat="server" Text="Ubah" class="btn btn-primary"/> 
                </td>
            </tr>

        </table>
      
        </div>
</div>
        <br />
</asp:Content>
