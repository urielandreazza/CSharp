<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="landingPage.aspx.cs" Inherits="UrielAndreazzaAssignment2.landingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <!-- Materialize CSS stylesheet-->
    <link href="content/css/materialize.min.css" rel="stylesheet"/>

    <!-- Materialize JS source Script Files -->
    <script src="content/js/materialize.min.js"></script>

    <link rel = "stylesheet" href = "https://fonts.googleapis.com/icon?family=Material+Icons"/>

    <style>

        #login{background-color:white}
        body{background-color:lightblue}
    </style>

    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <div id="login" class="z-depth-3" style="height: 425px; width: 400px; margin-top: 200px; margin-left: auto; margin-right: auto; margin-bottom: 0;padding: 25px 25px 25px 25px">

                        <div>
                            <i class="material-icons center">account_circle</i> <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="LOGIN"></asp:Label>
                            <br />
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>     
                            <br />
                            <asp:TextBox ID="tbEmail" runat="server" Width="290px"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                            <br />
                            <asp:TextBox ID="tbPw" runat="server" TextMode="Password" Width="289px"></asp:TextBox>
                            <br />
                            <asp:Button ID="btnLogin" class="btn" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            <br />
                            <br />
                            <p><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/registration.aspx">Register</asp:HyperLink></p>
                            <p><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/movies.aspx" OnPreRender="hyperLink_PreLoad">Continue without Loging</asp:HyperLink></p>
                        </div>                     
         </div>
        </div>
    </form>
</body>
</html>
