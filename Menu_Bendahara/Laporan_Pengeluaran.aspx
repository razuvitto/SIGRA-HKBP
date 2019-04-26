<%@ Page Title="Laporan Pengeluaran" Language="VB" MasterPageFile="~/Menu_Bendahara/Site_Bendahara.master" AutoEventWireup="true" CodeFile="~/Menu_Bendahara/Laporan_Pengeluaran.aspx.vb" Inherits="Laporan_Pengeluaran" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div class="jumbotron">
        <h2 style="text-align:left;font-size:20px">Grafik Pengeluaran</h2>
    <center><asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" Width="1000px" BackColor="238, 238, 238" BackSecondaryColor="Azure">
    <Series>
        <asp:Series Name="Series1" XValueMember="Tahun" YValueMembers="Total" IsValueShownAsLabel="true" ChartType="Bar"></asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </ChartAreas>
</asp:Chart>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" SelectCommand="SELECT * FROM [uang_keluar_per_tahun]"></asp:SqlDataSource>
        </div>
    <div class="jumbotron">
        <h2 style="text-align:left;font-size:20px">Data Pengeluaran</h2>
       <div>
        <asp:GridView ID="pemasukan" runat="server" AutoGenerateColumns="false" DataKeyNames="id_transaksi" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan" Font-Size="Medium">
        <Columns>
            <asp:TemplateField HeaderText="Nama Pengeluaran" ItemStyle-Width="500" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lblnama" runat="server" Text='<%# Eval("nama_transaksi") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Jumlah" ItemStyle-Width="350" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lbljumlah" runat="server" Text='<%# Eval("jumlah") %>'></asp:Label>
                </ItemTemplate>         
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Waktu Transaksi" ItemStyle-Width="450" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("tanggal_transaksi") %>'></asp:Label>
                </ItemTemplate>            
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Waktu Input Data" ItemStyle-Width="450" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lblwaktu" runat="server" Text='<%# Eval("waktu_input_data") %>'></asp:Label>
                </ItemTemplate>            
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
        </div>
   <%-- <div class="jumbotron">
        <h2 style="text-align:left;font-size:20px">Data Pemasukan Tahunan</h2>
       <div>
        <asp:GridView ID="masuk_tahun" runat="server" AutoGenerateColumns="false" BorderColor="Transparent" EmptyDataText="Data Belum Ditambahkan" Font-Size="Medium">
        <Columns>
            <asp:TemplateField HeaderText="Tahun" ItemStyle-Width="500" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lblnama" runat="server" Text='<%# Eval("tahun") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total" ItemStyle-Width="350" HeaderStyle-BackColor="Transparent" HeaderStyle-Font-Bold="True">
                <ItemTemplate>
                    <asp:Label ID="lbljumlah" runat="server" Text='<%# Eval("total") %>'></asp:Label>
                </ItemTemplate>         
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
        </div>--%>
</asp:Content>


