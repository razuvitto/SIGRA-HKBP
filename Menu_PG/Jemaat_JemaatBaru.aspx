<%@ Page Title="Input Data Keluarga" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Jemaat_JemaatBaru.aspx.vb" Inherits="Jemaat_JemaatBaru" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<div Class="row">
    <h2><%: Title %></h2> 
    <br />
        <asp:Button ID="buat_kegiatan" runat="server" Text="Pendaftaran Jemaat Baru" PostBackUrl="~/Menu_TU/Daftar_Jemaat_Baru.aspx" class="btn btn-primary"/>
    <asp:Button ID="Button1" runat="server" Text="Pendaftaran Keluarga" PostBackUrl="~/Menu_TU/Daftar_Keluarga.aspx" class="btn btn-primary"/>
    <div class="jumbotron" style="font-size:medium">
        <br />
    <div style="position:center;margin-top:auto;margin-left:20px;margin-right:20px">
        
    
        <table style="border:none">
            <tr>
                <td>
                    Search By:
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlSearchBy" runat="server" AutoPostBack="true" onselectedindexchanged="ddlSearchBy_SelectedIndexChanged" CssClass="form-control">
        <asp:ListItem Text="All"></asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="searchValue" runat="server" CssClass="form-control"></asp:TextBox>
                </td>
                <td>
                     <asp:Button ID="searchBtn" runat="server" Text="Search" onclick="searchBtn_Click" class="btn btn-primary" />
                </td>
                <td>
                     <asp:Button ID="clear" runat="server" Text="X" OnClick="clear_Click" class="btn btn-primary"/>
                </td>
            </tr>

        </table>
        
       <br />
       
    <asp:GridView ID="CustGrid" runat="server" Width="1040px" AllowSorting="True" OnSorting="CustGrid_OnSorting" OnRowDataBound="OnRowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged"  
    AllowPaging="True" PageSize="8" OnPageIndexChanging="CustGrid_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" BorderStyle="none">
        <AlternatingRowStyle BackColor="Transparent" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="Black" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="Transparent" />
        <SelectedRowStyle BackColor="#e6e6e6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    </div>
       <br />
        <div>
            <table style="border:none">
                <tr>
                    <td style="width:910px">

                    </td>
                    <td>
                        <asp:Button ID="btnAccept" runat="server" Text="Accept"  class="btn btn-primary"/>
                        <asp:Button ID="btnReject" runat="server" Text="Reject"  class="btn btn-primary"/>
                    </td>
                </tr>
   
               </table>
         </div>
</div>
</asp:Content>
