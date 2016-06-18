app.controller("servicesController", function ($scope, BCRServices) {
    
    $scope.services = BCRServices.getPeopleServices();
});