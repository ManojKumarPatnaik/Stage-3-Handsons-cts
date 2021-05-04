$(document).ready(function () {
    $("p").css({ "font-size": 20, "width": 500, "color": "green", "margin": 5 });

    $("span").mouseover(function () {
        $(this).css({ "background-color": "bisque" });
    });
    $("span").mouseout(function () {
        $(this).css({ "background-color": "white" });
    });
    $("span").mousemove(function () {

        if ($(this).text().includes("th")) {
            $(this).css({
                "font-style": "italic", "text-shadow": "2px 2px pink", "font-weight": "bolder"
            });
        }

    });
});