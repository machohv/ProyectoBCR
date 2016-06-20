app.controller("viewPersonasController", function ($scope, $http) {
    $http.get("WebService.asmx/getAllPersonas?id="+ $scope.id)
    .then(function (response) {
        $scope.personas = response.data;
    })
});