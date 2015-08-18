<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomePageHR.ascx.cs" Inherits="Tavisca.EMS.HomePageHR" %>

<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="false">
    <a href="NewEmployee">Add Employee</a> &nbsp;&nbsp;
    <a href="AddRemark">Add Remark</a>  &nbsp;&nbsp;    
    <a href="ChangePassword">Change Password</a>&nbsp;&nbsp;
    <a href="Logout" class="pull right">Logoff</a>
</asp:Panel>
