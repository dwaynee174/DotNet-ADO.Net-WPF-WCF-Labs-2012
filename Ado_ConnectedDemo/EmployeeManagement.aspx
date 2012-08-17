<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmployeeManagement.aspx.cs" Inherits="EmployeeManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 92%;
        }
        .style2
        {
            width: 195px;
            font-weight: bold;
            font-size: large;
        }
        .style3
        {
            width: 195px;
            height: 21px;
            font-size: large;
        }
        .style4
        {
            height: 21px;
        }
        .style5
        {
            font-size: large;
        }
        .style6
        {
            width: 189px;
        }
        .style7
        {
            height: 21px;
            width: 189px;
        }
        .style8
        {
            width: 195px;
            height: 20px;
            font-size: large;
        }
        .style9
        {
            height: 20px;
            width: 189px;
        }
        .style10
        {
            height: 20px;
        }
        #form1
        {
            height: 394px;
            width: 600px;
        }
    </style>
</head>
<body background="logo.jpg" bgcolor="#ccccff" text="#000099">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td bgcolor="White" class="style2">
                    Employee Number</td>
                <td bgcolor="White" class="style6">
                    <asp:TextBox ID="txtempno" runat="server" BorderStyle="Solid" CssClass="style5"></asp:TextBox>
                </td>
                <td bgcolor="White">
                    &nbsp;</td>
            </tr>
            <tr>
                <td bgcolor="White" class="style2">
                    Employee Name</td>
                <td bgcolor="White" class="style6">
                    <asp:TextBox ID="txtename" runat="server" BorderStyle="Solid" CssClass="style5"></asp:TextBox>
                </td>
                <td bgcolor="White">
                    &nbsp;</td>
            </tr>
            <tr>
                <td bgcolor="White" class="style2">
                    Salary</td>
                <td bgcolor="White" class="style6">
                    <asp:TextBox ID="txtsal" runat="server" BorderStyle="Solid" CssClass="style5"></asp:TextBox>
                </td>
                <td bgcolor="White">
                    <asp:Button ID="btnUpdate" runat="server" BorderStyle="Solid" 
                        onclick="btnUpdate_Click" style="font-weight: 700; font-size: medium" 
                        Text="Update Employee" Visible="False" Width="190px" />
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style2">
                    Department</td>
                <td bgcolor="White" class="style6">
                    <asp:TextBox ID="txtdeptno" runat="server" BorderStyle="Solid" 
                        CssClass="style5"></asp:TextBox>
                </td>
                <td bgcolor="White">
                    <asp:Button ID="btnDelete" runat="server" BorderStyle="Solid" 
                        onclick="btnDelete_Click" style="font-size: medium; font-weight: 700" 
                        Text="Delete Employee" Visible="False" Width="188px" />
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style3">
                    <strong>Total Employees</strong></td>
                <td bgcolor="White" class="style7">
                    <asp:TextBox ID="txttotal" runat="server" BorderStyle="Solid" CssClass="style5"></asp:TextBox>
                </td>
                <td bgcolor="White" class="style4">
                    <asp:Button ID="btnShow" runat="server" BorderStyle="Solid" 
                        onclick="btnShow_Click" style="font-size: medium; font-weight: 700" 
                        Text="Show Total Employees" Width="191px" />
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style8">
                    <asp:Button ID="btnAdd" runat="server" BorderStyle="Solid" 
                        onclick="btnAdd_Click" style="font-size: medium; font-weight: 700" 
                        Text="Add Employee" />
                </td>
                <td bgcolor="White" class="style9">
                    <asp:Button ID="btnSearch" runat="server" BorderStyle="Solid" 
                        onclick="btnSearch_Click" style="font-weight: 700; font-size: medium" 
                        Text="Search Employee" Width="161px" />
                </td>
                <td bgcolor="White" class="style10">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        BorderStyle="Solid" ForeColor="Red" Height="119px" 
                        style="font-weight: 700; font-size: medium" Width="219px" />
                </td>
            </tr>
        </table>
    
    </div>
    <p>
        &nbsp;</p>
    <asp:Label ID="lblresult" runat="server" BackColor="White" ForeColor="#CC00CC" 
        style="font-weight: 700; font-size: large"></asp:Label>
    </form>
</body>
</html>
