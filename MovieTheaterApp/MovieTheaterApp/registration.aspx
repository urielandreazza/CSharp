<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="UrielAndreazzaAssignment2.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <!-- Materialize CSS stylesheet-->
    <link href="content/css/materialize.min.css" rel="stylesheet"/>

    <!-- Materialize JS source Script Files -->
    <script src="content/js/materialize.min.js"></script>

    <link rel = "stylesheet" href = "https://fonts.googleapis.com/icon?family=Material+Icons"/>

        <style>

        #register{background-color:white}
        body{background-color:lightblue}
    
        </style>

    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="register" class="z-depth-3" style="width: 400px; margin-top: 200px; margin-left: auto; margin-right: auto; margin-bottom: 0;padding: 25px 25px 25px 25px">
           <div class="row">
               <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Register"></asp:Label>
            </div>
              <div class="row">
                <div class="input-field col s6">
                  <input id="first_name" type="text" name="fname" class="validate"/>
                  <label for="first_name">First Name</label>
                </div>
                <div class="input-field col s6">
                  <input id="last_name" type="text" name="lname" class="validate"/>
                  <label for="last_name">Last Name</label>
                </div>
              </div>
              <div class="row">
                <div class="input-field col s12">
                  <input id="password" type="password" name="pw" class="validate"/>
                  <label for="password">Password</label>
                </div>
              </div>
              <div class="row">
                <div class="input-field col s12">
                  <input id="email" type="email" name="email" class="validate"/>
                  <label for="email">Email</label>
                </div>
              </div>
            <asp:Button ID="Button1" class="btn" runat="server" Text="REGISTER" Height="40px" OnClick="Button1_Click" Width="350px" />
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/landingPage.aspx">Home</asp:HyperLink>
          </div>

    </form>

</body>
</html>
