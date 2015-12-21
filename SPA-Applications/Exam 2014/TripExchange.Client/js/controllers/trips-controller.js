(function () {
    'use strict'
    function TripsController($rootScope, $scope, cities, trips, identity) {
        var vm = this;
        vm.currentPage = 1;
        vm.filter = [];
        vm.filter.page = 1;
        vm.identity = identity;
        trips.getAll()
        .then(function (res) {
            vm.trips = res;
            console.log(res);
        })
        cities.getAll()
        .then(function (res) {
            res.unshift('');
            vm.cities = res;
        })
        vm.filterTrips = function () {
            debugger;
            trips.getAll(vm.filter)
            .then(function (res) {
                console.log(res);
                vm.trips = res;
            }, function () {
                console.log('error');
            })
        }
        //vm.nextPage = function () {
        //    if (vm.trips.length > 0) {
        //        vm.filter.page++;
        //    }
        //    vm.filterTrips();

        //}
        //vm.previousPage = function () {
        //    if (vm.filter.page > 1) {
        //        vm.filter.page--;
        //    }
        //    vm.filterTrips();
        //}

        $rootScope.$on('loggedUser', function () {
            vm.filterTrips();
        });
    }
    angular.module('myApp.controllers')
    .controller('TripsController', ['$rootScope', '$scope', 'cities', 'trips', 'identity', TripsController])

}())