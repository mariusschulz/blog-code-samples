(function() {
    "use strict";

    angular
        .module("lordOfTheRings")
        .controller("ElvenRingsController", ElvenRingsController);

    ElvenRingsController.$inject = ["$scope"];

    function ElvenRingsController($scope) {
        $scope.rings = {
            elvenRings: [
                "Narya",
                "Nenya",
                "Vilya"
            ]
        };
    }
}());
