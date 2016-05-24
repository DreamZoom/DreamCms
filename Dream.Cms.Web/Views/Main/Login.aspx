<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="utf-8" />
    <title><%:Html.SiteConfig().SiteName %></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta content="width=device-width, initial-scale=1" name="viewport" />
    <meta content="" name="description" />
    <meta content="" name="author" />
    <!-- BEGIN GLOBAL MANDATORY STYLES -->
    
    <link href="/Themes/metronic/global/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="/Themes/metronic/global/plugins/simple-line-icons/simple-line-icons.min.css" rel="stylesheet" type="text/css" />
    <link href="/Themes/metronic/global/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/Themes/metronic/global/plugins/uniform/css/uniform.default.css" rel="stylesheet" type="text/css" />
    <link href="/Themes/metronic/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
    <!-- END GLOBAL MANDATORY STYLES -->
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN THEME GLOBAL STYLES -->
    <link href="/Themes/metronic/global/css/components.min.css" rel="stylesheet" id="style_components" type="text/css" />
    <link href="/Themes/metronic/global/css/plugins.min.css" rel="stylesheet" type="text/css" />
    <!-- END THEME GLOBAL STYLES -->
    <!-- BEGIN PAGE LEVEL STYLES -->
    <link href="/Themes/metronic/pages/css/lock-2.min.css" rel="stylesheet" type="text/css" />
    <!-- END PAGE LEVEL STYLES -->
    <!-- BEGIN THEME LAYOUT STYLES -->
    <!-- END THEME LAYOUT STYLES -->
    <link rel="shortcut icon" href="favicon.ico" />
</head>
<body>
    <div class="page-lock">
        <div class="page-logo">
            <a class="brand" href="index.html">
                <img src="/Themes/metronic/pages/img/logo-big.png" alt="logo" />
            </a>
        </div>
        <div class="page-body">
            <img class="page-lock-img" src="/Themes/metronic/pages/media/profile/profile.jpg" alt="">
            <div class="page-lock-info">
                <h1><%:Html.SiteConfig().SiteName %></h1>
                <span class="email"><%:Html.ValidationSummary() %></span>
                
                <form class="form-inline" action="<%:Url.Action("login") %>" method="post">
                    <%:Html.Hidden("back_url",Request["back_url"]) %>
                    <div class="input-group input-medium" >
                        <input type="text" class="form-control" placeholder="username" name="username">
                       
                    </div>
                   
                    <div class="input-group input-medium">
                        <input type="password" class="form-control" placeholder="Password" name="password">
                       
                    </div>

                    <div class="input-group input-medium" style="margin-top:10px;color:white">
                        管理帮助！
                        <span class="input-group-btn pull-right">
                            <button type="submit" class="btn green icn-only">
                                <i class="m-icon-swapright m-icon-white"></i>
                                登录
                            </button>
                        </span>
                    </div>
                    <!-- /input-group -->
                    
                </form>
            </div>
        </div>
       
    </div>
    <!--[if lt IE 9]>
<script src="/Themes/metronic/global/plugins/respond.min.js"></script>
<script src="/Themes/metronic/global/plugins/excanvas.min.js"></script> 
<![endif]-->
    <!-- BEGIN CORE PLUGINS -->
    <script src="/Themes/metronic/global/plugins/jquery.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/js.cookie.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/jquery.blockui.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/uniform/jquery.uniform.min.js" type="text/javascript"></script>
    <script src="/Themes/metronic/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js" type="text/javascript"></script>
    <!-- END CORE PLUGINS -->
    <!-- BEGIN PAGE LEVEL PLUGINS -->
    <script src="/Themes/metronic/global/plugins/backstretch/jquery.backstretch.min.js" type="text/javascript"></script>
    <!-- END PAGE LEVEL PLUGINS -->
    <!-- BEGIN THEME GLOBAL SCRIPTS -->
    <script src="/Themes/metronic/global/scripts/app.min.js" type="text/javascript"></script>
    <!-- END THEME GLOBAL SCRIPTS -->
    <!-- BEGIN PAGE LEVEL SCRIPTS -->
    <script src="/Themes/metronic/pages/scripts/lock-2.min.js" type="text/javascript"></script>
    <!-- END PAGE LEVEL SCRIPTS -->
    <!-- BEGIN THEME LAYOUT SCRIPTS -->
    <!-- END THEME LAYOUT SCRIPTS -->
</body>
</html>
