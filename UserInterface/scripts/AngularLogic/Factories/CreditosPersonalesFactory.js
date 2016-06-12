app.factory("CreditosPersonalesService", function () {
    var creditos = [
        {
            nombre: "Internacional Visa",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 500,00",
            img: "img/InternacionalVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Oro Visa",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 3000,00",
            img: "img/OroVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Platinum Visa",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 7000,00",
            img: "img/PlatinumVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Infinite Visa",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 15000,00",
            img: "img/InfiniteVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Tarjeta Virtual Visa",
            tasa: "",
            plazo: "",
            limiteCredito: "Bajo control del usuario",
            img: "img/TarjetaVirtualV.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Internacional MasterCard",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 500,00",
            img: "img/InternacionalMasterCard.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Oro MasterCard",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 3000,00",
            img: "img/OroMasterCard.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Platinum MasterCard",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 7000,00",
            img: "img/PlatinumMasterCard.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Black MasterCard",
            tasa: 0.32,
            plazo: 60,
            limiteCredito: "$ 15000,00",
            img: "img/BlackMasterCard.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Tarjeta Virtual MasterCard",
            tasa: "",
            plazo: "",
            limiteCredito: "Bajo control del usuario",
            img: "img/TarjetaVirtualMC.png",
            casaMatriz: "MasterCard"
        }

    ];
    return {
        getCreditos: function () {
            return creditos;
        }
    }
});