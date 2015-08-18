<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddRemark.ascx.cs" Inherits="Tavisca.EMS.AddRemark" %>

<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="false" Height="173px" Width="298px" style="margin-left: 21px">
    <gtc:TemplarLabel ID="addRemarkPage" runat="server" Text="Add Remark" Style="margin-left: 100px">
    </gtc:TemplarLabel>
    <br /><br />
    <gtc:TemplarLabel ID="TemplarLabelremark" runat="server" Text="Select Employee" style="margin-left: 21px">
    </gtc:TemplarLabel>
    <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" style="margin-left: 12px" Width="111px">
    </asp:DropDownList>
    <br />
    <br />
    <textarea id="TextArearemark" cols="20" rows="2" runat="server" style="margin-left: 16px"></textarea>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Font-Size="Smaller" runat="server" 
        ErrorMessage="Field can not be empty" ForeColor="Red" ControlToValidate="TextArearemark"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Button ID="AddRemarkButton" runat="server" Text="Add Remark" Width="99px" OnClick="AddRemarkButton_Click" style="margin-left: 17px"/>
</asp:Panel>
