<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="popular.aspx.cs" Inherits="Netflix_clone.Popular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h3 style="color:#FFFFFF;padding-left:10px;">Tv Shows</h3>
         <div class="netflix-show">
            <div class="title">
                    New on Netflix
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_netflixShow" runat="server">
            </div>
        </div>
         <div class="trendingNow">
            <div class="title">
                 Trending Now
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_trendingShow" runat="server">
            </div>
        </div>
          <h3 style="color:#FFFFFF;padding-left:10px">Movies</h3>
         <div class="netflix-movies">
            <div class="title">
                   New on Netflix
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_netflixMovie" runat="server">
            </div>
        </div>
         <div class="trendingNow">
            <div class="title">
                 Trending Now
            </div>
            <div class="posters MagicScroll" data-options="items:5;loop:off;" id="posters_trendingMovie" runat="server">
            </div>
        </div>
    </div>

</asp:Content>
