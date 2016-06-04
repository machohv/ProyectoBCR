app.controller("servicesController", function ($scope, BCRServices) {
    //$scope.showChilds = function (item) {
    //    item.active = !item.active;
    //};
    $scope.services = BCRServices.getServices();
});