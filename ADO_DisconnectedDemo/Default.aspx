<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConflictDetection="CompareAllValues" 
            ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" 
            DeleteCommand="DELETE FROM [Employees] WHERE [empno] = @original_empno AND (([ename] = @original_ename) OR ([ename] IS NULL AND @original_ename IS NULL)) AND (([salary] = @original_salary) OR ([salary] IS NULL AND @original_salary IS NULL)) AND (([deptno] = @original_deptno) OR ([deptno] IS NULL AND @original_deptno IS NULL))" 
            InsertCommand="INSERT INTO [Employees] ([ename], [salary], [deptno]) VALUES (@ename, @salary, @deptno)" 
            OldValuesParameterFormatString="original_{0}" 
            SelectCommand="SELECT * FROM [Employees]" 
            UpdateCommand="UPDATE [Employees] SET [ename] = @ename, [salary] = @salary, [deptno] = @deptno WHERE [empno] = @original_empno AND (([ename] = @original_ename) OR ([ename] IS NULL AND @original_ename IS NULL)) AND (([salary] = @original_salary) OR ([salary] IS NULL AND @original_salary IS NULL)) AND (([deptno] = @original_deptno) OR ([deptno] IS NULL AND @original_deptno IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_empno" Type="Int32" />
                <asp:Parameter Name="original_ename" Type="String" />
                <asp:Parameter Name="original_salary" Type="Int32" />
                <asp:Parameter Name="original_deptno" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="salary" Type="Int32" />
                <asp:Parameter Name="deptno" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ename" Type="String" />
                <asp:Parameter Name="salary" Type="Int32" />
                <asp:Parameter Name="deptno" Type="Int32" />
                <asp:Parameter Name="original_empno" Type="Int32" />
                <asp:Parameter Name="original_ename" Type="String" />
                <asp:Parameter Name="original_salary" Type="Int32" />
                <asp:Parameter Name="original_deptno" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="empno" 
        DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
        Height="404px" PageSize="5" Width="354px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="empno" HeaderText="empno" InsertVisible="False" 
                ReadOnly="True" SortExpression="empno" />
            <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
            <asp:BoundField DataField="salary" HeaderText="salary" 
                SortExpression="salary" />
            <asp:BoundField DataField="deptno" HeaderText="deptno" 
                SortExpression="deptno" />
        </Columns>
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
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
        AutoGenerateRows="False" BackColor="White" BorderColor="#E7E7FF" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="empno" 
        DataSourceID="SqlDataSource1" GridLines="Horizontal" Height="50px" 
        Width="354px">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <Fields>
            <asp:BoundField DataField="empno" HeaderText="empno" InsertVisible="False" 
                ReadOnly="True" SortExpression="empno" />
            <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
            <asp:BoundField DataField="salary" HeaderText="salary" 
                SortExpression="salary" />
            <asp:BoundField DataField="deptno" HeaderText="deptno" 
                SortExpression="deptno" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    </asp:DetailsView>
    </form>
</body>
</html>
