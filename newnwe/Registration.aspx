<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="newnwe.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Larger" 
            Text="Регистрация"></asp:Label>
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />
   
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <br />

        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="CompareValidator"></asp:CompareValidator>
        <br />
    
    </div>
    </form>
</body>
</html>
