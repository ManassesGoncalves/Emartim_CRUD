﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $('#table-contatos').DataTable();
});

index.Search(new Query < Book > ("query") {
    Filters = "is_available = true"
});