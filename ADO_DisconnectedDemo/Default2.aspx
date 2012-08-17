<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" 
            SelectCommand="SELECT * FROM [Employees] WHERE ([deptno] = @deptno)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="deptno" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <strong><span class="style1">Select Department:<br />
        </span></strong>
    
    </div>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="dname" DataValueField="deptno" 
        Height="56px" Width="182px">
    </asp:DropDownList>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataKeyNames="empno" 
        DataSourceID="SqlDataSource2" Height="311px" Width="258px">
        <Columns>
            <asp:BoundField DataField="empno" HeaderText="empno" InsertVisible="False" 
                ReadOnly="True" SortExpression="empno" />
            <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
            <asp:BoundField DataField="salary" HeaderText="salary" 
                SortExpression="salary" />
            <asp:BoundField DataField="deptno" HeaderText="deptno" 
                SortExpression="deptno" />
        </Columns>
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
    </form>
</body>
</html>
