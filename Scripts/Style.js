
$(function NavigationBarAnimation() {

    // Variables Saved
    var MenuClicks = 0;
    var LinkClicks = 0;

    $('.menu-icon').on('click', function a() {
        MenuClicks++;
        AnimationFunction();
    });

    function Trigger1LeftNavBar() {

        $('.left-navigation-bar').css({ "animation": "fadeInLeft 800ms forwards", "animation-delay": "400ms", "display": "block" });
        $('.expand-navbar').css({ "display": "block" });
        $('.nav-content1').css({ "animation": "FadeOut 1000ms forwards" });
        $('.menu-icon').css({ "animation": "Rotate1 1600ms forwards" });
        $('#website-title').css({ "color": "black" });
        $('.bg-blue').css({ "opacity": "0" });
        $('.wrapper').css({ "display": "block", "z-index": "0" });
        $('.bottom-nav').css({"opacity":"0"});

        setTimeout(function () {
            $('.wrapper').css({ "opacity": "1" });
        }, 300);

    }


    function Trigger2LeftNavBar() {

        $('.left-navigation-bar').css({ "animation": "FadeOutLeft 1000ms forwards"});
        $('.nav-content1').css({ "animation": "FadeIn 1400ms forwards" });
        $('.menu-icon').css({ "animation": "Rotate2 1800ms forwards" });
        $('#website-title').css({ "color": "white" });
        $('.bg-blue').css({ "opacity": "1" });
        $('.wrapper').css({ "opacity": "0"});

        setTimeout(function p() {
            $('.left-navigation-bar').css({ "display": "none" });
            $('.expand-navbar').css({ "display": "none" });
            $('.wrapper').css({ "display": "none", "z-index": "2" });
            $('.bottom-nav').css({ "opacity": "1" });
        }, 1000);

    }

    function AnimationFunction() {

        if (MenuClicks == 0) {
            $('.navigation-bar li a').css({ "color": "white" });
            $('.navigation-bar li').css({ "color": "white" });

            $('#menu-black').css({ "opacity": "0" });
            $('#menu-white').css({ "opacity": "1" });

            $('#website-title').css({ "color": "white" });

        }

        else if (MenuClicks % 2 != 0) {
            Trigger1LeftNavBar();
            $('.nav-content1 li a').css({ "color": "white" });
            $('.nav-content1 li').css({ "color": "white" });

            $('#menu-black').css({ "opacity": "1" });
            $('#menu-white').css({ "opacity": "0" });


            $('#website-title').css({ "color": "black" });
        }

        else if (MenuClicks % 2 == 0) {
            Trigger2LeftNavBar();
            $('.navigation-bar').addClass("navigation-bar-top1");
            $('.navigation-bar li a').css({ "color": "white" });
            $('.navigation-bar li').css({ "color": "white" });

            $('#menu-black').css({ "opacity": "0" });
            $('#menu-white').css({ "opacity": "1" });

            $('#website-title').css({ "color": "white" });

            $('.expand-navbar').css({ "transition": "width 800ms ease-in-out, opacity 800ms ease-in-out", "width": "325px", "opacity": "0" });
        }
    }

    //$('.reg-btn-trigger, .btn').on('click', function () {
    //    ShowRegLog();
    //});

    //$('#reg-return-btn').on('click', function () {
    //    ReturnPage();
    //});
})

$(function e() {
    $('#expand-btn').on('click', function () {
        $('.expand-navbar').css({ "transition": "width 600ms ease-in-out, opacity 0ms ease-in-out", "width": "75vw", "opacity": "1"});
    })
})

$(function images1() {

    $(".image").on('click', function () {
        $('.main').addClass('image');
        $('.main').removeClass('main');

        $(this).addClass('main');
        $(this).removeClass('image');

        $('.main .info-image h4').css({ "color": "rgba(0,0,0,0)" });

        setTimeout(function () {
            $('.main .info-image h4').css({ "color": "white" });
        }, 650);

        if ($("#one").hasClass("main")) {
            $("#one").css({
                "background": "url(/images/deadpool.jpg)",
                "background-repeat": "no-repeat",
                "background-position": "center",
                "background-size": "cover"
            })
        }
        else {
            $("#one").css({ "background": "white" });
        }

        if ($("#two").hasClass("main")) {
            $("#two").css({
                "background": "url(/images/westworld.png)",
                "background-repeat": "no-repeat",
                "background-position": "center",
                "background-size": "cover"
            })
        }
        else {
             $('#two').css({ "background": "white" });
        }


        if ($("#three").hasClass("main")) {
            $("#three").css({
                "background": "url(/images/fortnite.png)",
                "background-repeat": "no-repeat",
                "background-position": "center",
                "background-size": "cover"
            })
        }
        else {
            $('#three').css({ "background": "white" });
        }

        if ($("#four").hasClass("main")) {
            $("#four").css({
                "background": "url(/images/s9.png)",
                "background-repeat": "no-repeat",
                "background-position": "center",
                "background-size": "cover"
            })
        }
        else {
            $('#four').css({ "background": "white" });
        }

        if ($("#five").hasClass("main")) {
            $("#five").css({
                "background": "url(/images/spotify.png)",
                "background-repeat": "no-repeat",
                "background-position": "center",
                "background-size": "cover"
            })
        }
        else {
            $('#five').css({ "background": "white" });
        }
    })
})


$(function images2() {
    $(".image-profile").on('click', function() {
        $('.main-profile').addClass('image-profile');
        $('.main-profile').removeClass('main-profile');

        $(this).addClass('main-profile');
        $(this).removeClass('image-profile');
    })

})

$(function () {
    $('.profile-trigger').on('click', function () {
        $('.profile-page').css({ "display": "block" });
        $('.wrapper').css({ "display": "block" });
        $('.bottom-nav').css({ "opacity": "0" });

        setTimeout(function () {
            $('.profile-page').css({ "transform": "translate(0,-790px)" });
            $('.wrapper').css({ "opacity": "1" });
        },10);

    })
    $('.profile-top1 img').on('click', function () {
        $('.profile-page').css({ "transform": "translate(0,0)" });
        $('.wrapper').css({ "opacity": "0" });

        setTimeout(function () {
            $('.profile-page').css({ "display": "none" });
            $('.wrapper').css({ "display": "none" });
            $('.bottom-nav').css({ "opacity": "1" });
        }, 800);

    })
})

$(function () {

    for (i = 1; i <= 4; i++){

        var X = "$('#link" + i + "')";
        var Y = "$('#content" + i + "')"; 
        //alert(X); alert(Y);

        X.on('click', function () {
            $(Y).css({"opacity":"1"});
        })
    }
})

$(function () {
    var Clicks = 0;
    $('.bottom-nav').on('click', function () {
        Clicks++;

        if (Clicks % 2 != 0) {
            $(this).css({ "clip-path": "polygon(0 0, 100% 0, 100% 100%, 0% 100%)" });
        }
        else {
            $(this).css({ "clip-path": "polygon(40% 0, 60% 0, 70% 100%, 30% 100%)" });
        }
    })
})
