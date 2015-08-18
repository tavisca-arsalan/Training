<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.ascx.cs" Inherits="Tavisca.EMS.AddEmployee" %>
<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="false" Height="264px" Width="349px">
    <gtc:TemplarLabel ID="addemployee" Text="Add Employee" runat="server" Style="margin-left: 100px">
    </gtc:TemplarLabel> 
    <br />
    <asp:Table ID="table1" runat="server" Height="15px" Width="270px" >
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelTitle" runat="server" Text="Title"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox> 
                <gtc:TemplarRequiredFieldValidator ID="TitleValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxTitle"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelFName" runat="server" Text="FirstName"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxFName" runat="server"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="FirstNameValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxFName"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelLName" runat="server" Text="LastName"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxLName" runat="server"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="LastNameValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxLName"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelDesignation" runat="server" Text="Designation"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxDesignation" runat="server"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="DesignationValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxDesignation"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelEmail" runat="server" Text="Email"></gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="EmailValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxEmail"></gtc:TemplarRequiredFieldValidator>
                <gtc:TemplarRequiredFieldValidator ID="EmailExpressionValidator" ForeColor="Red" ErrorMessage="" runat="server" ControlToValidate="TextBoxEmail"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelContact" runat="server" Text="Contact"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxContact" runat="server"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="ContactValidator" ForeColor="Red" ErrorMessage="*" runat="server" ControlToValidate="TextBoxContact"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelPassword" runat="server" Text="Password"></gtc:TemplarLabel>
                </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                <gtc:TemplarRequiredFieldValidator ID="PasswordValidator" ForeColor="Red" ControlToValidate="TextBoxPassword" 
                    ErrorMessage="*" runat="server"></gtc:TemplarRequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow>
            
            <asp:TableCell>
                <asp:Button ID="ButtonAdd" runat="server" Text="Add" Width="50px" OnClick="ButtonAdd_Click"/> &nbsp;
                <asp:Button ID="ButtonReset" runat="server" Text="Reset" OnClick="ButtonReset_Click"/>
                <asp:Label ID="Label1" runat="server" Text="" Visible="false"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Panel>