<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DemoPage.ascx.cs" Inherits="DemoWidget.DemoPage" %>
<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="pnlSettings" runat="server" Height="345px" Width="409px" Visible="false">
    <form id="form1" runat="server" style="height: 340px; width: 412px;">
        <div class="cal">
            <gtc:TemplarLabel ID="CALCULATOR" runat="server" Text="Calculator" Style="margin-left: 150px">
            </gtc:TemplarLabel>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Simple Calculator" />
            <br />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Scientific Calculator" />
            <br />
            <asp:TextBox ID="t" runat="server" Style="margin-left: 6px; margin-top: 24px;"
                Width="318px" Height="41px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="b1" Text="1" runat="server" Height="37px" Style="margin-left: 10px"
                Width="57px" />
            <asp:Button ID="b2" Text="2" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="b3" Text="3" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="add" Text="+" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <br />
            <asp:Button ID="b4" Text="4" runat="server" Height="37px" Style="margin-left: 10px"
                Width="57px" />
            <asp:Button ID="b5" Text="5" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="b6" Text="6" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="sub" Text="-" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <br />
            <asp:Button ID="b7" Text="7" runat="server" Height="37px" Style="margin-left: 10px"
                Width="57px" />
            <asp:Button ID="b8" Text="8" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="b9" Text="9" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="mul" Text="*" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <br />
            <asp:Button ID="b0" runat="server" Text="0" Height="37px" Style="margin-left: 10px"
                Width="57px" OnClick="b0_Click" />
            <asp:Button ID="clr" runat="server" Text="CLR" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="eql" runat="server" Text="=" Height="37px" Style="margin-left: 0px"
                Width="57px" />
            <asp:Button ID="div" Text="/" runat="server" Height="37px" Style="margin-left: 0px"
                Width="57px" />
        </div>
        <br />
       <asp:Label ID="Label1" runat="server" Text="" Visible="false"> </asp:Label>
    </form>
</asp:Panel>

