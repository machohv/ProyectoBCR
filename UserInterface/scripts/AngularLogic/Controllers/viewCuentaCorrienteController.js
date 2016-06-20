app.controller("viewCuentaCorrienteController", function ($scope, $http) {
    $http.get("WebService.asmx/getCuentasCorrientes")
.then(function (response) {
    $scope.cuentas = response.data;
})
});