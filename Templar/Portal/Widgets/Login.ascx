<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Tavisca.EMS.Login" %>

<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="true">

    <gtc:TemplarLabel ID="loginPage" runat="server" Text="Login" Style="margin-left: 100px">
    </gtc:TemplarLabel>
    <asp:Table ID="Table1" runat="server" ValidateRequestMode="Disabled" Height="174px" Width="189px">
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="LabelUsername" runat="server" Text="Username"></asp:Label>
            </asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxName" runat="server" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red"
                    ErrorMessage="*" ControlToValidate="TextBoxName" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                </asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
            </asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxPassword" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                    ForeColor="Red" ControlToValidate="TextBoxPassword">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                &nbsp;
                    <asp:Button ID="ButtonReset" runat="server" Text="Reset" OnClick="ButtonReset_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:CheckBox ID="CheckBoxRememberMe" runat="server" Text="Remember Me?" />
            </asp:TableCell>
            <asp:TableCell>
            <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
                </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Panel>
