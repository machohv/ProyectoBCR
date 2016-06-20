app.controller("editSeguroController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getSeguro?codigoSeguro=" + $scope.codigoSeguro)
         .then(function (response) {
             $scope.cedula = response.data.Cedula;
             $scope.tipoSeguro = response.data.TipoSeguro;
             $scope.asegurado = response.data.Asegurado;
             $scope.valorSeguro = response.data.ValorSeguro;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/EditSeguro",
            dataType: 'json',
            method: 'POST',
            data: "{codigoSeguro:'" + $scope.codigoSeguro +
                "' , cedula:'" + $scope.cedula +
                "' , tipoSeguro:'" + $scope.tipoSeguro +
                "' , asegurado:'" + $scope.asegurado +
                "' , valorSeguro:'" + $scope.valorSeguro +
                "'}",
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