app.controller("viewSociedadesAnonimasController", function ($scope, $http) {
    $http.get("WebService.asmx/getSociedadesAnonimas"+ $scope.id)
        .then(function (response) {
            $scope.personas = response.data;
        })
    });
