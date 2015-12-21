(function () {
    'use strict';

    function config($routeProvider) {
        var CONTROLLER_AS_VIEW_MODEL = 'vm';
        $routeProvider
            .when('/', {
                templateUrl: 'views/partials/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl'
            })
             .when('/trips', {
                 templateUrl: 'views/partials/trips.html',
                 controller: 'TripsController',
                 controllerAs: CONTROLLER_AS_VIEW_MODEL
             })
            .when('/trips/create', {
                templateUrl: 'views/partials/create-trip.html',
                controller: 'CreateTripController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/trips/:id', {
                templateUrl: 'views/partials/trip-details.html',
                controller: 'TripDetailsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/drivers/:id', {
                templateUrl: 'views/partials/driver-details.html',
                controller: 'DriverDetailsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/unauthorized', {
                templateUrl: 'views/partials/unauthorized.html',
            })
    .otherwise({ redirectTo: '/' });
    }

    angular.module('myApp.services', []);
    angular.module('myApp.directives', []);
    angular.module('myApp.filters', []);
    angular.module('myApp.controllers', ['myApp.services', 'myApp.directives', 'myApp.filters']);
    angular.module('myApp', ['ngRoute', 'ngCookies', 'myApp.controllers', 'kendo.directives']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://localhost:1337');
}());