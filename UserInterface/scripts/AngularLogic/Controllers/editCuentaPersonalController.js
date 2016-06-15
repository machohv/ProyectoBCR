app.controller("editCuentaPersonalController", function ($scope, $http) {

        $scope.disabled = true;

        $scope.fillSpaces = function () {
            $http.get("WebService.asmx/getCuentaCreditoPersonal?NumeroCuenta=" + $scope.NumeroCuenta)
             .then(function (response) {
                 $scope.Pin = response.data.Pin;
                 $scope.Cedula = response.data.Cliente.Cedula;
                 $scope.Balance = response.data.Cuenta.Balance;
                 $scope.SaldoBloqueado = response.data.Cuenta.SaldoBloqueado;
                 $scope.SaldoCongelado = response.data.Cuenta.SaldoCongelado;
                 $scope.Taza = response.data.Cuenta.Taza;
                 $scope.Millas = response.data.Cuenta.Millas;
                 $scope.FechaCorte = new Date(parseInt(response.data.Cuenta.FechaCorte.substr(6)));
                 $scope.FechaRenovacion = new Date(parseInt(response.data.Cuenta.FechaRenovacion.substr(6)));
                 $scope.disabled = false;
             })
        }

        $scope.submitForm = function () {
            $http({
                url: "WebService.asmx/EditCuentaCreditoPersonal",
                dataType: 'json',
                method: 'POST',
                data: "{NumeroCuenta:'" + $scope.NumeroCuenta +
                    "' , Pin:'" + $scope.Pin +
                    "' , Cedula:'" + $scope.Cedula +
                    "' , Balance:'" + $scope.Balance +
                    "' , SaldoBloqueado:'" + $scope.SaldoBloqueado +
                    "' , SaldoCongelado:'" + $scope.SaldoCongelado +
                    "' , Taza:'" + $scope.Taza +
                    "' , Millas:'" + $scope.Millas +
                    "' , FechaCorte:'" + new Date($scope.FechaCorte).toUTCString() +
                    "' , FechaRenovacion:'" + new Date($scope.FechaRenovacion).toUTCString() +
                    "'}",
                headers: {
                    "Content-Type": "application/json"
                }
            }).success(function (response) {
                alert(response.d);

            })
            .error(function (error) {
                alert(error);
            });

        }
    


});