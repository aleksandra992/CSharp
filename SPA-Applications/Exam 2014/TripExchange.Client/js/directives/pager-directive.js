(function () {
    'use strict';

    angular.module('myApp.directives')
        .directive('pager', [function () {
            return {
                restrict: 'A',
                templateUrl: 'views/directives/pager-directive.html',
                link: function (scope) {
                    debugger;
                    scope.vm.previousPage = function () {
                        if (scope.vm.filter.page > 1) {
                            scope.vm.filter.page--;
                            scope.vm.filterTrips();
                            debugger;
                        }
                    }

                    scope.vm.nextPage = function () {
                        if (scope.vm.trips.length != 0) {
                            scope.vm.filter.page++;
                            scope.vm.filterTrips();
                        }
                    }
                }
            }
        }]);
}())