app.controller("editSociedadAnonimaController", function ($scope, $http) {
    $scope.disabled = false;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getSociedadAnonima?id=" + $scope.cedula)
         .then(function (response) {
             $scope.correo = response.data.Correo;
                $scope.cedRep = response.data.CEDULAREPRESENTANTE;
                $scope.nombrerep = response.data.NOMBREREPRESENTANTE;
                $scope.CedulaReturned = response.data.Cedula;
                $scope.Correo = response.data.Correo;
                
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/updateSociedadAnonima",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.CedulaReturned +
                "' , correo:'" + $scope.correo +
                "' , password:'" + $scope.Password +
                "' , cedularep:'" + $scope.cedRep +
                "' , nombrerep:'" + $scope.nombrerep +
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