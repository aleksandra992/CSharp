(function () {
    'use strict';

    function paging() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/paging.html',
            link: function (scope, element, attr) {
                scope.vm.pages = [];
                for (var i = 1; i <= attr.pages; i++) {
                    scope.vm.pages.push(i);
                }
                scope.vm.filterTrips();
            }
        }
    }

    angular.module('myApp.directives')
        .directive('paging', [paging]);
}());