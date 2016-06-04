app.factory("BCRServices", function () {
    var services = [
        {
            name: "Clientes",
            url: "#",
            subMenu: [
                {
                    name: "Personas",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Personas",
                            url: "#/viewPersonas"
                        },
                        {
                            name: "Agregar Persona",
                            url: "#/addPersona"
                        },
                        {
                            name: "Editar Persona",
                            url: "#"
                        },
                        {
                            name: "Eliminar Persona",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Sociedad Anónima",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Sociedad Anónima",
                            url: "#"
                        },
                        {
                            name: "Agregar Sociedad Anónima",
                            url: "#"
                        },
                        {
                            name: "Editar Sociedad Anónima",
                            url: "#"
                        },
                        {
                            name: "Eliminar Sociedad Anónima",
                            url: "#"
                        }
                    ]
                }
            ]
        },
        {
            name: "Cuentas",
            url: "#",
            subMenu: [
                {
                    name: "Crédito",
                    url: "#",
                    subMenu: [
                        {
                            name: "Cuenta empresariales",
                            url: "#"
                        },
                        {
                            name: "Cuenta personales",
                            url: "#"
                        },
                    ]
                },
                {
                    name: "Débito",
                    url: "#",
                    subMenu: [
                        {
                            name: "Cuenta corriente",
                            url: "#"
                        },
                        {
                            name: "Cuenta de ahorro",
                            url: "#"
                        }
                    ]
                }
            ]
        },
		//{
		//    name: "Valores",
		//    url: "#",
		//    subMenu: []
		//},
		//{
		//    name: "Fondos de inversión",
		//    url: "#",
		//    subMenu: []
		//},
        //{
        //    name: "Seguros",
        //    url: "#",
        //    subMenu: []
        //},
        //{
        //    name: "Pensiones",
        //    url: "#",
        //    subMenu: []
        //},

    ];
    return {
        getServices: function () {
            return services;
        }
    }
});