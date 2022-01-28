<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="favourite.aspx.cs" Inherits="Netflix_clone.favourite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
    <link href="favourite.css" rel="stylesheet" />
    <title></title>
  <%--  <script src="main.js" defer></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="navbar">
                 <div class="nav">

                        <div class="Netflix-logo">
                            <a href="home.aspx">   <img src="images/Netflix-logo.png" /></a>
                        </div>
                        <div class="links">
                            <ul>                   
                                 <li class="link"> <a href="tvShows.aspx">Tv Shows</a></li>
                                 <li class="link"> <a href="movies.aspx">Movies</a></li>
                                 <li class="link"> <a href="popular.aspx">New & Popular</a></li>
                                <%-- <li class="link"> <a href="favourite.aspx">Favourites</a></li>--%>
                                 <li class="link"> <a href="contactUs.aspx">Contact Us</a></li>
                            </ul>
                        </div>
                 </div>
                       
                       <div class="profile">
                            <div class="name">
                                <asp:LinkButton ID="profileName" runat="server" OnClick="profileName_Click"></asp:LinkButton>
                            </div>
                            <div class="profileAction" id="profileAction" runat="server">
                             <span id="btnClose" ><i class="far fa-times-circle"></i></span>
                            </div>
                        </div>
                    </div>

            <div class="main-content">
                
         </div>


             <div class="footer">
                <div class="footerMain">
                    <div class="logo">
                       <img src="images/Netflix-logo.png" />

                    </div>
                    <div class="links">
                        <a href="home.aspx">Home</a>
                        <a href="privacy.aspx">Privacy</a>
                        <a href="contactUs.aspx">Contact Us</a>
                        <a href="helpCenter.aspx">Help Center</a>

                    </div>
                </div>
                <div class="footerSocial">
                    <div class="icons">
                       <a href="https://www.facebook.com/Netflix-clone-105419671913927/">  <img src="images/social/facebook-icon.png" /></a>
                        <a href="https://twitter.com/netflix_clone">  <img src="images/social/twitter-icon.png" /></a>
                        <a href="https://www.instagram.com/___shootout___123/">  <img src="images/social/instagram-icon.png" /></a>
                    </div>
                    <div class="copyright">
                         Copyrights ©2021. All rights reserved.
                    </div>
                </div>
            </div>

        </div>
    </form>
    <script>
        const btnClose = document.querySelector("#btnClose")
        const profileAction = document.querySelector("#profileAction")

        btnClose.addEventListener("click", () => {
            profileAction.style.display = "none";
        })

    </script>
</body>
</html>
