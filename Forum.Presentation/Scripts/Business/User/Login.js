$(function () {

    $("#formLogin").submit(function (e) {
        var email = $("#Email").val();
        var password = $("#Password").val();
        if (!email || !password) {
            alert("Email and password are required");
            e.preventDefault();
        }
    });
});