$(function () {

    $("#formCreate").submit(function (e) {
        var email = $("#Email").val();
        var password = $("#Password").val();
        var name = $("#Name").val();
        if (!email || !password || !name) {
            alert("Name, Email and password are required");
            e.preventDefault();
        }
    });
});
