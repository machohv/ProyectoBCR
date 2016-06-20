app.controller("addPensionController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPersona?cedula=" + $scope.cedula)
         .then(function (response) {
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {

        $http({
            url: "WebService.asmx/AddPension",
            dataType: 'json',
            method: 'POST',
            data: "{cedula:'" + $scope.cedula +
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