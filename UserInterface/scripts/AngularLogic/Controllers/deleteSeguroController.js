app.controller("deleteSociedadAnonimaController", function ($scope, $http) {
    $scope.disabled = true;

    $scope.fillSpaces = function () {
        $http.get("WebService.asmx/getSeguro?CodigoSeguro=" + $scope.CodigoSeguro)
         .then(function (response) {
             $scope.disabled = false;
         })
    }

    $scope.submitForm = function () {
        $http({
            url: "WebService.asmx/DeleteSeguro",
            dataType: 'json',
            method: 'POST',
            data: "{CodigoSeguro:'" + $scope.CodigoSeguro + "'}",
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