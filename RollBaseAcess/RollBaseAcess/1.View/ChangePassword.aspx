<%@ Page Title="" Language="C#" MasterPageFile="~/1.View/Site.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="RollBaseAcess._1.View.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 207px;
            height: 66px;
        }
        .auto-style4 {
            width: 212px;
            height: 66px;
        }
        .auto-style5 {
            height: 66px;
        }
        .auto-style6 {
            width: 207px;
            height: 68px;
        }
        .auto-style7 {
            width: 212px;
            height: 68px;
        }
        .auto-style8 {
            height: 68px;
        }
        .auto-style9 {
            width: 207px;
            height: 59px;
        }
        .auto-style10 {
            width: 212px;
            height: 59px;
        }
        .auto-style11 {
            height: 59px;
        }
        .auto-style12 {
            width: 207px;
            height: 62px;
        }
        .auto-style13 {
            width: 212px;
            height: 62px;
        }
        .auto-style14 {
            height: 62px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 48%; height: 267px;">
        <tr>
            <td class="auto-style12">
                <asp:Label ID="Label1" runat="server" Text="UserId"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="auto-style14">
                <asp:Label ID="Label5" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Text="*You seem to have provided incorrect UserId or Passwaord" Visible="False"></asp:Label>
            </td>
           
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Old Password"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox2" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*This field cannot be empty" Font-Size="X-Small" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="New Password"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox3" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style8">
               
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*This field cannot be empty" Font-Size="X-Small" ForeColor="Red" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
               
            </td>
        </tr>
         <tr>
            <td class="auto-style9">
                <asp:Label ID="Label4" runat="server" Text="Confirm New Password"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox4" runat="server" Width="200px" TextMode="Password"></asp:TextBox>
            </td>
             
            <td class="auto-style11">
                 <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="*Passwords do not match" Font-Size="X-Small" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    <asp:Label ID="Label6" runat="server" Font-Size="X-Large" Text="Password changed successfully!" Visible="False"></asp:Label>
</asp:Content>
