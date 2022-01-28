<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Netflix_clone.home1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="mainView MagicScroll" data-options="autoplay: 2000; step: 1; mode: carousel; height:400px;">

            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money5.jpg" />
            </a>
            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money1.jpg" />
            </a>
            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money2.jpg" />
            </a>
            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money3.jpg" />
            </a>
            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money4.jpg" />
            </a>
            <a href="https://www.youtube.com/embed/htqXL94Rza4">
                <img src="images/posters/money6.jpg" />
            </a>

        </div>

        <div class="trendingNow">
            <div class="title">
                Trending Now
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_trending" runat="server">
            </div>

        </div>

        <div class="onlyOnNetflix">
            <div class="title">
                Only On Netflix
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_only_on_netflix" runat="server">
            </div>
        </div>

          <div class="movieRomance">
            <div class="title">
                Romance
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="poster_romance" runat="server">
            </div>
        </div>

        <div class="sci-fi-movies">
            <div class="title">
                Sci-Fi
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_sci_fi" runat="server">
            </div>
        </div>

    </div>
</asp:Content>
