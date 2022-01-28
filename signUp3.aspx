<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp3.aspx.cs" Inherits="Netflix_clone.signUp2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <a href="https://icons8.com/icon/102698/instagram-check-mark"></a>
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
                    <%--<div class="btn">
                        <asp:Button ID="btnSignIn" runat="server" Text="Sign In" />
                    </div>--%>
                </nav>
            </div>
            <div class="content">
              <div class="main">
                <div class="icon-tick">
                    <img src="https://img.icons8.com/ios/50/fa314a/instagram-check-mark.png"/>
                </div>
                <div>
                    <h5>STEP 2 OF 2</h5>
                </div>
                <div>
                    <h2>NETFLIX</h2><h3>AND</h3><h2> CHILL</h2>
                </div>
                    <div class="bullets">
                        <div class="bullet"><img src="https://img.icons8.com/fluency-systems-regular/50/fa314a/double-tick.png"/>
                            <h3>No ads and no fees. Ever.</h3>
                        </div>
                         <div class="bullet"><img src="https://img.icons8.com/fluency-systems-regular/50/fa314a/double-tick.png"/>
                            <h3>Everything on Netflix for free.</h3>
                        </div>
                        <div class="bullet"><img src="https://img.icons8.com/fluency-systems-regular/50/fa314a/double-tick.png"/>
                            <h3>Enjoy Quality Streaming.</h3>
                        </div>
                    </div>
                    <div class="btn">
                        <asp:Button ID="btnFinish" runat="server" Text="Finish" OnClick="btnFinish_Click" />
                    </div>
                <div>
            </div>
        </div>
    </form>
</body>
</html>
