(function () {
    'use strict'

    function HomeController(trips, drivers) {
        var vm = this;
        trips.tripsStats()
        .then(function (res) {
            vm.tripInfo = res;
        });

        trips.getAll()
        .then(function (res) {
            vm.trips = res;
        }, function (err) {
            console.log(err);
        })

        drivers.getAll()
        .then(function (res) {
            vm.drivers = res;
        }, function (err) {
            console.log(err);
        })
    }

    angular.module('myApp.controllers')
    .controller('HomeController', ['trips', 'drivers', HomeController])
}())