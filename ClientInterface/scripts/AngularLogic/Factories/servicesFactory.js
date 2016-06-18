app.factory("BCRServices", function () {
    var PeopleServices = [
        {
            name: "Cuentas",
            url: "#",
            subMenu: [
                {
                    name: "Cuentas de Crédito Personales",
                    url: "#/CuentasCreditoPersonales"
                },
                {
                    name: "Cuentas de Débito Corriente",
                    url: "#/CuentasDebitoCorrientes"
                },
                {
                    name: "Cuentas de Débito de Ahorro",
                    url: "#/CuentasDebitoAhorro"
                }
            ]
        },
        {
            name: "Tarjetas",
            url: "#",
            subMenu: [
                {
                    name: "Tarjetas de Crédito",
                    url: "#/TarjetasCredito"
                },
                 {
                     name: "Tarjetas de Débito",
                     url: "#/TarjetasDebito"
                 }
            ]
        },
        {
            name: "Valores",
            url: "#",
            subMenu: [
                {
                    name: "Compra y Venta de Valores",
                    url: "#/Valores"
                },
                {
                    name: "Servicios Complementarios",
                    url: "#/Valores"
                },
                {
                    name: "Fondos de Inversion",
                    url: "#/Valores"
                },
                {
                    name: "Reportos Tripartitos",
                    url: "#/Valores"
                },
                {
                    name: "Acciones",
                    url: "#/Valores"
                },
                {
                    name: "Mercados Internacionales",
                    url: "#/Valores"
                },
                {
                    name: "Licitaciones",
                    url: "#/Valores"
                },
                {
                    name: "Administración de Carteras Individuales",
                    url: "#/Valores"
                },
                {
                    name: "Transacciones con Divisas o Tipos de Cambios",
                    url: "#/Valores"
                }
            ]
        },
        {
            name: "Fondos de Inversión",
            url: "#",
            subMenu: [
                {
                    name: "Fondos Mercado Dinero",
                    url: "#/FondosInversion"
                },
                {
                    name: "Fondos de Ingreso",
                    url: "#/FondosInversion"
                },
                {
                    name: "Fondos Inmoviliarios",
                    url: "#/FondosInversion"
                }
            ]
        },
        {
            name: "Pensiones",
            url: "#",
            subMenu: [
                {
                    name: "Ver Pensiones",
                    url: "#/Pensiones"
                }
            ]
        },
        {
            name: "Seguros",
            url: "#",
            subMenu: [
                {
                    name: "Ver Seguros",
                    url: "#/Seguros"
                }
            ]
        },
    ];


    var CompanyServices = [
        {
            name: "Cuentas",
            url: "#",
            subMenu: [
                {
                    name: "Cuentas de Crédito Empresariales",
                    url: "#/CuentasCreditoEmpresariales"
                },
                {
                    name: "Cuentas de Débito Corriente",
                    url: "#/CuentasDebitoCorrientes"
                },
                {
                    name: "Cuentas de Débito de Ahorro",
                    url: "#/CuentasDebitoAhorro"
                }
            ]
        },
        {
            name: "Tarjetas",
            url: "#",
            subMenu: [
                {
                    name: "Tarjetas de Crédito",
                    url: "#/TarjetasCredito"
                },
                 {
                     name: "Tarjetas de Débito",
                     url: "#/TarjetasDebito"
                 }
            ]
        },
        {
            name: "Valores",
            url: "#",
            subMenu: [
                {
                    name: "Compra y Venta de Valores",
                    url: "#/Valores"
                },
                {
                    name: "Servicios Complementarios",
                    url: "#/Valores"
                },
                {
                    name: "Fondos de Inversion",
                    url: "#/Valores"
                },
                {
                    name: "Reportos Tripartitos",
                    url: "#/Valores"
                },
                {
                    name: "Acciones",
                    url: "#/Valores"
                },
                {
                    name: "Mercados Internacionales",
                    url: "#/Valores"
                },
                {
                    name: "Licitaciones",
                    url: "#/Valores"
                },
                {
                    name: "Administración de Carteras Individuales",
                    url: "#/Valores"
                },
                {
                    name: "Transacciones con Divisas o Tipos de Cambios",
                    url: "#/Valores"
                }
            ]
        },
        {
            name: "Fondos de Inversión",
            url: "#",
            subMenu: [
                {
                    name: "Fondos Mercado Dinero",
                    url: "#/FondosInversion"
                },
                {
                    name: "Fondos de Ingreso",
                    url: "#/FondosInversion"
                },
                {
                    name: "Fondos Inmoviliarios",
                    url: "#/FondosInversion"
                }
            ]
        },
        {
            name: "Pensiones",
            url: "#",
            subMenu: [
                {
                    name: "Ver Pensiones",
                    url: "#/Pensiones"
                }
            ]
        },
        {
            name: "Seguros",
            url: "#",
            subMenu: [
                {
                    name: "Ver Seguros",
                    url: "#/Seguros"
                }
            ]
        },
    ];

    return {
        getPeopleServices: function () {
            return PeopleServices;
        },

        getCompanyServices: function () {
            return CompanyServices;
        }
    }
});