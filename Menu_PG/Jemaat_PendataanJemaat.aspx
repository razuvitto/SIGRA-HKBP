<%@ Page Title="Pendataan Jemaat" EnableEventValidation="false" Language="VB" MasterPageFile="~/Menu_PG/Site_PG.master" AutoEventWireup="true" CodeFile="~/Menu_PG/Jemaat_PendataanJemaat.aspx.vb" Inherits="Jemaat_PendataanJemaat" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <script src="Scripts/WebForms/calendar1.js" type="text/javascript"></script>
    <script src="Scripts/WebForms/calendar2.js" type="text/javascript"></script>
    <link href="Content/bootstrapCalendar.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtDatePria]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateWanita]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDatePerkawinan]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateMeninggalPria]").datepicker({
                showOn: "focus"
            });
        });
        $(function () {
            $("[id$=txtDateMeninggalWanita]").datepicker({
                showOn: "focus"
            });
        });
    </script>
    <br />
    <h2><%: Title %></h2>
    

<div Class="row">
    <br />
    <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-primary" Text="Tambah Data Jemaat" PostBackUrl="~/Menu_TU/Jemaat_Tambah_data.aspx"/>
    <div Class="jumbotron" style="font-size:medium">
        
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
    AllowPaging="True" PageSize="5" OnPageIndexChanging="CustGrid_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" BorderStyle="none">
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
 <%-----------------------------------------------------------------------------------------------------------------------------------------------------------%>          
        <div style="align-content:center; align-items:center"> 
        </div>
    </div>   
</div>
</asp:Content>
