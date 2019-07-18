<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movies.aspx.cs" Inherits="UrielAndreazzaAssignment2.movies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movie Picker</title>

    <!-- Materialize CSS stylesheet -->
    <link href="content/css/materialize.min.css" rel="stylesheet"/>

    <!-- Materialize JS source Script Files -->
    <script src="content/js/materialize.min.js"></script>

    <script>
          document.addEventListener('DOMContentLoaded', function() {
            var datepicker = document.querySelectorAll('.datepicker');
            var instanceOfDatePicker = M.Datepicker.init(datepicker, {"autoClose":true});

              
            
            var dropDown = document.querySelectorAll('select');
            var instanceOfDropDown = M.FormSelect.init(dropDown, {});

          });
    </script>

        <style>

        #movie{background-color:white}
        body{background-color:lightblue}
            .auto-style1 {
                margin-left: 40px;
            }
            .auto-style2 {
                margin-left: 80px;
            }
    </style>

    <link rel = "stylesheet" href = "https://fonts.googleapis.com/icon?family=Material+Icons"/> 

</head>
<body>
    <form id="form1" runat="server">
                   <nav>
                    <div class="nav-wrapper" style="padding: 10px 10px 10px">
                      
                        <asp:Label ID="welcomeLabel"  class="center-align" runat="server" Text="Label" Font-Size="XX-Large"></asp:Label>
                      
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="adminLink" class="admin" runat="server" NavigateUrl="~/admin.aspx">Admin</asp:HyperLink>
                      
                    &nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/landingPage.aspx" OnPreRender="HyperLink1_PreRender">Logout</asp:HyperLink>
                      
                    </div>
                  </nav>
            <div id="movie" class="z-depth-3" style=" width: 800px; margin: 0 auto; margin-top: 100px;padding-left:25px; padding-right:25px;">
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style1">
                            <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="~/content/images/CaptainMarvel.jpg" Width="337px" />
                        </td>
                        <td>
                            <table class="pagination">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label1" runat="server" Text="Select a Day:"></asp:Label>
                                    </td>
                                    <td class="auto-style2">
                                    <asp:TextBox ID="tbDate" runat="server" type="text" class="datepicker">Mar 26, 2019</asp:TextBox>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label2" runat="server" Text="Pick a Session:" AutoPostBack="True"></asp:Label>
                                    </td>
                                    <td class="auto-style2">
                                        <asp:DropDownList ID="timePicker" runat="server" AutoPostBack="True" >
                                            <asp:ListItem>1:30 PM</asp:ListItem>
                                            <asp:ListItem>3:30 PM</asp:ListItem>
                                            <asp:ListItem>5:30 PM</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2" colspan="2">
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="Label3" runat="server" Text="Tickets:" Font-Bold="True" Font-Size="Large"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label4" runat="server" Text="General Admission:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddGA" runat="server" OnSelectedIndexChanged="ddGA_SelectedIndexChanged" AutoPostBack="True" >
                                            <asp:ListItem Selected="True">0</asp:ListItem>
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label5" runat="server" Text="Senior Or Children:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddSC" runat="server" OnSelectedIndexChanged="ddSC_SelectedIndexChanged" AutoPostBack="True">
                                            <asp:ListItem>0</asp:ListItem>
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label7" runat="server" Text="Discount:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbTotalDiscount" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label6" runat="server" Text="Total:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbTotal" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                </table>
                            <br />
                           <asp:Button ID="Button1" class="btn" runat="server" OnClick="Button1_Click" Text="Buy Tickets" Height="32px" />
                        </td>
                    </tr>
                </table>
            </div>
    </form>
</body>
</html>
