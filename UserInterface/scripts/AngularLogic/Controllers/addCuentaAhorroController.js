app.controller("addCuentaAhorroController", function ($scope, $http) {
    $scope.disabled = true;
    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.mensaje = response.data.PrimerNombre + " " +
                              response.data.PrimerApellido + " " +
                              response.data.SegundoApellido + " ~ [Cedula "+
                              response.data.Cedula+"]";
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/addCuentaAhorro",
            dataType: 'json',
            method: 'POST',
            data: "{id:'" + $scope.cedula +
                "' , divisa:'" + $scope.divisa +
                "' , balance:'" + $scope.Balance + "'}",
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
 
    }

});