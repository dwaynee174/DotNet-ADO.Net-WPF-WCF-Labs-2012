<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewStateDemo.aspx.cs" Inherits="ViewStateDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">
    
        <strong>Select a Language:</strong><asp:DropDownList ID="DropDownList1" 
            runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>English</asp:ListItem>
            <asp:ListItem>Hindi</asp:ListItem>
            <asp:ListItem>French</asp:ListItem>
            <asp:ListItem>Spanish</asp:ListItem>
            <asp:ListItem>German</asp:ListItem>
        </asp:DropDownList>
        <br />
    
    </div>
    <asp:Button ID="Button1" runat="server" Height="38px" onclick="Button1_Click" 
        style="font-weight: 700; font-size: large" Text="Submit" Width="104px" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" 
        style="font-weight: 700; font-size: large; color: #0000FF" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" 
        style="color: #FF0000; font-weight: 700; font-size: large" Text="Label"></asp:Label>
    </form>
</body>
</html>
