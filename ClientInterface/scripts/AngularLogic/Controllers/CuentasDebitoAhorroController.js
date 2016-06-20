app.controller("CuentasDebitoAhorroController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getCuentasAhorro?cedula=" + cedula)
    .then(function (response) {
        $scope.cuentas = response.data;
    })
});