app.directive('sideMenu', function () {
    return {
        restrict: 'E',
        scope: {
            
            list: '@',
            fields: '@',
            orderby: '@'
        },
        templateUrl: 'templates/sideMenu.html',
        controller: "servicesController",
        link: function (scope, element, attrs) {
            window.setTimeout(function () {
                $('#side-menu').metisMenu({ toggle: false });
            }, 1000);

        }
    }
});