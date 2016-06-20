app.factory("CreditosEmpresarialesService", function () {
    var creditos = [
        {
            nombre: "Pymes MasterCard",
            tasa: 0.21,
            plazo: 60,
            montoMinimo: "$ 500,00",
            img: "img/PymesMasterCard.png",
            casaMatriz: "MasterCard",
            seguro: "Robo y Fraude, Protección Crediticia (solo clientes Pymes personas físicas)",
            befeficioLealtad: "Sí aplica",
            coberturaAccidenteViajes: "Sí aplica",
            coberturaAlquilerAutos: "Sí aplica"
        },
        {
            nombre: "Empresarial Visa",
            tasa: 0.32,
            plazo: 60,
            montoMinimo: "$ 500,00",
            img: "img/EmpresarialVisa.png",
            casaMatriz: "Visa",
            seguro: "--",
            befeficioLealtad: "No aplica",
            coberturaAccidenteViajes: "Sí aplica",
            coberturaAlquilerAutos: "Sí aplica"
        },
        {
            nombre: "Compras Institucionales",
            tasa: 0.32,
            plazo: 60,
            montoMinimo: "Sin mínimo establecido",
            img: "img/ComprasInstitucionales.png",
            casaMatriz: "Visa",
            seguro: "--",
            befeficioLealtad: "No aplica",
            coberturaAccidenteViajes: "No aplica",
            coberturaAlquilerAutos: "No aplica"
        },
        {
            nombre: "Compras Empresariales",
            tasa: 0.32,
            plazo: 60,
            montoMinimo: "Sin mínimo establecido",
            img: "img/ComprasEmpresariales.png",
            casaMatriz: "Visa",
            seguro: "--",
            befeficioLealtad: "No aplica",
            coberturaAccidenteViajes: "No aplica",
            coberturaAlquilerAutos: "No aplica"
        },

    ];
    return {
        getCreditos: function () {
            return creditos;
        }
    }
});