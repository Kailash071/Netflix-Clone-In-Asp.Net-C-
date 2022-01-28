<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="movies.aspx.cs" Inherits="Netflix_clone.movies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
         <div class="mainView  MagicScroll" data-options="autoplay: 2000; step: 1; mode: carousel; height:400px;">
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"><img src="images/posters/Movies/ff1.jpg" /></a>  
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"> <img src="images/posters/Movies/ff2.jpg" /></a> 
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"><img src="images/posters/Movies/ff3.jpg" /></a> 
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"><img src="images/posters/Movies/ff4.jpg" /></a> 
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"><img src="images/posters/Movies/ff5.jpg" /></a> 
             <a href="https://www.youtube.com/embed/FUK2kdPsBws"><img src="images/posters/Movies/ff6.jpg" /></a> 
             </div>

          
               <div class="onlyOnNetflix">
                    <div class="title">
                        Only On Netflix
                    </div>
                <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_only_on_netflix" runat="server">
                   
                   
                </div>            
                
            </div>  

             <div class="trendingNow">
                         <div class="title">
                            Trending Now
                        </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_trending"  runat="server">
                       
                    
                   </div>               
            </div>
            <div class="romance-movies">
                            <div class="title">
                               Romance 
                            </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_romance"  runat="server">                     
                        
                </div>
                </div>
                <div class="sci-fi-movies">
                            <div class="title">
                               Sci-Fi 
                            </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_sci_fi"  runat="server">                     
                        
                </div>
                </div>
               <div class="thriller-movies">
                            <div class="title">
                               Thriller 
                            </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_thriller"  runat="server">                     
                        
                </div>
                </div>
            <div class="adventure-movies">
                            <div class="title">
                               Advenure 
                            </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_adventure"  runat="server">                     
                        
                </div>
                </div>
            <div class="comedy-movies">
                            <div class="title">
                               Comdey 
                            </div>
                    <div class="posters MagicScroll"  data-options="items:5;loop:off;"  id="posters_comedy"  runat="server">                     
                        
                </div>
                </div>
               
    </div>
</asp:Content>
