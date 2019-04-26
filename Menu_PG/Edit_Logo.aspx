<%@ Page Title="Logo Gereja" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Edit_Logo.aspx.vb" Inherits="Edit_Logo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2>
        <br />



    <div>
            <asp:Label ID="lblResult" runat="server"/>
        </div>


    <asp:GridView runat="server" ID="gvProfil" AutoGenerateColumns="false" AllowPaging="True"
                OnRowCancelingEdit="gvImage_RowCancelingEdit" DataKeyNames="id_gereja" CellPadding="4"
                OnRowEditing="gvImage_RowEditing" OnRowUpdating="gvImage_RowUpdating" OnRowDeleting="gvImage_RowDeleting" HeaderStyle-BackColor="Tomato" BorderStyle="none">
                <Columns>
                    <%--<asp:TemplateField HeaderText="ID" HeaderStyle-Width="200px" >
                        <ItemTemplate>
                            <asp:Label ID="lblImgId" runat="server" Text='<%#Container.DataItemIndex+1%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                    <asp:TemplateField HeaderText="Nama File" HeaderStyle-Width="300px">
                        <ItemTemplate>
                            <asp:Label ID="lblnama_gereja" runat="server" Text='<%# Eval("logo_gereja") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_Nama_gereja" runat="server" Text='<%# Eval("logo_gereja") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Logo" HeaderStyle-Width="300px">
                        <ItemTemplate>
                            <asp:Image ID="Logo" runat="server" ImageUrl='<%# Eval("path") %>'
                                Height="100px" Width="120px" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Image ID="img_logo" runat="server" ImageUrl='<%# Eval("path") %>'
                                Height="100px" Width="120px" /><br />
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderStyle-Width="200px" HeaderText="Aksi">
                        <ItemTemplate>
                            <asp:LinkButton ID="LkB1" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                            <asp:LinkButton ID="LkB11" runat="server" CommandName="Delete"></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton ID="LkB2" runat="server" CommandName="Update">Update</asp:LinkButton>
                            <asp:LinkButton ID="LkB3" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
    <br />
     <asp:Button ID="kembali" runat="server" Text="Kembali" PostBackUrl="~/Menu_PG/edit_profil_gereja.aspx" class="btn btn-primary"/>
   
</div>
        <br />
    
</asp:Content>