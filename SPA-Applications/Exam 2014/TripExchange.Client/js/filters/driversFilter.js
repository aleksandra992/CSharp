(function () {
    'use strict';

    function tripsFilter() {

        return function tripsFilter(trips, driverName, isMine, onlyDriver) {
            debugger;
            var filteredTrips = trips;
            if (isMine) {
                filteredTrips = filteredTrips.filter(function (trip) {
                    return trip.isMine;
                });
            }

            if (onlyDriver) {
                filteredTrips = filteredTrips.filter(function (trip) {
                    return trip.driverName === driverName;
                });
            }

            return filteredTrips;
        }
    }

    angular.module('myApp.filters').filter('tripsFilter', [tripsFilter]);
}());
