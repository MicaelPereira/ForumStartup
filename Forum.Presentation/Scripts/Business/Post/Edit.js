$(function () {
    $("#formEdit").submit(function (e) {
        debugger;
        var title = $("#Title").val();
        var body = $("#Body").val();

        if (!title || !body) {
            alert("Title and Body are required");
            e.preventDefault();
        }
    });
    
});