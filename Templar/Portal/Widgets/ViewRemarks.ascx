<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewRemarks.ascx.cs" Inherits="Tavisca.EMS.ViewRemarks" %>

<%@ Register Assembly="Tavisca.Templar.WebControls" Namespace="Tavisca.Templar.WebControls" TagPrefix="gtc" %>

<asp:Panel ID="Panel1" runat="server" Visible="false" Height="351px" Width="351px">
    <gtc:TemplarLabel ID="viewRemark" runat="server" Text="View Remark" Style="margin-left: 100px">
    </gtc:TemplarLabel>
    <br />
    <asp:Table ID="Table1" runat="server" ValidateRequestMode="Disabled" Height="63px">
        <asp:TableRow>
            <asp:TableCell>
                <gtc:TemplarLabel ID="TemplarlabelEnterId" runat="server" Text="Enter Id">
                </gtc:TemplarLabel>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxId" runat="server"> </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" 
                    ControlToValidate="TextBoxId"></asp:RequiredFieldValidator>
            </asp:TableCell>
            </asp:TableRow>
    </asp:Table>
    <asp:GridView ID="GridViewRemark" runat="server" AllowCustomPaging="True" AllowPaging="True" AutoGenerateColumns="False"
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2"
        ForeColor="Black" Height="16px" HorizontalAlign="Left" PageSize="5" Width="220px" OnSelectedIndexChanged="GridViewRemark_SelectedIndexChanged" 
        OnSelectedIndexChanging="GridViewRemark_SelectedIndexChanging" >
        <Columns>
            <asp:BoundField DataField="Text" HeaderText="Remark" SortExpression="Text" />
            <asp:BoundField DataField="TimeStamp" HeaderText="TimeStamp" SortExpression="TimeStamp" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
    <asp:Repeater ID="RepeaterPage" runat="server" OnItemCommand="Repeater1_ItemCommand">
       <ItemTemplate>
           <asp:LinkButton ID="LinkBotton" runat="server"
               Text='<%#Eval("Text") %>' CommandArgument='<%# Eval("Value") %>'
               Enabled='<%# Eval("Enabled") %>' OnClick="LinkBotton_Click" >
           </asp:LinkButton>
       </ItemTemplate>
   </asp:Repeater>
</asp:Panel>