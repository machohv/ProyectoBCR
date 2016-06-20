

var app = angular.module("myApp", ["ngRoute", "ngAnimate"]);

app.config(function ($routeProvider) {
    $routeProvider
        .when("/default", {
            templateUrl: "templates/default.html"
        })
		.when("/addPersona", {
		    templateUrl: "templates/addPersona.html",
		    controller: "addPersonaController"
		})
		.when("/viewPersonas", {
		    templateUrl: "templates/viewPersonas.html",
		    controller: "viewPersonasController"
		})
        .when("/editPersona", {
            templateUrl: "templates/editPersona.html",
            controller: "editPersonaController"
        })
		.when("/deletePersona", {
		    templateUrl: "templates/deletePersona.html",
		    controller: "deletePersonaController"
		})
        .when("/viewSociedadesAnonimas", {
            templateUrl: "templates/viewSociedadesAnonimas.html",
            controller: "viewSociedadesAnonimasController"
        })
		.when("/addSociedadAnonima", {
		    templateUrl: "templates/addSociedadAnonima.html",
		    controller: "addSociedadAnonimaController"
		})
        .when("/editSociedadAnonima", {
            templateUrl: "templates/editSociedadAnonima.html",
            controller: "editSociedadAnonimaController"
        })
		.when("/deleteSociedadAnonima", {
		    templateUrl: "templates/deleteSociedadAnonima.html",
		    controller: "deleteSociedadAnonimaController"
		})
        .when("/viewCuentasEmpresariales", {
            templateUrl: "templates/viewCuentasEmpresariales.html",
            controller: "viewCuentasEmpresarialesController"
        })
		.when("/addCuentaEmpresarial", {
		    templateUrl: "templates/addCuentaEmpresarial.html",
		    controller: "addCuentaEmpresarialController"
		})
        .when("/editCuentaEmpresarial", {
            templateUrl: "templates/editCuentaEmpresarial.html",
            controller: "editCuentaEmpresarialController"
        })
		.when("/deleteCuentaEmpresarial", {
		    templateUrl: "templates/deleteCuentaEmpresarial.html",
		    controller: "deleteCuentaEmpresarialController"
		})
        .when("/viewCuentaPersonal", {
            templateUrl: "templates/viewCuentaPersonal.html",
            controller: "viewCuentaPersonalController"
        })
		.when("/addCuentaPersonal", {
		    templateUrl: "templates/addCuentaPersonal.html",
		    controller: "addCuentaPersonalController"
		})
        .when("/editCuentaPersonal", {
            templateUrl: "templates/editCuentaPersonal.html",
            controller: "editCuentaPersonalController"
        })
		.when("/deleteCuentaPersonal", {
		    templateUrl: "templates/deleteCuentaPersonal.html",
		    controller: "deleteCuentaPersonalController"
		})
        .when("/viewCuentaCorriente", {
            templateUrl: "templates/viewCuentaCorriente.html",
            controller: "viewCuentaCorrienteController"
        })
		.when("/addCuentaCorriente", {
		    templateUrl: "templates/addCuentaCorriente.html",
		    controller: "addCuentaCorrienteController"
		})
        .when("/editCuentaCorriente", {
            templateUrl: "templates/editCuentaCorriente.html",
            controller: "editCuentaCorrienteController"
        })
		.when("/deleteCuentaCorriente", {
		    templateUrl: "templates/deleteCuentaCorriente.html",
		    controller: "deleteCuentaCorrienteController"
		})
        .when("/viewCuentaAhoro", {
            templateUrl: "templates/viewCuentaAhoro.html",
            controller: "viewCuentaAhoroController"
        })
		.when("/addCuentaAhorro", {
		    templateUrl: "templates/addCuentaAhorro.html",
		    controller: "addCuentaAhorroController"
		})
        .when("/editCuentaAhorro", {
            templateUrl: "templates/editCuentaAhorro.html",
            controller: "editCuentaAhorroController"
        })
		.when("/deleteCuentaAhorro", {
		    templateUrl: "templates/deleteCuentaAhorro.html",
		    controller: "deleteCuentaAhorroController"
		})
         .when("/viewCompraVentaValores", {
             templateUrl: "templates/viewCompraVentaValores.html",
             controller: "viewCompraVentaValoresController"
         })
		.when("/addCompraVentaValores", {
		    templateUrl: "templates/addCompraVentaValores.html",
		    controller: "addCompraVentaValoresController"
		})
        .when("/editCompraVentaValores", {
            templateUrl: "templates/editCompraVentaValores.html",
            controller: "editCompraVentaValoresController"
        })
		.when("/deleteCompraVentaValores", {
		    templateUrl: "templates/deleteCompraVentaValores.html",
		    controller: "deleteCompraVentaValoresController"
		})
         .when("/viewFondosInversion", {
             templateUrl: "templates/viewFondosInversion.html",
             controller: "viewFondosInversionController"
         })
		.when("/addFondosInversion", {
		    templateUrl: "templates/addFondosInversion.html",
		    controller: "addFondosInversionController"
		})
        .when("/editFondosInversion", {
            templateUrl: "templates/editFondosInversion.html",
            controller: "editFondosInversionController"
        })
		.when("/deleteFondosInversion", {
		    templateUrl: "templates/deleteFondosInversion.html",
		    controller: "deleteFondosInversionController"
		})
         .when("/viewReportosTripartitos", {
             templateUrl: "templates/viewReportosTripartitos.html",
             controller: "viewReportosTripartitosController"
         })
		.when("/addReportosTripartitos", {
		    templateUrl: "templates/addReportosTripartitos.html",
		    controller: "addReportosTripartitosController"
		})
        .when("/editReportosTripartitos", {
            templateUrl: "templates/editReportosTripartitos.html",
            controller: "editReportosTripartitosController"
        })
		.when("/deleteReportosTripartitos", {
		    templateUrl: "templates/deleteReportosTripartitos.html",
		    controller: "deleteReportosTripartitosController"
		})
        .when("/viewAcciones", {
            templateUrl: "templates/viewAcciones.html",
            controller: "viewAccionesController"
        })
		.when("/addAccion", {
		    templateUrl: "templates/addAccion.html",
		    controller: "addAccionController"
		})
        .when("/editAccion", {
            templateUrl: "templates/editAccion.html",
            controller: "editAccionController"
        })
		.when("/deleteAccion", {
		    templateUrl: "templates/deleteAccion.html",
		    controller: "deleteAccionController"
		})
        .when("/viewMercadosInternacionales", {
            templateUrl: "templates/viewMercadosInternacionales.html",
            controller: "viewMercadosInternacionalesController"
        })
		.when("/addMercadoInternacional", {
		    templateUrl: "templates/addMercadoInternacional.html",
		    controller: "addMercadoInternacionalController"
		})
        .when("/editMercadoInternacional", {
            templateUrl: "templates/editMercadoInternacional.html",
            controller: "editMercadoInternacionalController"
        })
		.when("/deleteMercadoInternacional", {
		    templateUrl: "templates/deleteMercadoInternacional.html",
		    controller: "deleteMercadoInternacionalController"
		})
        .when("/viewLicitaciones", {
            templateUrl: "templates/viewLicitaciones.html",
            controller: "viewLicitacionesController"
        })
		.when("/addLicitacion", {
		    templateUrl: "templates/addLicitacion.html",
		    controller: "addLicitacionController"
		})
        .when("/editLicitacion", {
            templateUrl: "templates/editLicitacion.html",
            controller: "editLicitacionController"
        })
		.when("/deleteLicitacion", {
		    templateUrl: "templates/deleteLicitacion.html",
		    controller: "deleteLicitacionController"
		})
        .when("/viewAdministracionCarterasIndividuales", {
            templateUrl: "templates/viewAdministracionCarterasIndividuales.html",
            controller: "viewAdministracionCarterasIndividualesController"
        })
		.when("/addAdministracionCarterasIndividuales", {
		    templateUrl: "templates/addAdministracionCarterasIndividuales.html",
		    controller: "addAdministracionCarterasIndividualesController"
		})
        .when("/editAdministracionCarterasIndividuales", {
            templateUrl: "templates/editAdministracionCarterasIndividuales.html",
            controller: "editAdministracionCarterasIndividualesController"
        })
		.when("/deleteAdministracionCarterasIndividuales", {
		    templateUrl: "templates/deleteAdministracionCarterasIndividuales.html",
		    controller: "deleteAdministracionCarterasIndividualesController"
		})
        .when("/viewTransacciones", {
            templateUrl: "templates/viewTransacciones.html",
            controller: "viewTransaccionesController"
        })
		.when("/addTransaccion", {
		    templateUrl: "templates/addTransaccion.html",
		    controller: "addTransaccionController"
		})
        .when("/editTransaccion", {
            templateUrl: "templates/editTransaccion.html",
            controller: "editTransaccionController"
        })
		.when("/deleteTransaccion", {
		    templateUrl: "templates/deleteTransaccion.html",
		    controller: "deleteTransaccionController"
		})
         .when("/viewFondosMercadoDinero", {
             templateUrl: "templates/viewFondosMercadoDinero.html",
             controller: "viewFondosMercadoDineroController"
         })
		.when("/addFondoMercadoDinero", {
		    templateUrl: "templates/addFondoMercadoDinero.html",
		    controller: "addFondoMercadoDineroController"
		})
        .when("/editFondoMercadoDinero", {
            templateUrl: "templates/editFondoMercadoDinero.html",
            controller: "editFondoMercadoDineroController"
        })
		.when("/deleteFondoMercadoDinero", {
		    templateUrl: "templates/deleteFondoMercadoDinero.html",
		    controller: "deleteFondoMercadoDineroController"
		})
         .when("/viewFondosIngreso", {
             templateUrl: "templates/viewFondosIngreso.html",
             controller: "viewFondosIngresoController"
         })
		.when("/addFondoIngreso", {
		    templateUrl: "templates/addFondoIngreso.html",
		    controller: "addFondoIngresoController"
		})
        .when("/editFondoIngreso", {
            templateUrl: "templates/editFondoIngreso.html",
            controller: "editFondoIngresoController"
        })
		.when("/deleteFondoIngreso", {
		    templateUrl: "templates/deleteFondoIngreso.html",
		    controller: "deleteFondoIngresoController"
		})
        .when("/viewFondosInmoviliario", {
            templateUrl: "templates/viewFondosInmoviliario.html",
            controller: "viewFondosInmoviliarioController"
        })
		.when("/addFondoInmoviliario", {
		    templateUrl: "templates/addFondoInmoviliario.html",
		    controller: "addFondoInmoviliarioController"
		})
        .when("/editFondoInmoviliario", {
            templateUrl: "templates/editFondoInmoviliario.html",
            controller: "editFondoInmoviliarioController"
        })
		.when("/deleteFondoInmoviliario", {
		    templateUrl: "templates/deleteFondoInmoviliario.html",
		    controller: "deleteFondoInmoviliarioController"
		})
         .when("/viewPensiones", {
             templateUrl: "templates/viewPensiones.html",
             controller: "viewPensionesController"
         })
		.when("/addPension", {
		    templateUrl: "templates/addPension.html",
		    controller: "addPensionController"
		})
        .when("/editPension", {
            templateUrl: "templates/editPension.html",
            controller: "editPensionController"
        })
		.when("/deletePension", {
		    templateUrl: "templates/deletePension.html",
		    controller: "deletePensionController"
		})
        .when("/viewSeguros", {
            templateUrl: "templates/viewSeguros.html",
            controller: "viewSegurosController"
        })
		.when("/addSeguro", {
		    templateUrl: "templates/addSeguro.html",
		    controller: "addSeguroController"
		})
        .when("/editSeguro", {
            templateUrl: "templates/editSeguro.html",
            controller: "editSeguroController"
        })
		.when("/deleteSeguro", {
		    templateUrl: "templates/deleteSeguro.html",
		    controller: "deleteSeguroController"
		})

	.otherwise({
	    redirectTo: "/default"
	});
});