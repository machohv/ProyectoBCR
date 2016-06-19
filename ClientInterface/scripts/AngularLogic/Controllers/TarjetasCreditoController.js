app.controller("TarjetasCreditoController", function ($scope, $http) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getTarjetasCredito?cedula=" + cedula)
    .then(function (response) {
        $scope.tarjetas = response.data;
    })
});