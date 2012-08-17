<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DMLDemo.aspx.cs" Inherits="DMLDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 73%;
        }
        .style2
        {
            font-size: large;
            font-weight: bold;
            width: 196px;
            color: #000099;
        }
        .style3
        {
            width: 122px;
        }
        .style4
        {
            font-size: medium;
        }
        #form1
        {
            font-weight: 700;
        }
    </style>
</head>
<body bgcolor="#b0c9e8">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="style1" 
        style="font-family: Arial, Helvetica, sans-serif; background-color: #B9DCFF; border: 3px solid #000099; height: 205px;">
        <tr>
            <td class="style2">
                Employee Number</td>
            <td class="style3">
                <asp:TextBox ID="txtempno" runat="server" Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Employee Name</td>
            <td class="style3">
                <asp:TextBox ID="txtename" runat="server" Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Salary</td>
            <td class="style3">
                <asp:TextBox ID="txtsal" runat="server" Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Department Number</td>
            <td class="style3">
                <asp:TextBox ID="txtdeptno" runat="server" Width="265px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Row ID</td>
            <td class="style3">
                <asp:TextBox ID="txtRowId" runat="server" Width="265px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <asp:Button ID="btnDisplay" runat="server" BackColor="#99CCFF" 
        BorderStyle="Solid" BorderWidth="5px" CssClass="style4" ForeColor="#000099" 
        onclick="btnDisplay_Click" style="font-weight: 700" 
        Text="Display Employee in given RowId" Width="435px" />
    <br />
    <br />
    <asp:Button ID="btnClear" runat="server" BackColor="#99CCFF" 
        BorderStyle="Solid" BorderWidth="5px" CssClass="style4" ForeColor="#000099" 
        onclick="btnClear_Click" style="font-weight: 700" Text="Clear Text" 
        Width="435px" />
    <br />
    <br />
    <asp:Button ID="btnInsert" runat="server" BackColor="#99CCFF" 
        BorderStyle="Solid" BorderWidth="5px" CssClass="style4" Enabled="False" 
        ForeColor="#000099" onclick="btnInsert_Click" style="font-weight: 700" 
        Text="Add New Employee" Width="436px" />
    <br />
    <br />
    <asp:Button ID="btnShow" runat="server" BackColor="#99CCFF" 
        BorderColor="#000099" BorderStyle="Solid" BorderWidth="5px" 
        onclick="btnShow_Click" 
        style="font-weight: 700; font-size: medium; color: #000099" 
        Text="Show Employee Table" Width="433px" />
    <br />
    <br />
    <asp:GridView ID="dgemp" runat="server" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="440px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <br />
    </form>
</body>
</html>
