<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowEmployees.aspx.cs" Inherits="ShowEmployees" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
    </style>
</head>
<body bgcolor="#ccccff" text="#000099">
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="style1">Select Department&nbsp;&nbsp; </span></strong>
        <asp:DropDownList ID="ddlDept" runat="server" Height="22px" 
            onselectedindexchanged="ddlDept_SelectedIndexChanged" style="font-size: large" 
            Width="147px" AutoPostBack="True">
        </asp:DropDownList>
        <br />
    
    </div>
    <asp:ListBox ID="lstename" runat="server" Height="106px" 
        style="font-size: large" Width="149px"></asp:ListBox>
    </form>
</body>
</html>
