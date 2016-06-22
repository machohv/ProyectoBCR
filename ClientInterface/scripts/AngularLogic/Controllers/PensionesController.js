app.controller("CuentasCreditoPersonalesController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getPensiones?cedula=" + cedula)
    .then(function (response) {
        $scope.pensiones = response.data;
    })
});