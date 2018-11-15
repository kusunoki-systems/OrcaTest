﻿@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>患者基本情報</h2>
        <p>
            患者基本情報をGETで取得します。
        </p>
        <p>@Html.ActionLink("患者情報", "PatientBase", "Home", New With {.class = "btn btn-primary btn-md"})</p>
    </div>
    <div class="col-md-4">
        <h2>システム情報</h2>
        <p>システム情報をPOSTで取得します。</p>
        <p>@Html.ActionLink("システム情報", "SystemInfo", "Home", New With {.class = "btn btn-primary btn-md"})</p>
    </div>
</div>
