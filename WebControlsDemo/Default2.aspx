<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #9966FF;
        }
        .style2
        {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        <strong><span class="style2">Select a country :</span> </strong>
        <asp:DropDownList ID="ddlCountry" runat="server" Height="35px" 
            onselectedindexchanged="ddlCountry_SelectedIndexChanged">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>Australia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
    
    </div>
    <asp:Button ID="BtnSubmit" runat="server" Height="28px" 
        onclick="BtnSubmit_Click" 
        style="font-weight: 700; color: #0033CC; font-family: 'Courier New', Courier, monospace; font-size: large;" 
        Text="Submit" Width="128px" />
    <p>
        <asp:Label ID="lblSelCountry" runat="server" style="font-size: large"></asp:Label>
    </p>
    </form>
</body>
</html>
