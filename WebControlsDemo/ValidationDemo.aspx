<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationDemo.aspx.cs" Inherits="ValidationDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">
    function checkEven(src, args)
    {
        if (args.Value % 2 == 0) {
            args.IsValid = true;
        }
        else {
            args.IsValid = false;
        }
    }
</script>
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 207px;
        }
        .style4
        {
            width: 237px;
            font-size: large;
            font-weight: bold;
        }
        .style5
        {
            font-size: large;
            font-weight: bold;
        }
        .style6
        {
            width: 237px;
            font-size: large;
            font-weight: bold;
            height: 31px;
        }
        .style7
        {
            width: 207px;
            height: 31px;
        }
        .style8
        {
            height: 31px;
        }
        .style9
        {
            width: 237px;
            font-size: large;
            font-weight: bold;
            height: 24px;
        }
        .style10
        {
            width: 207px;
            height: 24px;
        }
        .style11
        {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style4">
                    Enter your name</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="style5"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="Name cannot be blank" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                        ControlToValidate="TextBox1" 
                        ErrorMessage="Name should consist of only alphabets" ForeColor="Red" 
                        ValidationExpression="[a-zA-Z]*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Enter Password</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="style5" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="Password cannot be blank" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    Retype Password</td>
                <td class="style7">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="style5" TextMode="Password"></asp:TextBox>
                </td>
                <td class="style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Please re type your password" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="TextBox2" ControlToValidate="TextBox3" 
                        ErrorMessage="Password does not match" ForeColor="Red">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Enter SEM Marks</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="style5"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="TextBox4" ErrorMessage="Marks should be between 0 &amp; 100" 
                        ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Enter Email Id</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="style5"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextBox5" ErrorMessage="Invalid email id" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Enter Mobile Number</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="style5"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="TextBox6" ErrorMessage="Invalid Number" ForeColor="Red" 
                        ValidationExpression="91[9|8|7]\d{9}">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Enter Even Number</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="style5"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ControlToValidate="TextBox7" ErrorMessage="Invalid Number" ForeColor="Red" 
                        ClientValidationFunction="checkEven">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    Select your skills</td>
                <td class="style10">
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" ForeColor="Red" 
                        style="color: #000000" BorderStyle="Solid">
                        <asp:ListItem>.Net</asp:ListItem>
                        <asp:ListItem>Testing</asp:ListItem>
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>Microsoft Dynamic CRM</asp:ListItem>
                        <asp:ListItem>Oracle</asp:ListItem>
                        <asp:ListItem>Siebel</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td class="style11">
                    <asp:CustomValidator ID="CustomValidator2" runat="server" 
                        ErrorMessage="Atleast 1 option needs to be selected" ForeColor="Red" 
                        onservervalidate="CustomValidator2_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Button ID="btnSubmit" runat="server" CssClass="style5" Text="Submit" 
                        Width="128px" BorderStyle="Solid" BorderWidth="4px" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        style="color: #FF0000" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
