<%@ Page Title="" Language="C#" MasterPageFile="~/1.View/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="RollBaseAcess._1.View.WebForm3" %>

<%@ Register Src="~/HR/HrNavTab.ascx" TagPrefix="uc1" TagName="HrNavTab" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
    <style type="text/css">
        .auto-style5 {
            width: 205px;
            height: 41px;
        }
        .auto-style6 {
            height: 41px;
        }
        .auto-style7 {
            width: 205px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <uc1:HrNavTab runat="server" ID="HrNavTab" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <table style="width: 73%; height: 232px;" border="0">
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
                               
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
                           
                                 </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                   
                           <td>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                           </td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label3" runat="server" Text="Designation"></asp:Label>
                              
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                               
                            </td>
                            <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                           
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Label ID="Label4" runat="server" Text="Phno"></asp:Label>
                             
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                
                            </td>
                           <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                           
                        </tr>
                        <tr>
                            <td class="auto-style5">
                                <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                                
                            </td>
                            <td class="auto-style6">
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                             <td class="auto-style6">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invalid Email" Font-Size="Small" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                           
                           
                        </tr>
                        <tr>
                            <td class="auto-style7">
                                <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click1" Width="80px" />
                            </td>

                            <td class="auto-style7">
                                <asp:Label ID="Label6" runat="server" Text="Record added successfully." Visible="false"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel><br /></p>
</asp:Content>
