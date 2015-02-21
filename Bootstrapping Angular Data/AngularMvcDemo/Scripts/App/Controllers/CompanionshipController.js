"use strict";

angular.module("hobbitModule").controller("CompanionshipController", ["$scope", "companionship", function($scope, companionship) {
    $scope.companions = companionship;
}]);
