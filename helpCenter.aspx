<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="helpCenter.aspx.cs" Inherits="Netflix_clone.helpCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Help Center</title>
  
    <link href="helpCenter.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="title">
                <h2>Help Center</h2>
            </div>
            <div class="cards">

                <div class="call">
                    <h3>Call Us</h3>
                    <span>Contact Netflix,<br />
                        Customer Service
                    </span>
                    <p>We will connect a call to help you</p>
                    <span>Click Here to Call </span>
                    <button class="btnCall" id="btnCall">                       
                        <a href="tel:+917048216843">Call</a>
                    </button>
                </div>

                  <div class="privacy">
                    <h3>Netflix-Clone Privacy Statent</h3>

                    <span>Click Here to look privacy <br /> statements. </span>
                    <asp:Button Text="Privacy" ID="btnPrivacy" runat="server" OnClick="btnPrivacy_Click" />
                </div>

                <div class="email">
                    <h3>Email Us</h3>
                    <span>Contact Netflix,<br />
                        Customer Service
                    </span>
                    <p>We will connect a mail to help you</p>
                    <span>Click Here to send Mail </span>
                    <asp:Button Text="Email" ID="btnEmail" runat="server" OnClick="btnEmail_Click" />
                </div>
              
            </div>
        </div>
    </form>
</body>
</html>
