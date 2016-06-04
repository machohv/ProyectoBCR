app.controller("viewPersonasController", function ($scope, $http) {
    $http.get("WebService.asmx/getAllPersonas")
    .then(function (response) {
        $scope.personas = response.data;
    })
});