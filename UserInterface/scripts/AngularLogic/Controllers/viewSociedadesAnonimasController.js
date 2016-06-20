app.controller("viewSociedadesAnonimasController", function ($scope, $http) {
    $http.get("WebService.asmx/getSociedadesAnonimas?id="+ $scope.id)
        .then(function (response) {
            $scope.sociedades = response.data;
        })
    });

