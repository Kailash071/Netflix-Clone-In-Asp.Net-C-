<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadTvShow.aspx.cs" Inherits="Netflix_clone.Admin.uploadTvShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tv Show</title>
     <link href="Uploadmovie.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
          <div class="container">
            <div class="form-content">
                    <div class="form-control">
                        <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </div>
                   
                    <div class="form-control">
                        <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
                        <asp:DropDownList ID="DropDownCategory" runat="server">
                            <asp:ListItem >Romance</asp:ListItem>
                            <asp:ListItem>Sci-Fi</asp:ListItem>
                            <asp:ListItem>Netflix</asp:ListItem>
                            <asp:ListItem>Thriller</asp:ListItem>
                            <asp:ListItem>Comedy</asp:ListItem>
                            <asp:ListItem>Horror</asp:ListItem>
                            <asp:ListItem>Adventure</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblDirector" runat="server" Text="Director"></asp:Label>
                        <asp:TextBox ID="txtDirector" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblActors" runat="server" Text="Actors"></asp:Label>
                        <asp:TextBox ID="txtActors" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblProducer" runat="server" Text="Producer"></asp:Label>
                        <asp:TextBox ID="txtProducer" runat="server" ></asp:TextBox>
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblWatchTime" runat="server" Text="WatchTime"></asp:Label>
                        <asp:TextBox ID="txtWatchTime" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date"></asp:Label>
                        <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
                    </div>
               
                    <div class="form-control">
                        <asp:Label ID="lblPoster" runat="server" Text="Poster"></asp:Label>
                        <asp:FileUpload ID="PosterUpload" runat="server" />
                    </div>
                    <div class="form-control">
                        <asp:Label ID="lblVideoLink" runat="server" Text="Link"></asp:Label>
                        <asp:TextBox ID="txtVideoLink" runat="server" ></asp:TextBox>
                    </div>
                    <div class="buttons">
                        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
