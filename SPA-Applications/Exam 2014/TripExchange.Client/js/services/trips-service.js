(function () {
    'use strict'
    function TripsService($q, data) {
        var tripsStats = function () {
            var deferred = $q.defer();
            data.get('api/stats')
            .then(function (res) {
                deferred.resolve(res);

            })

            return deferred.promise;
        }
        var getAll = function (params) {
            var deferred = $q.defer();
            data.get('api/trips',params)
            .then(function (res) {
                deferred.resolve(res);
            })

            return deferred.promise;
        }

        var getTripById = function (id) {
            var deferred = $q.defer();
            data.get('api/trips/' + id)
            .then(function (res) {
                deferred.resolve(res);
            })

            return deferred.promise;
        }

        var joinTrip = function (id) {
            var deferred = $q.defer();
            data.put('api/trips/' + id)
            .then(function (res) {
                deferred.resolve(res);
            }, function (err) {
                deferred.reject(err);
            })
            return deferred.promise;
        }

        var createTrip = function (trip) {
            var deferred = $q.defer();

            data.post('api/trips', trip)
            .then(function (res) {
                deferred.resolve(res);
            }, function (err) {
                deferred.reject(err);
            })

            return deferred.promise;
        }

        return {
            tripsStats: tripsStats,
            getAll: getAll,
            getTripById: getTripById,
            joinTrip: joinTrip,
            createTrip: createTrip
        }
    }

    angular.module('myApp.services')
    .factory('trips', ['$q', 'data', TripsService])
}())