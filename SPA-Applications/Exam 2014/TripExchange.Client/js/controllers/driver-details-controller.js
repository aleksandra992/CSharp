(function () {
    'use strict'
    function DriverDetailsController($routeParams, $location, notifier, identity, drivers) {
        var vm = this;
        if (!identity.isAuthenticated()) {
            $location.path('/unauthorized');
        }
        drivers.getById($routeParams.id)
        .then(function (res) {
            vm.driverDetails = res;
        })
    }

    angular.module('myApp.controllers')
    .controller('DriverDetailsController', ['$routeParams', '$location', 'notifier', 'identity', 'drivers', DriverDetailsController])
}())