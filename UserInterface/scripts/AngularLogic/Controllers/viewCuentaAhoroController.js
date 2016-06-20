app.controller("viewCuentaAhoroController", function ($scope, $http) {
    $http.get("WebService.asmx/getCuentasAhorro")
.then(function (response) {
    $scope.cuentas = response.data;
})
});