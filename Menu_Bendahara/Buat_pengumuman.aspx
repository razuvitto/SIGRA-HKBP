<%@ Page Title="Buat Pengumuman" Language="VB" MasterPageFile="~/Menu_Bendahara/Site_Bendahara.master" AutoEventWireup="true" CodeFile="~/Menu_Bendahara/Buat_pengumuman.aspx.vb" Inherits="Buat_pengumuman" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>

    <asp:GridView ID="all_pengumuman" runat="server" AutoGenerateColumns="false" DataKeyNames="id_pengumuman"
        OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
        OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" >
    </asp:GridView>

    <div Class="row">
        <div Class="jumbotron">
            <p>
                <asp:Label ID="lbljudul" runat="server" Text="Judul"></asp:Label>
            </p>     
            <p>
                <asp:TextBox ID="txtjudul" runat="server" CssClass="form-control"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="lblisi" runat="server" Text="Deskripsi"></asp:Label>
                
            </p>
            <p>                
                <CKEditor:CKEditorControl ID="txtisi" BasePath="/ckeditor/" runat="server">
                </CKEditor:CKEditorControl>   
            </p> 
            <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Publish"/>        
        </div>   
    </div>
</asp:Content>
