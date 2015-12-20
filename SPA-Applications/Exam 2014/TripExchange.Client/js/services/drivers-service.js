(function () {
    'use strict'
    function DriversService($q, data) {
        var getAll = function getAll() {
            var deferred = $q.defer();
            data.get('api/drivers')
            .then(function (res) {
                deferred.resolve(res);
            })

            return deferred.promise;
        }

        var getById = function getById(id) {
            var deferred = $q.defer();
            data.get('api/drivers/' + id)
            .then(function (res) {
                deferred.resolve(res);
            })
            return deferred.promise;
        }

        return {
            getAll: getAll,
            getById: getById
        }
    }
    angular.module('myApp.services')
    .factory('drivers', ['$q', 'data', DriversService])
}())