<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="moviesList.aspx.cs" Inherits="Netflix_clone.Admin.moviesList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie List</title>
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
#uploadMovie,#uploadTvShow,#tvShowsList{
    text-decoration:none;
    color:white;
    padding:10px 15px;
    border-radius:5px;
}
#uploadMovie:hover,#uploadTvShow:hover,#tvShowsList:hover{
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

/* td:nth-of-type(even){
    background-color: rgba(157, 221, 246, 0.959);
} */
/*tr:nth-of-type(odd){
    background-color: rgba(155, 200, 245, 0.959);
}
tr:nth-of-type(even){
    background-color: rgba(141, 170, 199, 0.959);
}*/

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
                <h3>Movies List</h3> 
                <div class="btnUpload">                     
                <asp:HyperLink ID="uploadMovie" runat="server" NavigateUrl="~/Admin/uploadMovie.aspx">Upload Movie</asp:HyperLink>
                    <asp:HyperLink ID="uploadTvShow" runat="server" NavigateUrl="~/Admin/uploadTvShow.aspx">Upload Tv Show</asp:HyperLink>
                    <asp:HyperLink ID="tvShowsList" runat="server" NavigateUrl="~/Admin/tvShowsList.aspx">Tv Shows List</asp:HyperLink>

                </div>
                <asp:Button ID="btnLogOut" runat="server" Text="Log Out" OnClick="btnLogOut_Click" />
               
            </div>

            <asp:Table ID="myTable" Width="100%" runat="server">
                    <asp:TableRow ID="heading">
                    <asp:TableCell>ID</asp:TableCell>
                    <asp:TableCell>Title</asp:TableCell>
                  <%--  <asp:TableCell>Description</asp:TableCell>--%>
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
        <%--<table>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Title</th>
                    <th>Description</th>
                    <th>Category</th>
                    <th>Director</th>
                    <th>Actors</th>
                    <th>Producer</th>
                    <th>Watch Time</th>
                    <th>Release Date</th>
                    <th>videoLink</th>
                    <th>Rating</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                  <tr id="row" runat="server">
                     <td id="id" runat="server"></td>
                      <td id="title" runat="server"></td>
                      <td id="description" runat="server"></td>
                      <td id="category" runat="server"></td>
                      <td id="director" runat="server"></td>
                      <td id="actors" runat="server"></td>
                      <td id="producer" runat="server"></td>
                      <td id="watchTime" runat="server"></td>
                      <td id="releaseDate" runat="server"></td>
                      <td id="videoLink" runat="server"></td>
                      <td  id="btn">
                         <asp:Button ID="btnEdit" runat="server" Text="EDIT"  />
                          <asp:Button ID="btnDelete" runat="server" Text="DELETE" />
                      </td>
                      <td id="rating" runat="server"></td>
                  </tr>
            </tbody>
        </table>
        --%>    <div id="txtNothing" runat="server"></div>
        </div>
    </form>
</body>
</html>
