// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
close - alert

$('.close-alert').click(function () {
    $(".alert").hide("hide");
})

setTimeout(() => $(".alert").hide("hide"), 1000);