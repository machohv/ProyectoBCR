app.controller("viewPensionesController", function ($scope, $http) {
    $http.get("WebService.asmx/getAllPensiones")
    .then(function (response) {
        $scope.pensiones = response.data;
    })
});