<%@ Page Language="C#" Inherits="newnwe.Delete" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Delete</title>
</head>
<body>
	<form id="form1" runat="server">
    <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
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
        <asp:Button ID="Button1" runat="server" Text="Button" Width="125px" 
       onclick="Button1_Click" />
        <br />
      
    </div>
     
	</form>
</body>
</html>
