<%@ Page Language="C#" AutoEventWireup="true" CodeFile="New.aspx.cs" Inherits="Page_New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="/StyleSheets/New.css"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <script>

        $(function b() {
            $('#reg1 a').on('click', function() {
                $('#reg1').css({ "animation": "FadeOut 400ms forwards", "display": "none" });
                $('#reg2').css({ "animation": "FadeIn 400ms forwards", "display": "block" });
            });

            $('#reg2 a').on('click', function () {
                $('#reg2').css({ "animation": "FadeOut 400ms forwards", "display": "none" });
                $('#reg1').css({ "animation": "FadeIn 400ms forwards", "display": "block" });
            });

            $('.button').on('click', function () {
                $('#reg1').css({ "animation": "SlideDown 1000ms forwards", "display": "block" });
            })

            $('#close1').on('click', function () {
                $('#reg1').css({ "animation": "SlideUp 1000ms forwards"});
            })

            $('#close2').on('click', function () {
                $('#reg2').css({ "animation": "SlideUp 1000ms forwards" });
            })
        })

    </script>

    <script src="/Scripts/UserAuthentication.js"></script>

    <title>Highlight - Home</title>
</head>
<body>

    <form class="reg-log" id="reg1" method="post">
        <div class="reg">
            <h1>Create an account</h1>

            <div class="reg-break"></div>

            <h3>Username :</h3>
            <input name="username" id="username" type="text" placeholder="Enter your username"/><br/><span class="error" id="username-error">Username length must be between 4 - 12 letters</span><br/><br/><br/>

            <h3>Email :</h3>
            <input name="email" id="email" type="text" placeholder="Enter your email adress"/><br/><span class="error" id="email-error">Email must containt only 1 '@' </span><br/><br/><br/>

            <h3>Region :</h3>
            <select name="region">
                <option>Europe</option>
                <option >Oceania</option>
                <option>North America</option>
                <option>South America</option>
                <option>Asia</option>
                <option>South East Asia</option> 
            </select>
            <span class="error">Please Choose your region</span><br/><br/>

            <h3>Password :</h3> 
            <input name="password" id="password" type="password" placeholder="Enter your password"/><br/><span class="error" id="password-error">Password length must be between 5 - 18 letters</span><br/><br/><br/>

            <h3>Re-enter password :</h3>
            <input name="password1" id="password1" type="password" placeholder="Re-enter your password"/><br/><span class="error" id="password-error1">Password must containt both letters and digits</span><br/><br/><br/><br/>

            <button class='btn1' name="submit1" onclick="return SignupValidation()">
            <div class='btn1-content1'>Sign up</div>
            <div class='btn1-b'></div>
            </button> 
            
            <span class="btn2">Already have an account? <a> Login </a></span><img class="exit-btn" id="close1" src="/images/exit.png" height="12"/>
        </div>

        <div class="margin">
        </div>

        <div class="info">
            <h1>Why create an account?</h1>
            <p>
                Highlight is a website where you can find everybody's favourite monthly TV series, Movies, Video Games, App and more. Besides that, every month YOU can choose your own favourite TV series, Video games etc. Highlight is a FREE website where everybody can make their own Account. Get started by Creating your own Account now!
            </p>
        </div>
    </form>

    <form class="reg-log" id="reg2" method="post">
        <div class="reg">
            <h1>Log in</h1>

            <div class="reg-break"></div>

            <h3>Username :</h3>
            <input name="username0" id="username0" type="text" placeholder="Enter your username"/><br/><span class="error" id="username-error0">Username length must be between 4 - 12 letters</span><br/><br/><br/>

            <h3>Password :</h3> 
            <input name="password0" id="password0" type="password" placeholder="Enter your password"/><br/><span class="error" id="password-error0"></span><br/><br/><br/>
            <br/>

            <button class='btn1' name="submit2" onclick="return SignupValidation1()">
            <div class='btn1-content1'>Sign in</div>
            <div class='btn1-b'></div>
            </button> 

            <span class="btn2">Dont have an account yet? <a> Signup </a></span><img class="exit-btn" id="close2" src="/images/exit.png" height="12"/>
        </div>

        <div class="margin">
        </div>

        <div class="info">
            <h1>Why create an account?</h1>
            <p>
                Highlight is a website where you can find everybody's favourite monthly TV series, Movies, Video Games, App and more. Besides that, every month YOU can choose your own favourite TV series, Video games etc. Highlight is a FREE website where everybody can make their own Account. Get started by Creating your own Account now!
            </p>
        </div>
    </form>

    <div class="title">
        <h1>Highlight</h1><br/>
        <h2>The monthly trending Movie, TV Series, Video game and more!</h2>
    </div>

    <div class="content">
        <div class="button">
          <div class="overlay">
            Get Started
          </div>
        </div>
    </div>
</body>
</html>
