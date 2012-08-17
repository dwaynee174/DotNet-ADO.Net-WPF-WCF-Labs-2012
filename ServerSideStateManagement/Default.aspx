<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: large">
    
        You are Visitor number :&nbsp;
        <asp:Label ID="Label1" runat="server" 
            style="font-weight: 700; color: #FF0000; font-size: large" Text="Label"></asp:Label>
        <br />
    
    </div>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="font-size: large" 
        onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
        <asp:ListItem>C sharp</asp:ListItem>
        <asp:ListItem>Java</asp:ListItem>
        <asp:ListItem>Testing</asp:ListItem>
        <asp:ListItem>Oracle</asp:ListItem>
        <asp:ListItem>SQl Server</asp:ListItem>
        <asp:ListItem>Siebel</asp:ListItem>
    </asp:CheckBoxList>
    <br />
    <asp:Button ID="Button1" runat="server" BorderStyle="Groove" Height="53px" 
        onclick="Button1_Click" style="font-size: x-large; font-weight: 700" 
        Text="Submit" Width="106px" />
    </form>
</body>
</html>
