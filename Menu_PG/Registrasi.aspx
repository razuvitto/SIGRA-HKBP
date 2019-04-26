<%@ Page Title="Registrasi" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Registrasi.aspx.vb" Inherits="Registrasi" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <br />      
            <center><div  class="jumbotron" style="width:700px; font-size:medium">
                <center><table style="border:none">
        <tr>
            <td>
            </td>
            <td>
                <center><asp:Label runat="server" ID="lblregistrasi" Text="REGISTRASI" Font-Bold="true" Font-Size="X-Large"></asp:Label>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                Username
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-prime" />
            </td>
            <td >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="*Harap isi bidang ini" ForeColor="Red" ControlToValidate="txtUsername"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Password
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-prime"/>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="*Harap isi bidang ini" ForeColor="Red" ControlToValidate="txtPassword"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Confirm Password
            </td>
            <td>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-prime"/>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" ErrorMessage="Password tidak sesuai." ForeColor="Red" ControlToCompare="txtPassword"
                    ControlToValidate="txtConfirmPassword" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-prime"/>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ErrorMessage="*Harap isi bidang ini" Display="Dynamic" ForeColor="Red"
                    ControlToValidate="txtEmail" runat="server" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Email tidak sesuai." />
            </td>
        </tr>
                    <tr>
            <td>
                Role
            </td>
            <td>
                <asp:DropDownList ID="DDRole" runat="server" DataSourceID="SqlDataSource1" DataTextField="deskripsi" DataValueField="id_role" CssClass="form-prime" Width="196px"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [Role]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ErrorMessage="*Harap isi bidang ini" ForeColor="Red" ControlToValidate="txtPassword"
                    runat="server" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <center><asp:Button ID="btnSubmit" Text="Submit" runat="server" CssClass="btn btn-prime"/>
            </td>
            <td>
            </td>
        </tr>
    </table></center>
                </div>
</asp:Content>
