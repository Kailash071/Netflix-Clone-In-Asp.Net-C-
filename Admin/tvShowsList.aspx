<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tvShowsList.aspx.cs" Inherits="Netflix_clone.Admin.tvShowsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tv Shows List</title>
     <style>
        @import url('https://fonts.googleapis.com/css2?family=Quicksand:wght@600&display=swap');
body{
    width:100%;
height:100%;
    background-color:#000;
    color:#FFFF;
    font-family:Quicksand;
    margin:0;
    padding:0;
}
.container{
width:inherit;
height:inherit;
display:flex;
flex-direction:column;
}
.nav{
    width:100%;
    height:50px;
    display:flex;
   justify-content:space-between;
    align-items:center;
    margin:5px 0;
    
}
.btnUpload{
    display:flex;
    justify-content:center;
    align-items:center;
    gap:10px;
}
#uploadTvShow,#uploadMovie,#moviesList{
    text-decoration:none;
    color:white;
    padding:10px 15px;
    border-radius:5px;
}
#uploadTvShow:hover,#uploadMovie:hover,#moviesList:hover{
    border-bottom:2px solid red;
}
table{   
    width:100vw;
    font-family: Quicksand;
    font-size: 1rem;
    /* background-color: rgba(246, 245, 245, 0.692); */
    border-radius: 10px;
    
}

#heading>td{
    color:black;
    background-color:white;
    border-radius:8px;
}

td{
   text-align: center;
   padding:2px 5px;
   
 border-collapse: separate;
 background-color:#000;
 color:#FFFF;
 border-bottom:1px solid lightgray;
}
td#videoLink{
    max-width:300px;
    text-overflow:ellipsis;
    overflow-wrap:break-word;
}

td#btn:hover{
    background-color:transparent;
}

td:hover{
    background-color: rgba(236, 236, 236, 0.252);
    
}
th{
    background-color:#000;
    padding-bottom: 15px;
 }

        #btn {
            display:flex;
            justify-content:center;
            align-items:center;
        }
       
#btnEdit,#btnDelete ,#btnLogOut{
    padding:12px 10px;
    border:none;
    border-radius:5px;
    outline:none;
    color:#FFFF;
    font-weight:700;
    background-color:red;
    font-family:Quicksand;
    font-size:1rem;
    cursor:pointer; 
    margin:5px;
    
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="nav">
                <h3>Tv Shows List</h3> 
                <div class="btnUpload">
                     <asp:HyperLink ID="uploadTvShow" runat="server" NavigateUrl="~/Admin/uploadTvShow.aspx">Upload Tv Show</asp:HyperLink>
                      <asp:HyperLink ID="uploadMovie" runat="server" NavigateUrl="~/Admin/uploadMovie.aspx">Upload Movie</asp:HyperLink>
                      <asp:HyperLink ID="moviesList" runat="server" NavigateUrl="~/Admin/moviesList.aspx">Movies List</asp:HyperLink>
                </div>
               
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
               
            </div>

            <asp:Table ID="myTable" Width="100%" runat="server">
                    <asp:TableRow ID="heading">
                    <asp:TableCell>ID</asp:TableCell>
                    <asp:TableCell>Title</asp:TableCell>
                    <asp:TableCell>Category</asp:TableCell>
                    <asp:TableCell>Director</asp:TableCell>
                    <asp:TableCell>Actors</asp:TableCell>
                    <asp:TableCell>Producer</asp:TableCell>
                    <asp:TableCell>Watch Time</asp:TableCell>
                    <asp:TableCell>Release Date</asp:TableCell>
                    <asp:TableCell>Video Link</asp:TableCell>
                    <asp:TableCell>Action</asp:TableCell>  
                    </asp:TableRow>
            
            </asp:Table>
       <div id="txtNothing" runat="server"></div>
        </div>
    </form>
</body>
</html>
