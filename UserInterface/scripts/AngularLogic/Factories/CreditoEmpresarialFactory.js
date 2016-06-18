app.factory("CreditosPersonalesService", function () {
    var creditos = [
        {
            nombre: "Internacional Visa",
            tasa: 0.32,
            plazo: 60,
            montoMinimo: "$ 500,00",
            img: "img/InternacionalVisa.png",
            casaMatriz: "Visa"
        },
        

    ];
    return {
        getCreditos: function () {
            return creditos;
        }
    }
});