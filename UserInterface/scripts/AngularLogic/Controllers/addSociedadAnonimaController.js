app.controller("addSociedadAnonimaController", function ($scope, $http) {
    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/addSociedadAnonima",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.cedula +
                "' , correo:'" + $scope.correo +
                "' , password:'" + $scope.password +
                "' , cedularep:'" + $scope.cedularep +
                "' , nombrerep:'" + $scope.nombrerep +
                "'}",
            //(string cedula, string correo, string password, string cedularep, string nombrerep) 
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