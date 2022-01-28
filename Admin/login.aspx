<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Netflix_clone.Admin.signIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN</title>
    <link href="../signIn.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="loginContainer">
            <div class="content">
                <div class="title">
                      <h3>Admin</h3>
                </div>
                <div class="inputs">
                <asp:TextBox  ID="txtemail" runat="server" placeholder="Email or Phone number"></asp:TextBox>
                    
                <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                  
                <asp:Button ID="btnSignIn" runat="server" Text="Login" OnClick="btnSignIn_Click"  />
                </div>
                              
            </div>
        </div>
    </form>
</body>
</html>
