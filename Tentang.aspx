<%@ Page Title="Profil Gereja" Language="VB" MasterPageFile="Site_Unregist.master" AutoEventWireup="true" CodeFile="Tentang.aspx.vb" Inherits="Tentang" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>  
        <div class="jumbotron">
                <asp:GridView ID="tentang1" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <Columns>   
                    <asp:TemplateField HeaderText="Nama Ibadah">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Text='<%# "Tentang Gereja " + Eval("Nama_Gereja")%>' Font-Bold="true" Font-Underline="true"></asp:Label><br />
                            <asp:Label ID="lbl2" runat="server" Text='<%# Eval("Deskripsi")%>'></asp:Label><br />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>           
    </div>
</asp:Content>
