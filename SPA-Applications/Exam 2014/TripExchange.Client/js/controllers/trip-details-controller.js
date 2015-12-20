(function () {
    'use strict'
    function TripDetailsController($routeParams, $location, notifier, identity, trips) {
        var vm = this;
        if (!identity.isAuthenticated()) {
            $location.path('/unauthorized');
        }
        trips.getTripById($routeParams.id)
        .then(function (res) {
            vm.tripDetals = res;
        })
        vm.joinTrip = function (id) {
            trips.joinTrip(id)
            .then(function (res) {
                notifier.success('You have joined the trip');
                vm.tripDetals = res;
            })
        }
    }

    angular.module('myApp.controllers')
    .controller('TripDetailsController', ['$routeParams', '$location', 'notifier', 'identity', 'trips', TripDetailsController])
}())