(function () {
    'use strict'
    function CitiesService($q, data) {
        var getAll = function () {
            var deferred = $q.defer();

            data.get('api/cities')
            .then(function (res) {
                deferred.resolve(res);
            });
            return deferred.promise;
        }
        return {
            getAll: getAll
        }
    }
    angular.module('myApp.services')
    .factory('cities', ['$q', 'data', CitiesService])
}())