app.controller("deleteCuentaPersonalController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        console.log("cp")
        $http.get("WebService.asmx/getCuentaCreditoPersonal?NumeroCuenta=" + $scope.NumeroCuenta)
         .then(function (response) {
             console.log(response.data);
             $scope.mensaje = "Se va a eliminar la cuenta de " +
                 response.data.Cliente.PrimerNombre + " " +
                 response.data.Cliente.SegundoNombre + " " +
                 response.data.Cliente.PrimerApellido + " " +
                 response.data.Cliente.SegundoApellido;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/DeleteCuentaCreditoPersonal",
            dataType: 'json',
            method: 'POST',
            data: "{NumeroCuenta:'" + $scope.NumeroCuenta + "'}",
            headers: {
                "Content-Type": "application/json"
            }
        }).success(function (response) {
            alert(response.d);

        })
        .error(function (error) {
            alert(error);
        });

    }
});