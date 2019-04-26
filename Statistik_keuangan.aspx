<%@ Page Title="Statistik Keuangan" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="~/Statistik_keuangan.aspx.vb" Inherits="Statistik_keuangan" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <div Class="jumbotron" style="width:auto">
           <asp:Label runat="server" Text="Grafik Keuangan Tahunan" Font-Size="X-Large"></asp:Label>
          <br />
          <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="1050px">
              <Series>
                  <asp:Series Name="Series1" ChartType="Bar" XValueMember="Tahun" YValueMembers="Debit" IsValueShownAsLabel="true"></asp:Series>
              </Series>
              <Series>
                  <asp:Series Name="Series2" ChartType="Bar" XValueMember="Tahun" YValueMembers="kredit" IsValueShownAsLabel="true"></asp:Series>
              </Series>
              <ChartAreas>
                  <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
              </ChartAreas>
          </asp:Chart>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [laporan_per_tahun]"></asp:SqlDataSource>
          <center><table style="border:none">
              <tr>
                  <td>
                       <asp:Button ID="Button3" runat="server"  BackColor="#418cf0" Width="15px" Height="15px"/>
                  </td>
                 <td>
                     <asp:Label runat="server" Text="Pemasukan" Font-Size="small"></asp:Label>
                 </td>
                  <td>
                      <asp:Button ID="Button4" runat="server" BackColor="#fcb441" Width="15px" Height="15px"/>
                     
                 </td>
   
                  <td>
                <asp:Label runat="server" Text="Pengeluaran" Font-Size="small"></asp:Label>
                  </td>
              </tr>
          

          
              </table>
    </div>

    <div Class="jumbotron" style="width:auto">
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
    AllowPaging="True" PageSize="5" OnPageIndexChanging="CustGrid_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" BorderStyle="none" Font-Size="medium">
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
          <table style="border:none">
              <tr>
                  <td style="width:750px">

                  </td>
                  <td>
                      <asp:Label runat="server" ID="lbl1" Text="Saldo Kas"></asp:Label>
                  </td>
                  <td>
                      <asp:Label runat="server" ID="lbl2" Text=":"></asp:Label>
                  </td>
                  <td>
                      <asp:GridView ID="saldo" runat="server" ShowHeader="false" BorderStyle="None">

                      </asp:GridView>
                  </td>
              </tr>
          </table>
    </div>
    </div>
    


        
</asp:Content>
