<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="Netflix_clone.logIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="signIn.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="formContainer">
            <div class="content">
                <div class="title">
                      <h3>Sign In</h3>
                </div>
                <div class="inputs">
                <asp:TextBox  ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
                    
                <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                  
                <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
                <div class="forgetP">
                     <a href="forgetPassword.aspx">Forget Password?</a>
                </div>
                </div>
                
                <div class="alreadyAccount">
                    <h5>New to Netflix?</h5>
                    <a href="signUp1.aspx">Sign Up Now</a>
                </div>
               
            </div>
        </div>
    </form>
</body>
</html>
