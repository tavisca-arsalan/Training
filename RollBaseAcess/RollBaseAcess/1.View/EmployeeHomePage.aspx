<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="EmployeeHomePage.aspx.cs" Inherits="RollBaseAcess.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Size="X-Large"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Font-Size="X-Small" Font-Underline="True" ForeColor="#0066FF" Height="38px" OnClick="Button1_Click" Text="Change Password" Width="119px" />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="true" AllowCustomPaging="true" PageSize="2">
</asp:GridView>
        
    </asp:Content>
