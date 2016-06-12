app.controller("editPersonaController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.correo = response.data.Correo;
             $scope.primerNombre = response.data.PrimerNombre;
             $scope.segundoNombre = response.data.SegundoNombre;
             $scope.primerApellido = response.data.PrimerApellido;
             $scope.segundoApellido = response.data.SegundoApellido;
             $scope.profesion = response.data.Profesion;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/EditPersona",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.cedula +
                "' , correo:'" + $scope.correo +
                "' , password:'" + $scope.password +
                "' , primerNombre:'" + $scope.primerNombre +
                "' , segundoNombre:'" + $scope.segundoNombre +
                "' , primerApellido:'" + $scope.primerApellido +
                "' , segundoApellido:'" + $scope.segundoApellido +
                "' , profesion:'" + $scope.profesion +
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