app.controller("ClientController", function ($scope, $http, ClientService) {
    var cedula = document.getElementById("HiddenCedula").value;
    $http.get("WebService.asmx/getClient?cedula=" + cedula)
    .then(function (response) {
        $scope.client = response.data;
        ClientService.set($scope.client);
        console.log(response.data);
        $scope.nombre = getNombre($scope.client);
    })
});

function getNombre(client) {
    if (client.hasOwnProperty("PrimerApellido")) {
        return client.PrimerNombre + " " +
               client.SegundoNombre + " " +
               client.PrimerApellido + " " +
               client.SegundoApellido;
    }

}