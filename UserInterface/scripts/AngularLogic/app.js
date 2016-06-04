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
	.otherwise({
	    redirectTo: "/default"
	});
});