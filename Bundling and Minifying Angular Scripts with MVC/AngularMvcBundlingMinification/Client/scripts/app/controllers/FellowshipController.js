(function() {
    "use strict";

    angular
        .module("lordOfTheRings")
        .controller("FellowshipController", FellowshipController);

    FellowshipController.$inject = ["$scope"];

    function FellowshipController($scope) {
        $scope.fellowship = {
            companions: [
                "Frodo",
                "Sam",
                "Merry",
                "Pippin",
                "Gandalf",
                "Aragorn",
                "Legolas",
                "Gimli",
                "Boromir"
            ]
        };
    }
}());
