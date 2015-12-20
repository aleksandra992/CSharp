(function () {
    'use strict'
    function CreateTripController($location, identity, trips, notifier, cities) {
        var vm = this;
        if (!identity.isAuthenticated()) {
            $location.path('/unauthorized');
        }
        vm.createTrip = function (trip) {
            debugger;
            trips.createTrip(trip)
            .then(function (res) {
                notifier.success('You have succesfully created trip');
                $location.path('/trips');
            })
        }
        cities.getAll()
        .then(function (res) {
            vm.cities = res;
        })

    }
    angular.module('myApp')
    .controller('CreateTripController', ['$location', 'identity', 'trips', 'notifier', 'cities', CreateTripController])
}())