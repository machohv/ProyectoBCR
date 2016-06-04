<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UserInterface.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp">
<head runat="server">
    <title>Banco de Costa Rica</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Home.css" rel="stylesheet" />
    <link href="Content/font-awesome/css/font-awesome.min.css" rel="stylesheet"/>
    <link href="Content/angularAnimations.css" rel="stylesheet" />
</head>
<body >
    <div id="wrapper">
        
        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a href="Home.aspx">
                    <img src="img/logo-bcr.png" style="width:30%;height:30%;padding:5px;"/>
                </a>
            </div>

            <ul class="nav navbar-top-links navbar-right">
               
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li><a href="#"><i class="fa fa-user fa-fw"></i> Perfil</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="Login.aspx"><i class="fa fa-sign-out fa-fw"></i> Cerrar sesión</a>
                        </li>
                    </ul>
                </li>
            </ul>

            <side-menu></side-menu>
            
        </nav>

        <div id="page-wrapper">
            <div ng-view class="container"></div>
        </div>

    </div>

    <script src="scripts/jquery-2.1.1.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/metisMenu.min.js"></script>
    <script src="scripts/angular.min.js"></script>
    <script src="scripts/angular-route.js"></script>
    <script src="scripts/angular-animate.min.js"></script>

    <script src="scripts/AngularLogic/app.js"></script>
    <script src="scripts/AngularLogic/Factories/servicesFactory.js"></script>
    <script src="scripts/AngularLogic/Controllers/servicesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addPersonaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewPersonasController.js"></script>

    <script src="scripts/AngularLogic/Directives/sideMenu.js"></script>
    
    
</body>
</html>
