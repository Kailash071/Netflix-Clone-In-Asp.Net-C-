<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetPassword.aspx.cs" Inherits="Netflix_clone.forgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="signUp.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="FormContainer">
            <div class="navbar">
                <nav>
                    <div class="netflix-logo">
                        <img src="images/Netflix-logo.png" />
                    </div>
                    <div class="btn">
                        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
                    </div>
                </nav>
            </div>
            <div class="content">
                <div class="main">
                    <div>
                        <b>
                            Enter your email to verify your account First 
                        </b> 
                    </div>

                    <div>
                        <h3>Email</h3>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" TextMode="Email" autofocus></asp:TextBox>

                    </div>
                    <div>
                        <h3>Password</h3>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
                    </div>

                    <div>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update Password" OnClick="btnUpdate_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
