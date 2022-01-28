<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateProfile.aspx.cs" Inherits="Netflix_clone.updateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Profile</title>
    <link href="profile.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <div class="contentUP">
                <h3>Update Profile</h3>
            <asp:TextBox ID="txtName" runat="server" placeholder="Name" ></asp:TextBox>
           
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password"  ></asp:TextBox>
           
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </div>
        </div>
    </form>
</body>
</html>
