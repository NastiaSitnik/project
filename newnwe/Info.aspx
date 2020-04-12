<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="newnwe.Info" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
            Text="Information"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
         <br />

        <asp:Button ID="Button1" runat="server" Text="Button" Width="125px" 
            onclick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" Width="125px" 
            onclick="Button2_Click" />
        <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         
               <!-- <br />        
        <label>Sort: 
                    <select name="sort" size=" 3 ">
                      <option value="null" >choose sory type</option> 
                      <option value="name" > by name </option>  
                      <option value="name" > by name </option>
                      <option value="company" > by company </option>
                      <option value="number" > by number </option>
                      <option value="arrears" > by arrears </option>
                      <option value="suma" > by suma </option>
                        
                    </select>

        </label>-->
                
                <asp:DropDownList ID = "DropdowmList1" runat="server" >
                    </asp:DropDownList>
                <asp:Button ID="Button3" runat="server" Text="Button" Width="125px" 
            onclick="Button3_Click" />
                <br/>
                <asp:Button ID="Button4" runat="server" Text="Button" Width="125px" 
            onclick="Button4_Click" />
        <br />
    </div>
    </form>
</body>
</html>
