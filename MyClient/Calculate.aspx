<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculate.aspx.cs" Inherits="Calculate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 159px;
        }
        .style2
        {
            width: 172px;
            font-weight: bold;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    Enter Number 1:</td>
                <td>
                    <asp:TextBox ID="txtnum1" runat="server" Height="32px" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Enter Number 2:</td>
                <td>
                    <asp:TextBox ID="txtnum2" runat="server" Height="32px" Width="258px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:Button ID="btnAdd" runat="server" Height="56px" onclick="btnAdd_Click" 
        style="font-weight: 700; font-size: medium" Text="Add" Width="176px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSubtract" runat="server" Height="55px" 
        onclick="btnSubtract_Click" 
        style="font-weight: 700; font-size: medium; margin-top: 0px" Text="Subtract" 
        Width="154px" />
    <p>
        <asp:Label ID="lblMessage" runat="server" style="font-weight: 700"></asp:Label>
    </p>
    </form>
   
</body>
</html>
