app.controller("addCuentaEmpresarialController", function ($scope, $http, CreditosPersonalesService) {
    $scope.creditos = CreditosPersonalesService.getCreditos();
    $scope.selected = { object: '' };
    $scope.disabled = true;



    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getSociedadAnonima?id=" + $scope.cedula)
         .then(function (response) {
             $scope.mensaje = response.data.NOMBREREPRESENTANTE + "              [CEDULA: " +
                              response.data.Cedula + "]  " +
                              response.data.Correo + " ";
             $scope.disabled = false;
         })
    }
    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/addCuentaEmpresarial",
            dataType: 'json',
            method: 'POST',
            data: "{divisa:'" + $scope.divisa +
                "' , taza:'" + $scope.selected.object.tasa +
                "' , cedula:'" + $scope.cedula +
                "' , tarjeta:'" + 0 +
                "' , meses:'" + $scope.meses + "'}",
            headers: {
                "Content-Type": "application/json"
            }
        }).success(function (response) {
            alert(response.d);
            console.log($scope.cedula)
        })
        .error(function (error) {
            alert(error);
        });
        console.log($scope.selected.object);
    }

});



