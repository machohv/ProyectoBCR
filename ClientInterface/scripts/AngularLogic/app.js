var app = angular.module("myApp", ["ngRoute", "ngAnimate"]);

app.config(function ($routeProvider) {
    $routeProvider
        .when("/default", {
            templateUrl: "templates/default.html",
            controller: "ClientController"
        })
        .when("/CuentasCreditoEmpresariales", {
            templateUrl: "templates/CuentasCreditoEmpresariales.html",
            controller: "CuentasCreditoEmpresarialesController"
        })
        .when("/CuentasCreditoPersonales", {
            templateUrl: "templates/CuentasCreditoPersonales.html",
            controller: "CuentasCreditoPersonalesController"
        })
        .when("/CuentasDebitoAhorro", {
            templateUrl: "templates/CuentasDebitoAhorro.html",
            controller: "CuentasDebitoAhorroController"
        })
        .when("/CuentasDebitoCorrientes", {
            templateUrl: "templates/CuentasDebitoCorrientes.html",
            controller: "CuentasDebitoCorrientesController"
        })
        .when("/Pensiones", {
            templateUrl: "templates/Pensiones.html",
            controller: "PensionesController"
        })
        .when("/Seguros", {
            templateUrl: "templates/Seguros.html",
            controller: "SegurosController"
        })
        .when("/TarjetasCredito", {
            templateUrl: "templates/TarjetasCredito.html",
            controller: "TarjetasCreditoController"
        })
        .when("/TarjetasDebito", {
            templateUrl: "templates/TarjetasDebito.html",
            controller: "TarjetasDebitoController"
        })
        .when("/Valores", {
            templateUrl: "templates/Valores.html",
            controller: "ValoresController"
        })
        .when("/FondosInversion", {
            templateUrl: "templates/FondosInversion.html",
            controller: "FondosInversionController"
        })
	.otherwise({
	    redirectTo: "/default"
	});
});