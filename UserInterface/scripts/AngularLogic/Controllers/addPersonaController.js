

app.controller("addPersonaController", function ($scope, $http) {
    
    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/AddPersona",
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
                "' , telefono:'" + $scope.telefono +
                "' , celular:'" + $scope.celular +
                "' , provincia:'" + $scope.provincia +
                "' , canton:'" + $scope.canton +
                "' , distrito:'" + $scope.distrito +
                "' , direccionExacta:'" + $scope.direccionExacta +
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