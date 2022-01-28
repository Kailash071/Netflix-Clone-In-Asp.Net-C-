<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Netflix_clone.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile</title>
    <link href="profile.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="content">
                <h3>Profile</h3>
            <asp:TextBox ID="txtName" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server"  ReadOnly="True"></asp:TextBox>
            <div class="updateLink">
                <asp:LinkButton ID="link_update_profile" runat="server" OnClick="link_update_profile_Click">Update Profile</asp:LinkButton>
            </div>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            </div>
        </div>
    </form>
</body>
</html>
