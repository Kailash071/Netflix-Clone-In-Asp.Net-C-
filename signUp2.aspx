<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp2.aspx.cs" Inherits="Netflix_clone.signUp21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <a href="https://icons8.com/icon/2987/tv-show"></a>
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
                        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" />
                    </div>
                </nav>
            </div>
            <div class="content">
                <div class="main">
                    <div class="icon-tv">
                        <img src="https://img.icons8.com/ios/50/fa314a/tv-show.png"/>
                    </div>
                    <div class="step">
                        STEP 2 OF 3
                    </div>
                    <div>
                        Few steps to go
                    </div>
                <div>
                    <h3>Password</h3>
                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Create Password" autofocus></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click" />
                </div>
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
