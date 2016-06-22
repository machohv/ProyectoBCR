app.controller("deletePensionController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getPension?codigoPension=" + $scope.codigoPension)
         .then(function (response) {
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/DeletePension",
            dataType: 'json',
            method: 'POST',
            data: "{codigoPension:'" + $scope.codigoPension + "'}",
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