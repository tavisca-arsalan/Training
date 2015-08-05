<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HrNavTab.ascx.cs" Inherits="RollBaseAcess._1.View.WebUserControl1" %>
<link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <div class="container">
        <ul class="nav nav-tabs">
            <li ><a href="http://localhost:50746/HR/AddRemark.aspx">Add Remark</a></li>
            <li><a href="http://localhost:50746/HR/AddEmployee.aspx">Add Employee</a></li>
             <li><a href="http://localhost:50746/1.View/ChangePassword.aspx">Chanage Password</a></li>
            <li><a ><asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" /></a></li>
        </ul>

        
        </div>
    </div>




    <!-- Tab panes -->
    <!--div class="tab-content">
    <div role="tabpanel" class="tab-pane active" id="home">...</div>
    <div role="tabpanel" class="tab-pane" id="profile">...</div>
    <div role="tabpanel" class="tab-pane" id="messages">...</div>
    <div role="tabpanel" class="tab-pane" id="settings">...</div>
  </div-->


    
    
</asp:Content>
