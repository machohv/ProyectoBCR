app.controller("viewSegurosController", function ($scope, $http) {
    $http.get("WebService.asmx/getAllSeguros")
    .then(function (response) {
        $scope.seguros = response.data;
    })
});