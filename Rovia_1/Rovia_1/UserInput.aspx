<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="Rovia_1.UserInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Panel ID="Panel1" runat="server" Height="331px">
            <asp:Label ID="Label1" runat="server" Text="Location                    "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br>
            <br></br>
            <asp:Label ID="Label2" runat="server" Text="Number of Passengers   "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </br>

        </asp:Panel>
    </form>
</body>
</html>
