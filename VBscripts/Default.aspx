﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insert" />
    
        <asp:Button ID="Button2" runat="server" Text="Insert" />
    
        <asp:Button ID="Button3" runat="server" Text="Insert" />
    
        <asp:GridView ID="GridView1" runat="server" PageSize="5">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
