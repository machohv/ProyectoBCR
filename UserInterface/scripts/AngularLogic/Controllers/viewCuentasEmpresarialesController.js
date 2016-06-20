app.controller("viewCuentasEmpresarialesController", function ($scope, $http) {
    $http.get("WebService.asmx/getCuentasEmpresariales")
.then(function (response) {
    $scope.cuentas = response.data;
})
});