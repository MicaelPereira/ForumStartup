$(function () {
    $("#formDetails").submit(function (e) {
        var answer = $("#answer").val();
        
        if (!answer) {
            alert("answer is required");
            e.preventDefault();
        }
    });
    
});