﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="UrielAndreazzaAssignment2.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
     <!-- Materialize CSS stylesheet -->
    <link href="content/css/materialize.min.css" rel="stylesheet"/>

    <!-- Materialize JS source Script Files -->
    <script src="content/js/materialize.min.js"></script>

    <link rel = "stylesheet" href = "https://fonts.googleapis.com/icon?family=Material+Icons"/> 

          <style>

        #admin{background-color:white}
        body{background-color:lightblue}
    
        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="admin" class="z-depth-3" style="width: 800px; margin-top: 100px; margin-left: auto; margin-right: auto; margin-bottom: 0;padding: 25px 25px 25px 25px;">

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="userID" DataSourceID="SqlDataSource1" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True">
                <Columns>
                    <asp:BoundField DataField="userID" HeaderText="userID" InsertVisible="False" ReadOnly="True" SortExpression="userID" />
                    <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                    <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                    <asp:BoundField DataField="role" HeaderText="role" SortExpression="role" />
                    <asp:BoundField DataField="pw" HeaderText="pw" SortExpression="pw" />
                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MovieTeatherConnectionString %>" SelectCommand="SELECT * FROM [users]" DeleteCommand="DELETE FROM [users] WHERE [userID] = @userID" InsertCommand="INSERT INTO [users] ([fname], [lname], [role], [pw], [email]) VALUES (@fname, @lname, @role, @pw, @email)" UpdateCommand="UPDATE [users] SET [fname] = @fname, [lname] = @lname, [role] = @role, [pw] = @pw, [email] = @email WHERE [userID] = @userID">
                <DeleteParameters>
                    <asp:Parameter Name="userID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="fname" Type="String" />
                    <asp:Parameter Name="lname" Type="String" />
                    <asp:Parameter Name="role" Type="String" />
                    <asp:Parameter Name="pw" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="fname" Type="String" />
                    <asp:Parameter Name="lname" Type="String" />
                    <asp:Parameter Name="role" Type="String" />
                    <asp:Parameter Name="pw" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="userID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

            <br />
            <asp:Label ID="Label7" runat="server" Font-Size="XX-Large" Text="Add New User"></asp:Label>
            <br />

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="tbFname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="tbLname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Role"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddRole" class="browser-default" runat="server">
                            <asp:ListItem>user</asp:ListItem>
                            <asp:ListItem>admin</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
                        <br />
                        <asp:TextBox ID="tbPw" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
                        <br />
                        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" class="btn" runat="server" Text="Add" Width="122px" OnClick="Button1_Click" />

            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/landingPage.aspx">Login Page</asp:HyperLink>

        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/movies.aspx">Movie Page</asp:HyperLink>

        </div>
    </form>
</body>
</html>
