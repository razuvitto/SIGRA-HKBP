<%@ Page Title="Profil Gereja" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_TU/Site_TU.master" AutoEventWireup="true" CodeFile="~/Menu_TU/Tentang.aspx.vb" Inherits="Tentang" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    
        <div class="jumbotron">







      <%--  <table style="border:none;background-color:#eeeeee">
        <tr>
            <td>--%>

                <asp:GridView ID="tentang1" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <Columns>   
                    <asp:TemplateField HeaderText="Nama Ibadah">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# "Tentang Gereja " + Eval("Nama_Gereja")%>' Font-Bold="true" Font-Underline="true"></asp:Label><br />
                            <asp:Label ID="lbl2" runat="server" Text='<%# Eval("Deskripsi")%>'></asp:Label><br />
                            <%--<asp:Label ID="lblnama" runat="server" Text='<%# If(Eval("Nama_gereja").ToString().Length < 100, "Gereja " + Eval("Nama_gereja").ToString().Substring(0, 100), Eval("Nama_gereja"))%>' Font-Bold="true"></asp:Label> <br />--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>

         <%--<asp:GridView ID="tentang1" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="Nama_gereja"/>
        </Columns>
        </asp:GridView>--%>
       <%--     </td>
        </tr>
        <tr>
            <td>
                Alamat
            </td>
            <td>
                 <asp:GridView ID="tentang2" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="alamat_gereja"/>
        </Columns>
        </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                Distrik
            </td>
            <td>
                <asp:GridView ID="tentang3" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="distrik_gereja"/>
        </Columns>
        </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                No Telepon
            </td>
            <td>
                 <asp:GridView ID="tentang4" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="no_telepon_gereja"/>
        </Columns>
        </asp:GridView>
            </td>
   
        </tr>
        <tr>
            <td>
                Tentang Gereja
            </td>
            <td>
                 <asp:GridView ID="tentang6" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="Nama_gereja"/>
        </Columns>
        </asp:GridView>
            </td>
   
        </tr>
                <tr>
            <td>
                 <asp:GridView ID="Tentang5" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:BoundField DataField="deskripsi"/>
        </Columns>
        </asp:GridView>
            </td>
   
        </tr>
    </table>--%>









       


           

            

           

            
    </div>
        </asp:Content>
