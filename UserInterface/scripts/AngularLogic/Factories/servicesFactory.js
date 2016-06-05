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
                    name: "Crédito empresarial",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Crédito Empresariales",
                            url: "#"
                        },
                        {
                            name: "Agregar Cuenta de Crédito Empresarial",
                            url: "#"
                        },
                        {
                            name: "Editar Cuenta de Crédito Empresarial",
                            url: "#"
                        },
                        {
                            name: "Eliminar Cuenta de Crédito Empresarial",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Crédito personal",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Crédito Personales",
                            url: "#"
                        },
                        {
                            name: "Agregar Cuenta de Crédito Personal",
                            url: "#"
                        },
                        {
                            name: "Editar Cuenta de Crédito Personal",
                            url: "#"
                        },
                        {
                            name: "Eliminar Cuenta de Crédito Personal",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Débito Corriente",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Débito Corrientes",
                            url: "#"
                        },
                        {
                            name: "Agregar Cuenta de Débito Corriente",
                            url: "#"
                        },
                        {
                            name: "Editar Cuenta de Débito Corriente",
                            url: "#"
                        },
                        {
                            name: "Eliminar Cuenta de Débito Corriente",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Débito de Ahorro",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Débito de Ahorro",
                            url: "#"
                        },
                        {
                            name: "Agregar Cuenta de Débito de Ahorro",
                            url: "#"
                        },
                        {
                            name: "Editar Cuenta de Débito de Ahorro",
                            url: "#"
                        },
                        {
                            name: "Eliminar Cuenta de Débito de Ahorro",
                            url: "#"
                        }
                    ]
                },
                
            ]
        },
        {
            name: "Fondos de Inversión",
            url: "#",
            subMenu: [
                {
                    name: "Fondos Mercado Dinero",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos Mercado Dinero",
                            url: "#/viewPersonas"
                        },
                        {
                            name: "Agregar Fondos Mercado Dinero",
                            url: "#/addPersona"
                        },
                        {
                            name: "Editar Fondos Mercado Dinero",
                            url: "#"
                        },
                        {
                            name: "Eliminar Fondos Mercado Dinero",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Fondos de Ingreso",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos de Ingreso",
                            url: "#"
                        },
                        {
                            name: "Agregar Fondos de Ingreso",
                            url: "#"
                        },
                        {
                            name: "Editar Fondos de Ingreso",
                            url: "#"
                        },
                        {
                            name: "Eliminar Fondos de Ingreso",
                            url: "#"
                        }
                    ]
                },
                {
                    name: "Fondos Inmoviliarios",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos Inmoviliarios",
                            url: "#"
                        },
                        {
                            name: "Agregar Fondos Inmoviliarios",
                            url: "#"
                        },
                        {
                            name: "Editar Fondos Inmoviliarios",
                            url: "#"
                        },
                        {
                            name: "Eliminar Fondos Inmoviliarios",
                            url: "#"
                        }
                    ]
                }
            ]
        },
		{
		    name: "Pensiones",
		    url: "#",
		    subMenu: [
                {
                    name: "Ver Pensiones",
                    url: "#",
                    subMenu: []
                },
                {
                    name: "Agregar Pensión",
                    url: "#",
                    subMenu: []
                },
                {
                    name: "Editar Pensión",
                    url: "#",
                    subMenu: []
                },
                {
                    name: "Eliminar Pensión",
                    url: "#",
                    subMenu: []
                }
		    ]
		},
        {
            name: "Seguros",
            url: "#",
            subMenu: [
                {
                    name: "Ver Seguros",
                    url: "#/addPersona",
                    subMenu: []
                },
                {
                    name: "Agregar Seguro",
                    url: "#",
                    subMenu: []
                },
                {
                    name: "Editar Seguro",
                    url: "#",
                    subMenu: []
                },
                {
                    name: "Eliminar Seguro",
                    url: "#",
                    subMenu: []
                }
            ]
        }
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