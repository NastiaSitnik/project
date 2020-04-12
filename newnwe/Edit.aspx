<%@ Page Language="C#" Inherits="newnwe.Edit" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Edit</title>
</head>
<body>
	<form id="form1" runat="server">
             <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br/>
          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             <br/>
          <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br/>
             <asp:Button ID="Button1" runat="server" Text="Button" Width="125px" 
            onclick="Button1_Click" />
               <br/>
          <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        
               <br/>
          <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
               <br/>
          <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
               <br/>
          <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
               <br/>
          <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
               <br/>
          <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            <br/>
             <asp:Button ID="Button2" runat="server" Text="Button" Width="125px" 
            onclick="Button2_Click" />
	</form>
</body>
</html>
