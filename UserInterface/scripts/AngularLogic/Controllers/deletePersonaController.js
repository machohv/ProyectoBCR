app.controller("deletePersonaController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.mensaje = "Se va a eliminar a " +
                 response.data.PrimerNombre + " " +
                 response.data.SegundoNombre + " " +
                 response.data.PrimerApellido + " " +
                 response.data.SegundoApellido;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/DeletePersona",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.cedula + "'}",
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