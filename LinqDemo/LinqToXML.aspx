<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqToXML.aspx.cs" Inherits="LinqToXML" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnCreate" runat="server" Height="40px" 
            onclick="btnCreate_Click" style="font-size: x-large" Text="Create XML File" 
            Width="195px" />
        <br />
        <br />
        <asp:Label ID="lblmessage" runat="server" style="font-size: xx-large"></asp:Label>
    
    </div>
    <asp:Button ID="btnShow" runat="server" onclick="btnShow_Click" 
        style="font-size: x-large" Text="Show Contact Details" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
