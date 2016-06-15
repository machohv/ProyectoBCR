app.controller("viewCuentaPersonalController", function ($scope, $http) {
    $http.get("WebService.asmx/getAllCuentasCreditoPersonal")
    .then(function (response) {
        $scope.tarjetas = response.data;
    })
});