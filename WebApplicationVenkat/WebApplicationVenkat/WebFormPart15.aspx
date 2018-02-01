<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPart15.aspx.cs" Inherits="WebApplicationVenkat.WebForm1Part15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
        <asp:Button ID="PrintButton" runat="server" Text="Print" OnCommand="CommandButton_Click" 
            CommandName="Print" />
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnCommand="CommandButton_Click" 
            CommandName="Delete"/>
        <asp:Button ID="Top10Button" runat="server" Text="Top 10" OnCommand="CommandButton_Click" 
            CommandName="Show" CommandArgument="Top10" />
        <asp:Button ID="Bottom10Button" runat="server" Text="Bottom 10" OnCommand="CommandButton_Click" 
            CommandName="Show" CommandArgument="Bottom10"/>

        <br />
        <br />
        <asp:Label ID="OutputLabel" runat="server" Text="Label"></asp:Label>

    </form>
</body>
</html>
