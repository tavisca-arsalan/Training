<%@ Page Title="" Language="C#" MasterPageFile="~/1.View/Site.Master" AutoEventWireup="true" CodeBehind="HRhomePage.aspx.cs" Inherits="RollBaseAcess.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">


    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <div class="container">
        <ul class="nav nav-tabs">
            <li class="active"><a data-toggle="tab" href="#home">Add Remark</a></li>
            <li><a data-toggle="tab" href="#menu1">Add Employee</a></li>
        </ul>

        <div class="tab-content">
            <div id="home" class="tab-pane fade in active ">
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
                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Font-Size="Small" Text="Add Remark" Width="104px" OnClick="Button3_Click" />
            </td>
        </tr>
    </table>
            </div>

            <div id="menu1" class="tab-pane fade in ">
                <h3>Menu</h3>
                
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
                                <asp:Button ID="Button4" runat="server" Text="Submit" BorderStyle="Double" Height="47px" Width="114px" OnClick="Button1_Click" />
                                <br />
                            </td>

                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel><br />
                
            </div>
        </div>
    </div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

</asp:Content>

