<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signUp1.aspx.cs" Inherits="Netflix_clone.signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <a href="https://icons8.com/icon/20519/netflix"></a>
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
              
            <div class="step">
                STEP 1 OF 2
            </div>
            <div>
                <h1>Welcome, </br>
               
            </div>
            <div>
               Enter your email and you'll be watching in no </br> time.
            </div>
                  <div>
                      <h3>Name</h3>
                      <asp:TextBox ID="txtName" runat="server" placeholder="Name" autoFocus></asp:TextBox>
                    
                  </div>
            <div>
                <h3>Email</h3>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                
            </div>
                  <div>
                      <h3>Password</h3>
                      <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                  </div>
         
            <div>
                <asp:Button ID="btnNext" runat="server" Text="Create" OnClick="btnNext_Click" />
            </div>
           </div>
              </div>
        </div>
    </form>
</body>
</html>
