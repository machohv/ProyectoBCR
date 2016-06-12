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
                            url: "#/editPersona"
                        },
                        {
                            name: "Eliminar Persona",
                            url: "#/deletePersona"
                        }
                    ]
                },
                {
                    name: "Sociedad Anónima",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Sociedad Anónima",
                            url: "#/viewSociedadesAnonimas"
                        },
                        {
                            name: "Agregar Sociedad Anónima",
                            url: "#addSociedadAnonima"
                        },
                        {
                            name: "Editar Sociedad Anónima",
                            url: "#editSociedadAnonima"
                        },
                        {
                            name: "Eliminar Sociedad Anónima",
                            url: "#deleteSociedadAnonima"
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
                            url: "#/viewCuentasEmpresariales"
                        },
                        {
                            name: "Agregar Cuenta de Crédito Empresarial",
                            url: "#/addCuentaEmpresarial"
                        },
                        {
                            name: "Editar Cuenta de Crédito Empresarial",
                            url: "#/editCuentaEmpresarial"
                        },
                        {
                            name: "Eliminar Cuenta de Crédito Empresarial",
                            url: "#/deleteCuentaEmpresarial"
                        }
                    ]
                },
                {
                    name: "Crédito personal",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Crédito Personales",
                            url: "#/viewCuentaPersonal"
                        },
                        {
                            name: "Agregar Cuenta de Crédito Personal",
                            url: "#/addCuentaPersonal"
                        },
                        {
                            name: "Editar Cuenta de Crédito Personal",
                            url: "#/editCuentaPersonal"
                        },
                        {
                            name: "Eliminar Cuenta de Crédito Personal",
                            url: "#/deleteCuentaPersonal"
                        }
                    ]
                },
                {
                    name: "Débito Corriente",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Débito Corrientes",
                            url: "#/viewCuentaCorriente"
                        },
                        {
                            name: "Agregar Cuenta de Débito Corriente",
                            url: "#/addCuentaCorriente"
                        },
                        {
                            name: "Editar Cuenta de Débito Corriente",
                            url: "#/editCuentaCorriente"
                        },
                        {
                            name: "Eliminar Cuenta de Débito Corriente",
                            url: "#/deleteCuentaCorriente"
                        }
                    ]
                },
                {
                    name: "Débito de Ahorro",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Cuentas de Débito de Ahorro",
                            url: "#/viewCuentaAhoro"
                        },
                        {
                            name: "Agregar Cuenta de Débito de Ahorro",
                            url: "#addCuentaAhorro"
                        },
                        {
                            name: "Editar Cuenta de Débito de Ahorro",
                            url: "#/editCuentaAhorro"
                        },
                        {
                            name: "Eliminar Cuenta de Débito de Ahorro",
                            url: "#/deleteCuentaAhorro"
                        }
                    ]
                },
                
            ]
        },
        {
            name: "Valores",
            url: "#",
            subMenu: [
                {
                    name: "Compra y Venta de Valores",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Compra y Venta de Valores",
                            url: "#/viewCompraVentaValores"
                        },
                        {
                            name: "Agregar Compra y Venta de Valores",
                            url: "#/addCompraVentaValores"
                        },
                        {
                            name: "Editar Compra y Venta de Valores",
                            url: "#/editCompraVentaValores"
                        },
                        {
                            name: "Eliminar Compra y Venta de Valores",
                            url: "#/deleteCompraVentaValores"
                        }
                    ]
                },
                {
                    name: "Fondos de Inversión",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos de Inversión",
                            url: "#/viewFondosInversion"
                        },
                        {
                            name: "Agregar Fondo de Inversión",
                            url: "#/addFondosInversion"
                        },
                        {
                            name: "Editar Fondo de Inversión",
                            url: "#/editFondosInversion"
                        },
                        {
                            name: "Eliminar Fondo de Inversión",
                            url: "#/deleteFondosInversion"
                        }
                    ]
                },
                {
                    name: "Reportos Tripartitos",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Reportos Tripartitos",
                            url: "#/viewReportosTripartitos"
                        },
                        {
                            name: "Agregar Reporto Tripartito",
                            url: "#/addReportosTripartitos"
                        },
                        {
                            name: "Editar Reporto Tripartito",
                            url: "#/editReportosTripartitos"
                        },
                        {
                            name: "Eliminar Reporto Tripartito",
                            url: "#/deleteReportosTripartitos"
                        }
                    ]
                },
                {
                    name: "Acciones",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Acciones",
                            url: "#/viewAcciones"
                        },
                        {
                            name: "Agregar Acción",
                            url: "#/addAccion"
                        },
                        {
                            name: "Editar Acción",
                            url: "#/editAccion"
                        },
                        {
                            name: "Eliminar Acción",
                            url: "#/deleteAccion"
                        }
                    ]
                },
                {
                    name: "Mercados Internacionales",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Mercados Internacionales",
                            url: "#/viewMercadosInternacionales"
                        },
                        {
                            name: "Agregar Mercado Internacional",
                            url: "#/addMercadoInternacional"
                        },
                        {
                            name: "Editar Mercado Internacional",
                            url: "#/editMercadoInternacional"
                        },
                        {
                            name: "Eliminar Mercado Internacional",
                            url: "#/deleteMercadoInternacional"
                        }
                    ]
                },
                {
                    name: "Licitaciones",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Licitaciones",
                            url: "#/viewLicitaciones"
                        },
                        {
                            name: "Agregar Licitación",
                            url: "#/addLicitacion"
                        },
                        {
                            name: "Editar Licitación",
                            url: "#/editLicitacion"
                        },
                        {
                            name: "Eliminar Licitación",
                            url: "#/deleteLicitacion"
                        }
                    ]
                },
                {
                    name: "Administración Carteras Individuales",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Administración Carteras Individuales",
                            url: "#/viewAdministracionCarterasIndividuales"
                        },
                        {
                            name: "Agregar Administración Carteras Individuales",
                            url: "#/addAdministracionCarterasIndividuales"
                        },
                        {
                            name: "Editar Administración Carteras Individuales",
                            url: "#editAdministracionCarterasIndividuales"
                        },
                        {
                            name: "Eliminar Administración Carteras Individuales",
                            url: "#deleteAdministracionCarterasIndividuales"
                        }
                    ]
                },
                {
                    name: "Transacciones con divisas o tipo de cambio",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Transacciones con divisas o tipo de cambio",
                            url: "#/viewTransacciones"
                        },
                        {
                            name: "Agregar Transacción con divisas o tipo de cambio",
                            url: "#/addTransaccion"
                        },
                        {
                            name: "Editar Transacción con divisas o tipo de cambio",
                            url: "#/editTransaccion"
                        },
                        {
                            name: "Eliminar Transacción con divisas o tipo de cambio",
                            url: "#/deleteTransaccion"
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
                            url: "#/viewFondosMercadoDinero"
                        },
                        {
                            name: "Agregar Fondos Mercado Dinero",
                            url: "#/addFondoMercadoDinero"
                        },
                        {
                            name: "Editar Fondos Mercado Dinero",
                            url: "#/editFondoMercadoDinero"
                        },
                        {
                            name: "Eliminar Fondos Mercado Dinero",
                            url: "#/deleteFondoMercadoDinero"
                        }
                    ]
                },
                {
                    name: "Fondos de Ingreso",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos de Ingreso",
                            url: "#/viewFondosIngreso"
                        },
                        {
                            name: "Agregar Fondos de Ingreso",
                            url: "#/addFondoIngreso"
                        },
                        {
                            name: "Editar Fondos de Ingreso",
                            url: "#/editFondoIngreso"
                        },
                        {
                            name: "Eliminar Fondos de Ingreso",
                            url: "#/deleteFondoIngreso"
                        }
                    ]
                },
                {
                    name: "Fondos Inmoviliarios",
                    url: "#",
                    subMenu: [
                        {
                            name: "Ver Fondos Inmoviliarios",
                            url: "#/viewFondosInmoviliario"
                        },
                        {
                            name: "Agregar Fondos Inmoviliarios",
                            url: "#/addFondoInmoviliario"
                        },
                        {
                            name: "Editar Fondos Inmoviliarios",
                            url: "#/editFondoInmoviliario"
                        },
                        {
                            name: "Eliminar Fondos Inmoviliarios",
                            url: "#/deleteFondoInmoviliario"
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
                    url: "#/viewPensiones",
                    subMenu: []
                },
                {
                    name: "Agregar Pensión",
                    url: "#/addPension",
                    subMenu: []
                },
                {
                    name: "Editar Pensión",
                    url: "#/editPension",
                    subMenu: []
                },
                {
                    name: "Eliminar Pensión",
                    url: "#/deletePension",
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
                    url: "#/viewSeguros",
                    subMenu: []
                },
                {
                    name: "Agregar Seguro",
                    url: "#/addSeguro",
                    subMenu: []
                },
                {
                    name: "Editar Seguro",
                    url: "#/editSeguro",
                    subMenu: []
                },
                {
                    name: "Eliminar Seguro",
                    url: "#/deleteSeguro",
                    subMenu: []
                }
            ]
        }
    ];
    return {
        getServices: function () {
            return services;
        }
    }
});