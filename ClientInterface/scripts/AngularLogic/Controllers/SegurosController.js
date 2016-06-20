app.controller("CuentasCreditoPersonalesController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getSeguros?cedula=" + cedula)
    .then(function (response) {
        $scope.seguros = response.data;
    })
});