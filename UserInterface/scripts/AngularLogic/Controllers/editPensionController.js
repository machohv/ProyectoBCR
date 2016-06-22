app.controller("editPensionController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPension?codigoPension=" + $scope.codigoPension)
         .then(function (response) {
             $scope.cedula = response.data.Cedula;
             $scope.tipoPension = response.data.TipoPension;
             $scope.valorPension = response.data.ValorPension;
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/EditPension",
            dataType: 'json',
            method: 'POST',
            data: "{codigoPension:'" + $scope.codigoPension +
                "' , cedula:'" + $scope.cedula +
                "' , tipoPension:'" + $scope.tipoPension +
                "' , valorPension:'" + $scope.valorPension +
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