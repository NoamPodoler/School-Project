
function SignupValidation() {

    UsernameLength();
    EmailAt();
    PasswordLength();
    PasswordConfirmation();

    if (UsernameLength() && EmailAt() && PasswordLength() && PasswordConfirmation()) {
        return true;
    }
    else {
        return false;
    }
}

function UsernameLength() {
    var UserLength = document.getElementById('username').value.length;
    if (UserLength > 12) {
        $('#username-error').css({ "color": "#c41f98" });
        document.getElementById('username-error').innerHTML = ("Your Username is too long");
        return false;
    }
    else if (UserLength == 0) {
        $('#username-error').css({ "color": "#c41f98" });
        document.getElementById('username-error').innerHTML = ("Please enter your username");
        return false;
    }
    else if (UserLength < 3) {
        $('#username-error').css({ "color": "#c41f98" });
        document.getElementById('username-error').innerHTML = ("Your Username is too short");
        return false;

    }
    else {
        $('#username-error').css({"color":"white"});
        document.getElementById('username-error').innerHTML = ("Username length must be between 4 - 12 letters");
        return true;
    }
}

function EmailAt() {
    var EmailValue = document.getElementById('email').value;
    var x = 0;
    var y = 0;
    for (i = 0; i < EmailValue.length; i++) {
        if (EmailValue[i] == '@')
            y++;
        else
            x++;
    }
    if (x == EmailValue.length) {
        $('#email-error').css({ "color": "#c41f98" });
        document.getElementById('email-error').innerHTML = ("Your Email is missing a ''@'' ");
        return false;

    }
    if (y > 1) {
        $('#email-error').css({ "color": "#c41f98" });
        document.getElementById('email-error').innerHTML = ("Your Email contains more than one ''@''");
        return false;

    }
    else {
        $('#email-error').css({ "color": "white" });
        document.getElementById('email-error').innerHTML = ("Email must containt only 1 '@'");
        return true;
    }
}

function PasswordLength() {
    var PasswordLength = document.getElementById('password').value.length;
    if (PasswordLength > 4 && PasswordLength < 16) {
        $('#password-error').css({ "color": "white" });
        document.getElementById('password-error').innerHTML = ("Password length must be between 5 - 18 letters");
        return true;
    }
    else if (PasswordLength > 19) {
        $('#password-error').css({ "color": "#c41f98" });
        document.getElementById('password-error').innerHTML = ("Your Password is too long");
        return false;
    }
    else if (PasswordLength == 0) {
        $('#password-error').css({ "color": "#c41f98" });
        document.getElementById('password-error').innerHTML = ("Please insert your Password");
        return false;
    }
    else {
        $('#password-error').css({ "color": "#c41f98" });
        document.getElementById('password-error').innerHTML = ("Your Password is too short");
        return false;
    }
}

function PasswordConfirmation() {
    if (document.getElementById('password').value != document.getElementById('password1').value) {
        $('#password-error1').css({ "color": "#c41f98" });
        document.getElementById('password-error1').innerHTML = ("Passwords do not match");
        return false;
    }
    else {
        $('#password-error1').css({ "color": "white" });
        document.getElementById('password-error1').innerHTML = ("Password must containt both letters and digits");
        return true;
    }
}

//

function SignupValidation1() {

    UsernameLength1();
    PasswordLength1();

    if (UsernameLength1() && PasswordLength1()) {
        return true;
    }
    else {
        return false;
    }
}

function UsernameLength1() {
    var UserLength = document.getElementById('username0').value.length;
    if (UserLength > 12) {
        $('#username-error0').css({ "color": "#c41f98" });
        document.getElementById('username-error0').innerHTML = ("Your Username is too long");
        return false;
    }
    else if (UserLength == 0) {
        $('#username-error0').css({ "color": "#c41f98" });
        document.getElementById('username-error0').innerHTML = ("Please enter your username");
        return false;
    }
    else if (UserLength < 3) {
        $('#username-error0').css({ "color": "#c41f98" });
        document.getElementById('username-error0').innerHTML = ("Your Username is too short");
        return false;

    }
    else {
        $('#username-error0').css({ "color": "white" });
        document.getElementById('username-error0').innerHTML = ("Username length must be between 4 - 12 letters");
        return true;
    }
}

function PasswordLength1() {
    var PasswordLength = document.getElementById('password0').value.length;
    if (PasswordLength > 4 && PasswordLength < 16) {
        $('#password-error0').css({ "color": "white" });
        document.getElementById('password-error0').innerHTML = ("Password length must be between 5 - 18 letters");
        return true;
    }
    else if (PasswordLength > 19) {
        $('#password-error0').css({ "color": "#c41f98" });
        document.getElementById('password-error0').innerHTML = ("Your Password is too long");
        return false;
    }
    else if (PasswordLength == 0) {
        $('#password-error0').css({ "color": "#c41f98" });
        document.getElementById('password-error0').innerHTML = ("Please insert your Password");
        return false;
    }
    else {
        $('#password-error0').css({ "color": "#c41f98" });
        document.getElementById('password-error0').innerHTML = ("Your Password is too short");
        return false;
    }
}

function Region() {
    var region = document.getElementById('region').value;
    if (region == "Europe" || region == "North America" || region == "South America" || region == "Asia" || region == "South East Asia" || region == "Oceania") {
        $('#region-error').css({ "color": "#white" });
        document.getElementById('region-error').innerHTML = "Region must be : Europe, North America, South America, Asia, Oceania or South East Asia";
        return true;
    }
    else {
        $('#region-error').css({ "color": "#c41f98" });
        document.getElementById('region-error').innerHTML = "Region is incorrect";
        return false;
    }
}

function SignupValidation2() {

    UsernameLength();
    EmailAt();
    PasswordLength();
    Region();

    if (UsernameLength() && EmailAt() && PasswordLength() && Region()) {
        return true;
    }
    else {
        return false;
    }
}