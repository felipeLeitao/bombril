
$("#drag-target-box").click(function () {
    $("#file").click();
});

$("form").dropzone({
    autoProcessQueue: false,
    paramName: "File"
});