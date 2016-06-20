app.controller("CuentasDebitoCorrientesController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getCuentasDebitoCorriente?cedula=" + cedula)
    .then(function (response) {
        $scope.cuentas = response.data;
    })
});