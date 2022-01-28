<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="tvShows.aspx.cs" Inherits="Netflix_clone.tvShows" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="mainView MagicScroll" data-options="autoplay: 2000; step: 1; mode: carousel; height:400px;">

            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends5.jpg" /></a>
            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends1.jpg" /></a>
            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends2.jpg" /></a>
            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends3.jpg" /></a>
            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends4.jpg" /></a>

            <a href="https://www.youtube.com/embed/MHmpgZnGJxI">
                <img src="images/posters/tvShows/friends6.jpg" /></a>
        </div>

        <div class="trendingNow">
            <div class="title">
                Trending Now
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_trending" runat="server">
            </div>
        </div>
        <div class="romance-movies">
            <div class="title">
                Romance 
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_romance" runat="server">
            </div>
        </div>
        <div class="sci-fi-movies">
            <div class="title">
                Sci-Fi 
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_sci_fi" runat="server">
            </div>
        </div>
        <div class="thriller-movies">
            <div class="title">
                Thriller 
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_thriller" runat="server">
            </div>
        </div>
        <div class="adventure-movies">
            <div class="title">
                Advenure 
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_adventure" runat="server">
            </div>
        </div>
        <div class="comedy-movies">
            <div class="title">
                Comdey 
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_comedy" runat="server">
            </div>
        </div>

    </div>
</asp:Content>
