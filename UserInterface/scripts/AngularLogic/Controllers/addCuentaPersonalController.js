app.controller("addCuentaPersonalController", function ($scope, $http, CreditosPersonalesService) {
    $scope.creditos = CreditosPersonalesService.getCreditos();
    $scope.selected = { object: '' };
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.mensaje = response.data.PrimerNombre + " " +
                              response.data.SegundoNombre + " " +
                              response.data.PrimerApellido + " " +
                              response.data.SegundoApellido;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/AddCuentaCreditoPersonal",
            dataType: 'json',
            method: 'POST',
            data: "{Cedula:'" + $scope.cedula +
                "' , CasaMatriz:'" + $scope.selected.object.casaMatriz +
                "' , Image:'" + $scope.selected.object.img +
                "' , Descripcion:'" + $scope.selected.object.nombre +
                "' , NombrePortador:'" + $scope.mensaje +
                "' , Divisa:'" + "$" +
                "' , Tasa:'" + $scope.selected.object.tasa +
                "' , Plazo:'" + $scope.selected.object.plazo +
                "' , Categoria:'Internacional'}",
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