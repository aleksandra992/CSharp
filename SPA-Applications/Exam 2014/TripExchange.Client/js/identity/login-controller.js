(function () {
    'use strict';

    function LoginController($rootScope,$scope, $location, notifier, identity, auth) {
        $scope.identity = identity;

        $scope.login = function (user, loginForm) {
            debugger;
            if (loginForm.$valid) {
                auth.login(user).then(function (success) {

                    if (success) {
                        $rootScope.$broadcast('loggedUser');
                        notifier.success('Successful login!');
                    }
                    else {
                        notifier.error('Username/Password combination is not valid!');
                    }
                });
            }
            else {
                notifier.error('Username and password are required fields!')
            }
        }

        $scope.logout = function () {
            auth.logout().then(function () {
                notifier.success('Successful logout!');
                if ($scope.user) {
                    $scope.user.email = '';
                    $scope.user.username = '';
                    $scope.user.password = '';
                }

                $scope.loginForm.$setPristine();
                $location.path('/');
            })
        }
    }

    angular.module('myApp.controllers')
        .controller('LoginCtrl', ['$rootScope', '$scope', '$location', 'notifier', 'identity', 'auth', LoginController]);
}());