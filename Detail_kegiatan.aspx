﻿<%@ Page Title="Detail_kegiatan" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Detail_kegiatan.aspx.vb" Inherits="Detail_kegiatan" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="jumbotron" style="font-size:medium">
        <table style="border:none">
            <tr>
                <td>
                    <asp:GridView ID="gv" runat="server" ShowHeader="false" BorderStyle="none" Font-Bold="true" Font-Size="X-Large"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
<asp:GridView ID="gv_isi" runat="server" ShowHeader="false" BorderStyle="none"></asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Visible="true" Width="850px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="spasi" runat="server" Visible="true" Width="850px"></asp:Label>
                </td>
                <td>
<asp:GridView ID="gv_waktu" runat="server" ShowHeader="false" BorderStyle="none" Font-Size="small"></asp:GridView>
                </td>
            </tr>

        </table>
        
        
     </div>
</asp:Content>
