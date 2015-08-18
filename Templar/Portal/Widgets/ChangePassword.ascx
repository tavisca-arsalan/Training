<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.ascx.cs" Inherits="Tavisca.EMS.ChangePassword" %>

<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="false">
    <gtc:TemplarLabel ID="addRemarkPage" runat="server" Text="Change Password" Style="margin-left: 100px">
    </gtc:TemplarLabel>
    <br />
    <asp:Table ID="Table1" runat="server" ValidateRequestMode="Disabled" Height="174px" Width="432px">
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelEmail" runat="server" Text="Email">
                </gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxEmail" runat="server">
                </asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Red"
                    ErrorMessage="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBoxEmail">
                </asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelOldPassword" runat="server" Text="Old Password">
                </gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxOldPassword" runat="server" TextMode="Password">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxOldPassword">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelNewPassword" runat="server" Text="New Password">
                </gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxNewPassword" runat="server" TextMode="Password">
                </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="TextBoxNewPassword">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelConfirm" runat="server" Text="Confirm Password">
                </gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxConfirm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password do not match" 
                    ForeColor="Red" ControlToCompare="TextBoxConfirm" ControlToValidate="TextBoxNewPassword"></asp:CompareValidator>

            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="ButtonAdd" runat="server" Text="Add" Width="50px" OnClick="ButtonAdd_Click" />
                &nbsp;
                <asp:Button ID="ButtonReset" runat="server" Text="Reset" OnClick="ButtonReset_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Panel>
