app.controller("CuentasCreditoPersonalesController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getCuentasCreditoPersonal?cedula=" + cedula)
    .then(function (response) {
        $scope.cuentas = response.data;
    })
});