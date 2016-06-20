app.controller("addSeguroController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.asegurado = response.data.PrimerNombre + " " +
                              response.data.SegundoNombre + " " +
                              response.data.PrimerApellido + " " +
                              response.data.SegundoApellido;
             $scope.disabled = false;
         })
    }
    
    $scope.submitForm = function () {

        $http({
            url: "WebService.asmx/AddSeguro",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.cedula +
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