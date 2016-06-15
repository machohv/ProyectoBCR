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
    <script src="scripts/moment.min.js"></script>
    <script src="scripts/angular-animate.min.js"></script>

    <link href="Content/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="scripts/bootstrap-datetimepicker.min.js"></script>

    <script src="scripts/AngularLogic/app.js"></script>
    <script src="scripts/AngularLogic/Factories/servicesFactory.js"></script>
    <script src="scripts/AngularLogic/Factories/CreditosPersonalesFactory.js"></script>

    <script src="scripts/AngularLogic/Controllers/viewTransaccionesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewSociedadesAnonimasController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewSegurosController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewReportosTripartitosController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewPersonasController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewPensionesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewMercadosInternacionalesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewLicitacionesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewFondosMercadoDineroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewFondosInversionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewFondosInmoviliarioController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewFondosIngresoController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewCuentasEmpresarialesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewCuentaPersonalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewCuentaCorrienteController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewCuentaAhoroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewCompraVentaValoresController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewAdministracionCarterasIndividualesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/viewAccionesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/servicesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editTransaccionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editSociedadAnonimaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editSeguroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editReportosTripartitosController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editPersonaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editPensionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editMercadoInternacionalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editLicitacionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editFondosInversionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editFondoMercadoDineroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editFondoInmoviliarioController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editFondoIngresoController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editCuentaPersonalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editCuentaEmpresarialController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editCuentaCorrienteController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editCuentaAhorroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editCompraVentaValoresController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editAdministracionCarterasIndividualesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/editAccionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteTransaccionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteSociedadAnonimaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteSeguroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteReportosTripartitosController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deletePersonaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deletePensionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteMercadoInternacionalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteLicitacionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteFondosInversionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteFondoMercadoDineroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteFondoInmoviliarioController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteFondoIngresoController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteCuentaPersonalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteCuentaEmpresarialController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteCuentaCorrienteController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteCuentaAhorroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteCompraVentaValoresController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteAdministracionCarterasIndividualesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/deleteAccionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addTransaccionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addSociedadAnonimaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addSeguroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addReportosTripartitosController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addPersonaController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addPensionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addMercadoInternacionalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addLicitacionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addFondosInversionController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addFondoMercadoDineroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addFondoInmoviliarioController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addFondoIngresoController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addCuentaPersonalController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addCuentaEmpresarialController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addCuentaCorrienteController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addCuentaAhorroController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addCompraVentaValoresController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addAdministracionCarterasIndividualesController.js"></script>
    <script src="scripts/AngularLogic/Controllers/addAccionController.js"></script>

    <script src="scripts/AngularLogic/Directives/sideMenu.js"></script>
    
    
</body>
</html>
