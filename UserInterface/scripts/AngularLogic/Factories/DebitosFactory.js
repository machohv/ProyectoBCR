app.factory("DebitosService", function () {
    var creditos = [
        {
            nombre: "Hit Visa",
            aceptacion: "Local",
            anualidad: "Sin cobro",
            img: "img/HitVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Morpho Visa",
            aceptacion: "Mundial",
            anualidad: "Sin cobro",
            img: "img/MorphoVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "360° Visa",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/360Visa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Pensionados Visa",
            aceptacion: "Local",
            anualidad: "Sin cobro",
            img: "img/PensionadosVisa.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Internacional Visa",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/InternacionalVisaDebito.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Oro Visa",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/OroVisaDebito.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Platinum Visa",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/PlatinumVisaDebito.png",
            casaMatriz: "Visa"
        },
        {
            nombre: "Internacional MasterCard",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/InternacionalMasterCardDebito.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Oro MasterCard",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/OroMasterCardDebito.png",
            casaMatriz: "MasterCard"
        },
        {
            nombre: "Platinum MasterCard",
            aceptacion: "Mundial",
            anualidad: "$10,00",
            img: "img/PlatinumMasterCardDebito.png",
            casaMatriz: "MasterCard"
        },
    ];
    return {
        getCreditos: function () {
            return creditos;
        }
    }
});