(function() {
    "use strict";

    angular
        .module("inlinedTemplates")
        .controller("TranspilerListController", TranspilerListController);

    TranspilerListController.$inject = ["$scope"];

    function TranspilerListController($scope) {
        $scope.transpilers = ["Babel", "TypeScript", "Traceur"];
    }
}());
