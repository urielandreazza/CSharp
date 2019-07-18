<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recepit.aspx.cs" Inherits="UrielAndreazzaAssignment2.recepit" %>

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
    
            .auto-style1 {
                width: 207px;
            }
    
        </style>

    <title>Recepit</title>
</head>
<body>
     <form id="form1" runat="server">
    <div id="register" class="z-depth-3" style="width: 400px; margin-top: 200px; margin-left: auto; margin-right: auto; margin-bottom: 0;padding: 25px 25px 25px 25px">
           <div class="row">
               <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Receipt"></asp:Label>
            </div>
              <table class="pagination">
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label2" runat="server" Text="Movie:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbMovie" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label3" runat="server" Text="Day:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbDay" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label6" runat="server" Text="Time:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbTime" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="lbGADesc" runat="server" Text="General Admision :"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbGA" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="lbSCDesc" runat="server" Text="Senior and Children :"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbSC" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label7" runat="server" Text="Cost:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbCost" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label8" runat="server" Text="Discount:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbDisc" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style1">
                          <asp:Label ID="Label9" runat="server" Text="Total:"></asp:Label>
                      </td>
                      <td>
                          <asp:Label ID="lbTotal" runat="server" Text="Label"></asp:Label>
                      </td>
                  </tr>
           </table>
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/landingPage.aspx">Home</asp:HyperLink>
          </div>

    </form>
</body>
</html>
