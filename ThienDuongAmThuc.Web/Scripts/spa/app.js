/// <reference path="../plugins/angular/angular.js" />
var myApp = angular.module("myModule", []);

myApp.controller("schoolController", schoolController);
myApp.service('validatorService', validatorService);
myApp.directive('onlineShopDirective', onlineShopDirective);

schoolController.$inject = ['$scope', 'validatorService'];

// declare
function schoolController($scope, validatorService) {
    $scope.checkNumber = function () {
        $scope.message = validatorService.checkNumber(2);
    }
    $scope.num = 1;
}

function validatorService($window) {
    return {
        checkNumber:checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else
        {
            return  'This is old';
        }
    }
}
function onlineShopDirective() {
    return {
        restrict: "A",
        templateUrl: "/Scripts/spa/onlineShopDirective.html"
    }
}
