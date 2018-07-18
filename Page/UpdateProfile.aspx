<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateProfile.aspx.cs" Inherits="Page_UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>Welcome...</title>    

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="../../Scripts/Style.js"></script>

    <script type="text/javascript">

        $(function WelcomeContent() {
            $(".welcome-content").show();
            $(".welcome-content").slideUp(0);
            $(".welcome-content").fadeIn(1500).delay(1000).fadeOut(1500);
        })

        function pageRedirect() {
            window.location.replace("Profile.aspx");
        }
        setTimeout("pageRedirect()", 4100);
    </script>
    <style>

    body {
        background: linear-gradient(90deg, #454b4c, #babbbc);
        font-family: 'Josefin Sans';
        margin-top: 54px;
        margin-left: 30vw;
    }
    .welcome-content {
        margin-top:100px;
    }
    #profile-picture{
        border-radius:50%;
    }
    h1 {
        position:relative;
        color: white;
        font-size: 100px;
        margin-left:320px;
        margin-top:-15px;
    }

    h2 {
        position: relative; 
        font-size: 50px;
        margin-left: 320px;
        margin-top:-225px;
        color: white;
    }
    </style>

    <link rel="stylesheet" type="text/css" href="../../StyleSheets/Welcome.css"/>
    <link href="https://fonts.googleapis.com/css?family=Dosis" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Josefin+Sans:300" rel="stylesheet"/>

</head>
<body>
    <div class="welcome-content">
        <img src="https://image.ibb.co/gnB4Z7/user_2.png" id="profile-picture" height="275"/>
        <h2>Account Information <br/><br/> Updated!</h2>
    </div>
</body>
</html>
