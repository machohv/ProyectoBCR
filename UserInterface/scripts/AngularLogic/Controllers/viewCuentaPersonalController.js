app.controller("viewCuentaPersonalController", function ($scope, $http) {
    console.log("hola")
    $http.get("WebService.asmx/getAllCuentasCreditoPersonal")
    .then(function (response) {
        $scope.tarjetas = response.data;
        console.log(response.data);
    })
});