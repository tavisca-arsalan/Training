<%@ Page Title="" Language="C#" MasterPageFile="~/1.View/Site.Master" AutoEventWireup="true" CodeBehind="AddRemark.aspx.cs" Inherits="RollBaseAcess._1.View.WebForm2" %>

<%@ Register Src="~/HR/HrNavTab.ascx" TagPrefix="uc1" TagName="HrNavTab" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <uc1:HrNavTab runat="server" ID="HrNavTab" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

     <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Select Employee"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" OnTextChanged="TextBox6_TextChanged" Height="57px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="*Field cannot be null" Font-Size="X-Small" ForeColor="Red" ValidationGroup="Add Remark"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Font-Size="Small" Text="Add" Width="104px" OnClick="Button3_Click" ValidationGroup="Add Remark" />
                <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
