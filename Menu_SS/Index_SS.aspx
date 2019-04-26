<%@ Page Title="Index" Language="VB" EnableEventValidation="false" MasterPageFile="~/Menu_SS/Site_SS.master" AutoEventWireup="true" CodeFile="~/Menu_SS/Index_SS.aspx.vb" Inherits="Index_SS" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--<img src="images/lib2.jpg" width="1170" style="align-content:center; align-items:center"/>--%>
<div class="jumbotron">
    <div Class="row">
    <div Class="col-md-4">
       <center><asp:GridView ID="gvimgbrand" runat="server" AutoGenerateColumns="false" ShowHeader="false" BorderStyle="none">
        <Columns>
            <asp:ImageField DataImageUrlField="Path" HeaderText="Logo" ControlStyle-Width="130" ControlStyle-Height="145"/>
        </Columns>
        </asp:GridView>
        </div>
    <div Class="col-md-8">
        
        <h1>SELAMAT DATANG</h1>
        <asp:GridView ID="gvwelcome" runat="server" AutoGenerateColumns="false" DataKeyNames="id_gereja" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <Columns>   
                    <asp:TemplateField HeaderText="Header">
                        <ItemTemplate>
                            <asp:Label ID="lbl1" runat="server" Font-Bold="true" Text='<%# "Sistem Informasi Gereja " + Eval("Nama_Gereja")%>'></asp:Label><br />    
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
    </div>
    </div>
    </div>
<div Class="row">
    <div Class="col-md-4">
        <div Class="jumbotron">
        <h2 style = "font-size:25px;text-align:center" > JADWAL IBADAH</h2>
            <asp:GridView ID="jadwal" runat="server" AutoGenerateColumns="false" DataKeyNames="id_jadwal" BackColor="Transparent" BorderColor="Transparent" ShowHeader="false" ControlStyle-Font-Size="medium">
                <Columns>   
                    <asp:TemplateField HeaderText="Nama Ibadah">
                        <ItemTemplate>
                            <asp:label ID="lblnama" runat="server" Text='<%# If(Eval("Nama_Ibadah").ToString().Length > 40, Eval("Nama_Ibadah").ToString().Substring(0, 40) + "...", Eval("Nama_Ibadah"))%>' Font-Bold="true"></asp:label> <br />
                            <asp:Label ID="lbldeskripsi" runat="server" Text='<%# If(Eval("Deskripsi").ToString().Length > 40, Eval("Deskripsi").ToString().Substring(0, 40) + "...", Eval("Deskripsi"))%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle BorderStyle="None" />      
            </asp:GridView>
        </div>
    </div>
    <div Class="col-md-4">
        <div Class="jumbotron">
         <h2 style = "font-size:25px;text-align:center" > PENGUMUMAN</h2>
             <asp:GridView ID="CustGrid" runat="server" Width="250px" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged" ShowHeader="false" Font-Size="medium"
            AllowPaging="True" PageSize="5" CellPadding="4" ForeColor="#fff" GridLines="None" BorderStyle="none">
        <AlternatingRowStyle BackColor="Transparent" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="#ffffff" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="Transparent" />
        <SelectedRowStyle BackColor="#e6e6e6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    </div>
    </div>
    <div Class="col-md-4">
        <div Class="jumbotron">
            <h2 style = "font-size:25px;text-align:center" > KEGIATAN YANG AKAN DATANG</h2>
            <asp:GridView ID="Custgrid2" runat="server" Width="250px" OnRowDataBound="OnRowDataBound2" OnSelectedIndexChanged="OnSelectedIndexChanged2" ShowHeader="false" Font-Size="medium"
            AllowPaging="True" PageSize="5" CellPadding="4" ForeColor="#fff" GridLines="None" BorderStyle="none">
        <AlternatingRowStyle BackColor="Transparent" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="#ffffff" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="Transparent" />
        <SelectedRowStyle BackColor="#e6e6e6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
        </div>
    </div>
</div>

</asp:Content>
