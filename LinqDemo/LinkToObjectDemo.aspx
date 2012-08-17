<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinkToObjectDemo.aspx.cs" Inherits="LinkToObjectDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnShow" runat="server" Height="35px" onclick="btnShow_Click" 
            style="font-weight: 700; font-size: medium" Text="Show Names" Width="176px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnShowEmp" runat="server" onclick="btnShowEmp_Click" 
            style="font-size: medium; font-weight: 700; margin-right: 0px; margin-bottom: 0px" 
            Text="Show Employee Details" Width="196px" />
        <br />
        <br />
        <asp:Button ID="btnEmpDept" runat="server" onclick="btnEmpDept_Click" 
            style="font-weight: 700" Text="Show Employee Dept wise" />
        <br />
        <br />
    
    </div>
    <asp:ListBox ID="lstnames" runat="server" Height="198px" Width="339px">
    </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2">
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
&nbsp;
    </form>
</body>
</html>
