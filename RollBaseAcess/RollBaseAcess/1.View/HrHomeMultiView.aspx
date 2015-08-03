<%@ Page Title="" Language="C#" MasterPageFile="~/1.View/Site.Master" AutoEventWireup="true" CodeBehind="HrHomeMultiView.aspx.cs" Inherits="RollBaseAcess._1.View.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 396px;
        }

        .auto-style4 {
            height: 41px;
        }

        .auto-style5 {
            width: 396px;
            height: 41px;
        }

        .auto-style6 {
            height: 41px;
            width: 50px;
        }

        .auto-style7 {
            width: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

    
        
            <div>
                <h2>
                    <asp:Button ID="Button2" runat="server" Text="Add Remark" Font-Size="Small" Height="38px" Width="106px" OnClick="Button2_Click" /><asp:Button ID="Button1" runat="server" Text="Add Employee" Font-Size="Small" Height="39px" Width="106px" OnClick="Button1_Click" />
                </h2>
    



    <hr />

    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">
        <asp:View ID="View1" runat="server">
            <h3>
               

            </h3>
        </asp:View>

        <asp:View ID="View2" runat="server">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>

                    <table style="width: 100%;" border="0">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
                                <br />
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:CustomValidator>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="LastName"></asp:Label>
                                <br />
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            <td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Title"></asp:Label>
                                <br />
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Phno"></asp:Label>
                                <br />
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                                <br />
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Invalid Email" Font-Size="Small" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="This field cannot be empty" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button4" runat="server" Text="Submit" BorderStyle="Double" Height="47px" Width="114px" OnClick="Button4_Click" />
                                <br />
                            </td>

                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </asp:View>



    </asp:MultiView>
    </div>
         
      
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
