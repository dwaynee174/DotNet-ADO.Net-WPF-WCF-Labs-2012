﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataSetCode.aspx.cs" Inherits="DataSetCode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="logo.jpg">
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnShow" runat="server" BackColor="#FFFFCC" BorderColor="Black" 
            BorderStyle="Solid" Height="42px" onclick="btnShow_Click" 
            style="font-weight: 700; font-size: large" Text="Show Employee Table" 
            Width="232px" />
        <br />
    
    </div>
    <asp:GridView ID="dgemp" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" Height="277px" Width="236px">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    </form>
</body>
</html>
