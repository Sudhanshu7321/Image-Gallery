<%@ Page Title="" Language="C#" MasterPageFile="~/index.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <body style="background-color:#ECF2FF;">
      <!--    Navigation Bar Start -->
    <nav class="navbar" style="background-color:#3E54AC;">
        <div class="container-fluid">
            <a class="navbar-brand ms-5" style="color:white;font-family:'Times';font-size:30px;" href="#">Image Gallery</a
        </div>
    </nav>
       <!--    Navigation Bar End -->

       <!--    Thumbnail Start -->
     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <div class="container pt-5"><br />
        <div class="container-fluid">
            <!-- Image grid Dynamically -->
            <div runat="server" id="photos"></div>
        </div>
    </div>
       <!--    Thumbnail End -->
   
</body>
</asp:Content>

