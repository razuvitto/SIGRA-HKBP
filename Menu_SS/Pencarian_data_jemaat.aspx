<%@ Page Title="Pencarian Data Jemaat" Language="VB" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Pencarian_data_jemaat.aspx.vb" Inherits="Pencarian_data_jemaat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
       body {
   margin:0;
   padding:0;
   height:100%;
}
#container {
   min-height:100%;
   position:relative;
}
#header {
   background:#ff0;
   padding:10px;
}
#body {
   padding:10px;
   padding-bottom:60px;   /* Height of the footer */
}
#footer {
   position:absolute;
   bottom:0;
   width:100%;
   height:60px;   /* Height of the footer */
   background:#6cf;
}


    </style>   
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>


    <div id="container">
   <div id="header"></div>
   <div id="body"></div>
   <div id="footer">adaws</div>
</div>
</asp:Content>

