<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HousePresident.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ContactValidation(objSource, objArgs) {
            var number = objArgs.Value;
            if (number.Length == 10)
                objArgs.IsValid = true;
            else
                objArgs.IsValid = false;

        }
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a candidate:<br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />            
            Choose a House:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList><br />
            Enter class(6th-12th)<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
             Enter EMAIL ID:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
             Enter Parent contact number:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br /><br /> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please choose a candidate" ControlToValidate="DropDownList1" ForeColor="Red" Font-Bold="true" Display="None"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter class between 6 and 12" ControlToValidate="TextBox1" ForeColor="Red" Font-Bold="true" MaximumValue='12' MinimumValue='6' Type='Integer' Display="None"></asp:RangeValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please choose a house" ControlToValidate="RadioButtonList1" Font-Bold="true" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter a class between 6-12" ControlToValidate="TextBox1" Display="None" ></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email ID" ControlToValidate="TextBox2" ForeColor="Red" Font-Bold="true" ValidationExpression="\S+@\S+\.\S+" Display="None"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Email ID" ControlToValidate="TextBox2" ForeColor="Red" Font-Bold="true" Display="None"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Incorrect contact number, try number with 10 digits" ControlToValidate="TextBox3" ForeColor="Red" Font-Bold="true" OnServerValidate="CustomValidator1_ServerValidate" Display="None" ValidateEmptyText="true" ClientValidationFunction="ContactValidate"></asp:CustomValidator>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" Font-Bold="true" HeaderText="This form contains the following errors:" ShowSummary="true" />



        </div>
    </form>
</body>
</html>
