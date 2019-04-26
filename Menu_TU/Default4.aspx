<%@ Page Title="Default4" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default4.aspx.vb" Inherits="Default4" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  



    <html xmlns="http://www.w3.org/1999/xhtml">  
    <title>Showing Employee Information in Chart</title>  
<body>  
        <div>  
            <asp:Chart ID="EmployeeChartInfo" runat="server" Height="450px" Width="550px">  
                <Titles>  
                    <asp:Title ShadowOffset="3" Name="Items" />  
                </Titles>  
                <Legends>  
                    <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default" LegendStyle="Row" />  
                </Legends>  
                <Series>  
                    <asp:Series Name="Default" />  
                </Series>  
                <ChartAreas>  
                    <asp:ChartArea Name="ChartArea1" BorderWidth="1" />  
                </ChartAreas>  
            </asp:Chart>  
        </div>  
</body>  
</html>  




  <%--  <!DOCTYPE HTML>
<html>
<head>  
<script type="text/javascript">
window.onload = function () {

var chart = new CanvasJS.Chart("chartContainer", {
	animationEnabled: true,
	title:{
		text: "Olympic Medals of all Times (till 2016 Olympics)"
	},
	axisY: {
		title: "Medals"
	},
	legend: {
		cursor:"pointer",
		itemclick : toggleDataSeries
	},
	toolTip: {
		shared: true,
		content: toolTipFormatter
	},
	data: [{
		type: "bar",
		showInLegend: true,
		name: "Gold",
		color: "gold",
		dataPoints: [
			{ y: 243, label: "Italy" },
			{ y: 236, label: "China" },
			{ y: 243, label: "France" },
			{ y: 273, label: "Great Britain" },
			{ y: 269, label: "Germany" },
			{ y: 196, label: "Russia" },
			{ y: 1118, label: "USA" }
		]
	},
	{
		type: "bar",
		showInLegend: true,
		name: "Silver",
		color: "silver",
		dataPoints: [
			{ y: 212, label: "Italy" },
			{ y: 186, label: "China" },
			{ y: 272, label: "France" },
			{ y: 299, label: "Great Britain" },
			{ y: 270, label: "Germany" },
			{ y: 165, label: "Russia" },
			{ y: 896, label: "USA" }
		]
	},
	{
		type: "bar",
		showInLegend: true,
		name: "Bronze",
		color: "#A57164",
		dataPoints: [
			{ y: 236, label: "Italy" },
			{ y: 172, label: "China" },
			{ y: 309, label: "France" },
			{ y: 302, label: "Great Britain" },
			{ y: 285, label: "Germany" },
			{ y: 188, label: "Russia" },
			{ y: 788, label: "USA" }
		]
	}]
});
chart.render();

function toolTipFormatter(e) {
	var str = "";
	var total = 0 ;
	var str3;
	var str2 ;
	for (var i = 0; i < e.entries.length; i++){
		var str1 = "<span style= \"color:"+e.entries[i].dataSeries.color + "\">" + e.entries[i].dataSeries.name + "</span>: <strong>"+  e.entries[i].dataPoint.y + "</strong> <br/>" ;
		total = e.entries[i].dataPoint.y + total;
		str = str.concat(str1);
	}
	str2 = "<strong>" + e.entries[0].dataPoint.label + "</strong> <br/>";
	str3 = "<span style = \"color:Tomato\">Total: </span><strong>" + total + "</strong><br/>";
	return (str2.concat(str)).concat(str3);
}

function toggleDataSeries(e) {
	if (typeof (e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
		e.dataSeries.visible = false;
	}
	else {
		e.dataSeries.visible = true;
	}
	chart.render();
}

}
</script>
</head>
<body>
<div id="chartContainer" style="height: 300px; width: 100%;"></div>
<script src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>
</body>
</html>--%>
</asp:Content>
