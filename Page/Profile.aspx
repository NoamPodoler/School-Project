<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="Page_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="page-content" id="admin-page">

        <form method="post">

            <div class="search-bar">
                <button name="search-btn" style="color:black; background:white; border:solid white 1px;">Search</button><input type="text" name="search" style="width:400px;border:solid white 1px;"/>
            </div>

            <table>
                <tr>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Region</th>
                    <th>Password</th>
                    <th style="width:100px;"></th>
                </tr>

                <%=PHolder1%>
            </table>
                <%=PHolder2%>
        </form>
    </div>

</asp:Content>

