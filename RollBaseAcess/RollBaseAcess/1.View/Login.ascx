<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="RollBaseAcess.Login" %>


<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <table style="width: 59%; height: 264px;">
            <tr>
                <td width="20%">
                    <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
                </td>
                <td width="20%">
                    <asp:TextBox ID="TextBox1" runat="server" Width="144px" Height="32px"></asp:TextBox>
                    </td>
                <td >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="User name required !!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter a valid Email Id" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                </td>
                <td width="20%">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="144px" Height="33px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td width="20%">
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="89px" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td width="20%>
                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="Medium" Text="Remember Me" />
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Authentication Failed!" Visible="False"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
        </table>

    </ContentTemplate>
</asp:UpdatePanel>


