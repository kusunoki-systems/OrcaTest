﻿<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>@ViewBag.Title - My ASP.NET Application</title>

    <!-- Bootstrap core CSS -->

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="fonts/css/font-awesome.min.css" rel="stylesheet">
    <link href="css/animate.min.css" rel="stylesheet">
    @Styles.Render("~/Content/css")

    @Scripts.Render("~/bundles/modernizr")

    <!--[if lt IE 9]>
    <script src="../assets/js/ie8-responsive-file-warning.js"></script>
    <![endif]-->
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>


    <div class="col-md-3 left_col">
        <div class="left_col scroll-view">

            <div class="navbar nav_title" style="border: 0;">
                <a href="index.html" class="site_title">Gentelella Alela!</a>
            </div>

            <div class="profile">
                <!--img_2 -->
                <div class="profile_pic">
                    <img src="images/img.jpg" alt="..." class="img-circle profile_img">
                </div>
                <div class="profile_info">
                    <span>Welcome,</span>
                    <h2>Anthony Mutisya</h2>
                </div>
            </div>

            <br>
            <div id="sidebar-menu" class="main_menu_side hidden-print main_menu">

                <div class="menu_section">
                    <h3>General</h3>
                    <ul class="nav side-menu">
                        <li>
                            <a><i class="fa fa-home"></i> Home <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li>@Html.ActionLink("Home", "Index", "Home")</li>
                            </ul>
                        </li>
                        <li>
                            <a><i class="fa fa-edit"></i> ORCA API <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li>@Html.ActionLink("PatientBase", "PatientBase", "Home")</li>
                                <li>@Html.ActionLink("SystemInfo", "SystemInfo", "Home")</li>
                            </ul>
                        </li>
                        <li>
                            <a><i class="fa fa-desktop"></i> UI Elements <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="general_elements.html">General Elements</a></li>
                                <li><a href="media_gallery.html">Media Gallery</a></li>
                                <li><a href="typography.html">Typography</a></li>
                                <li><a href="icons.html">Icons</a></li>
                                <li><a href="glyphicons.html">Glyphicons</a></li>
                                <li><a href="widgets.html">Widgets</a></li>
                                <li><a href="invoice.html">Invoice</a></li>
                                <li><a href="inbox.html">Inbox</a></li>
                                <li><a href="calendar.html">Calendar</a></li>
                            </ul>
                        </li>
                        <li>
                            <a><i class="fa fa-table"></i> Tables <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="tables.html">Tables</a></li>
                                <li><a href="tables_dynamic.html">Table Dynamic</a></li>
                            </ul>
                        </li>
                        <li>
                            <a><i class="fa fa-bar-chart-o"></i> Data Presentation <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="chartjs.html">Chart JS</a></li>
                                <li><a href="chartjs2.html">Chart JS2</a></li>
                                <li><a href="morisjs.html">Moris JS</a></li>
                                <li><a href="echarts.html">ECharts </a></li>
                                <li><a href="other_charts.html">Other Charts </a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <div class="menu_section">
                    <h3>Live On</h3>
                    <ul class="nav side-menu">
                        <li>
                            <a><i class="fa fa-bug"></i> Additional Pages <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="e_commerce.html">E-commerce</a></li>
                                <li><a href="e_commerce_backend.html">E-commerce Backend</a></li>
                                <li><a href="projects.html">Projects</a></li>
                                <li><a href="project_detail.html">Project Detail</a></li>
                                <li><a href="contacts.html">Contacts</a></li>
                                <li><a href="profile.html">Profile</a></li>
                                <li><a href="real_estate.html">Real Estate</a></li>

                            </ul>
                        </li>
                        <li>
                            <a><i class="fa fa-windows"></i> Extras <span class="fa fa-chevron-down"></span></a>
                            <ul class="nav child_menu">
                                <li><a href="page_404.html">404 Error</a></li>
                                <li><a href="page_500.html">500 Error</a></li>
                                <li><a href="coming_soon.html">Coming Soon</a></li>
                                <li><a href="plain_page.html">Plain Page</a></li>
                                <li><a href="login.html">Login Page</a></li>
                                <li><a href="sign_up.html">SignUp Page</a></li>
                                <li><a href="pricing_tables.html">Pricing Tables</a></li>

                            </ul>
                        </li>
                        <li><a><i class="fa fa-laptop"></i> Landing Page <span class="label label-success pull-right">Coming Soon</span></a></li>
                    </ul>
                </div>

            </div>

            <div class="sidebar-footer hidden-small">
                <a data-toggle="tooltip" data-placement="top" title="Settings">
                    <span class="glyphicon glyphicon-cog" aria-hidden="true"></span>
                </a>
                <a data-toggle="tooltip" data-placement="top" title="FullScreen">
                    <span class="glyphicon glyphicon-fullscreen" aria-hidden="true"></span>
                </a>
                <a data-toggle="tooltip" data-placement="top" title="Lock">
                    <span class="glyphicon glyphicon-eye-close" aria-hidden="true"></span>
                </a>
                <a data-toggle="tooltip" data-placement="top" title="Logout">
                    <span class="glyphicon glyphicon-off" aria-hidden="true"></span>
                </a>
            </div>
        </div>
    </div>
    <div class="right_col" role="main">

        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>
                        Plain Page <small>Page subtile </small>
                    </h3>
                </div>

                <div class="title_right">
                    <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>

            <div class="row">
                <div class="col-md-12">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2>Page title <small>Page subtile </small></h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a></li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">
                                        <i class="fa fa-wrench"></i>
                                    </a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Settings 1</a></li>
                                        <li><a href="#">Settings 2</a></li>
                                    </ul>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <!-- content starts here -->
                            @RenderBody()
                            <!-- content ends here -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
