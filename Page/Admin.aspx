<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Page_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="page-content" id="admin-page">

        <form method="post">

            <div class="search-bar">
                <button name="search-btn" style="color:black; background:white; border:solid white 1px;">Search</button><input type="text" name="search" style="width:400px;border:solid white 1px;"/>
            </div>

            <table>
                <tr>
                    <th>Num</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Region</th>
                    <th>Password</th>
                    <th>Rank</th>
                    <th style="width:100px;"></th>
                    <th style="width:100px;"></th>
                </tr>

                <%=PHolder%>
            </table>
            <%=PHolder1%>
        </form>
    </div>

</asp:Content>

