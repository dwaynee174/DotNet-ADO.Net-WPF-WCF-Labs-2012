<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqToSqlDemo.aspx.cs" Inherits="LinqToSqlDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 67%;
            height: 195px;
        }
        .style2
        {
            width: 156px;
            font-size: medium;
            font-weight: bold;
        }
        .style3
        {
            font-size: medium;
            font-weight: bold;
        }
        .style4
        {
            width: 156px;
            font-size: medium;
        }
        .style5
        {
            font-size: medium;
        }
        .style6
        {
            width: 156px;
            font-size: medium;
            font-weight: bold;
            height: 48px;
        }
        .style7
        {
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnShow" runat="server" BackColor="#FFCC99" BorderStyle="Solid" 
            onclick="btnShow_Click" style="font-weight: 700; font-size: medium" 
            Text=" Show Employees" Width="256px" />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
            BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            CellSpacing="2" Height="265px" style="font-size: medium" Width="261px">
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
        <br />
        <table class="style1">
            <tr>
                <td bgcolor="#CC6600" class="style6">
                    Employee Number</td>
                <td bgcolor="#FFCC99" class="style7">
                    <asp:TextBox ID="txtempno" runat="server" CssClass="style5" Height="29px" 
                        Width="206px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td bgcolor="#CC6600" class="style2">
                    Employee Name</td>
                <td bgcolor="#FFCC99">
                    <asp:TextBox ID="txtename" runat="server" CssClass="style3" Height="29px" 
                        Width="206px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td bgcolor="#CC6600" class="style4">
                    <strong>Salary</strong></td>
                <td bgcolor="#FFCC99">
                    <asp:TextBox ID="txtsal" runat="server" CssClass="style3" Height="29px" 
                        Width="206px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td bgcolor="#CC6600" class="style2">
                    Department Number</td>
                <td bgcolor="#FFCC99">
                    <asp:TextBox ID="txtdeptno" runat="server" CssClass="style3" Height="29px" 
                        Width="206px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    <br />
    <asp:Button ID="btnAdd" runat="server" BackColor="#FFCC99" BorderStyle="Solid" 
        onclick="btnAdd_Click" style="font-weight: 700; font-size: medium" 
        Text="Add New Employee" Width="181px" />
    <asp:Button ID="btnSearch" runat="server" BackColor="#FFCC99" 
        BorderStyle="Solid" onclick="btnSearch_Click" 
        style="font-weight: 700; font-size: medium" Text="Search Employee" 
        Width="149px" />
    <br />
    <br />
    <asp:Button ID="btnUpdate" runat="server" BackColor="#FFCC99" 
        BorderStyle="Solid" onclick="btnUpdate_Click" 
        style="font-weight: 700; font-size: medium" Text="Update Employee" 
        Width="180px" />
    <asp:Button ID="btnDelete" runat="server" BackColor="#FFCC99" 
        BorderStyle="Solid" onclick="btnDelete_Click" 
        style="font-weight: 700; font-size: medium" Text="Delete Employee" 
        Width="149px" />
    <br />
    <br />
    <br />
&nbsp;<p>
        <asp:Label ID="lblMessage" runat="server" style="font-weight: 700"></asp:Label>
    </p>
    </form>
</body>
</html>
