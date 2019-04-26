<%@ Page Title="Profil" Language="VB" MasterPageFile="~/Menu_TU/Site_TU.master" AutoEventWireup="true" CodeFile="~/Menu_TU/Profil.aspx.vb" Inherits="profil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
    <div class="jumbotron" style="font-size:medium">
         <asp:GridView ID="gv_username" runat="server" AutoGenerateColumns="false" DataKeyNames="id_akun" BorderColor="Transparent">
        <Columns>
            <asp:TemplateField HeaderText="Username" ItemStyle-Width="600" HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblemail" runat="server" Text='<%# Eval("username") %>'></asp:Label>
                </ItemTemplate>
                          
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
        <asp:GridView ID="akun" runat="server" AutoGenerateColumns="false" DataKeyNames="id_akun" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
                OnRowUpdating="OnRowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="Email" ItemStyle-Width="450" HeaderStyle-BackColor="Transparent">
                <ItemTemplate>
                    <asp:Label ID="lblusername" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtemail" runat="server" Text='<%# Eval("email") %>'></asp:TextBox>
                </EditItemTemplate>  
                
            </asp:TemplateField>
            <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="false" HeaderText="Aksi" ItemStyle-Width="150" HeaderStyle-BackColor="Transparent"/>
        </Columns>
    </asp:GridView>
        <br />
   <asp:Button ID="ubah_password" runat="server" Text="Ubah Password" PostBackUrl="~/Menu_TU/ubah_password.aspx" class="btn btn-primary"/>
        </div>
        <br />

</div>
        <br />
</asp:Content>
