<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="Error_ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hightlight - Error 404</title>
    <style>
        @import url("https://fonts.googleapis.com/css?family=Comfortaa");
        @import url("https://fonts.googleapis.com/css?family=Josefin+Sans:300");
        body {
          display: flex;
          justify-content: center;
          align-items: center;
          height: 100vh;
          background: linear-gradient(90deg, #454b4c, #babbbc);
        }

        .circle {
          height: 500px;
          width: 500px;
          border-radius: 50%;
        }
        .circle:before {
          position: absolute;
          height: 530px;
          width: 530px;
          margin: -15px 0 0 -15px;
          border-radius: 50%;
          background: linear-gradient(90deg, #9b16bc, #ca204a);
          animation: a 1750ms infinite;
          animation-timing-function: linear;
          content: "";

        }
        .circle:after {
          position: absolute;
          display: flex;
          justify-content: center;
          align-items: center;
          height: 500px;
          width: 500px;
          border-radius: 50%;
          background: #d1d1d1;
          cursor: pointer;
          transition: background 800ms ease-in-out;
          font-family: 'Josefin Sans';
          font-size: 24px;
          font-weight: bold;
          text-decoration:none;
          content: "Click to return home";
        }
        .circle:hover:after {
          background: white;
        }

        h1, img, h2 {
            position:absolute;
        }

        h1{
            margin-top:-80px;
            font-family: 'Josefin Sans';
            font-size: 26px;
            font-weight: bold;
        }

        img {
            margin-top:90px;
        }

        h2 {
            margin-top:160px;
            font-family: 'Josefin Sans';
            font-size: 18px;
            font-weight: bold;
        }

        @keyframes a {
          0% {
            transform: rotate(0deg);
          }
          100% {
            transform: rotate(360deg);
          }
        }
    </style>
</head>
<body>
    <a href="../Page/New.aspx" class="circle"></a>
    <h1>Highlight</h1>
    <img src="/images/dead.png" height="80"/>
    <h2>Error</h2>
</body>
</html>
