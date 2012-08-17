<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #0033CC;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="style1">Enter your name:<asp:TextBox ID="txtName" 
            runat="server" Height="23px" Width="191px"></asp:TextBox>
        </span></strong>
    
    </div>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Height="40px" 
            onclick="btnSubmit_Click" style="color: #0000FF; font-weight: 700" 
            Text="Submit" Width="155px" />
    </p>
    <p style="font-weight: 700; color: #3333CC">
        <asp:Label ID="lblWelcome" runat="server"></asp:Label>
    </p>
    <p style="font-weight: 700; color: #3333CC">
        &nbsp;</p>
    </form>
</body>
</html>
