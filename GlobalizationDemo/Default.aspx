<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">English</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="#FF99FF" 
            onclick="LinkButton2_Click">Hindi</asp:LinkButton>
    
    </div>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
