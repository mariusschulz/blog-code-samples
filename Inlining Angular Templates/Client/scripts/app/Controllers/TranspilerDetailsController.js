(function() {
    "use strict";

    angular
        .module("inlinedTemplates")
        .controller("TranspilerDetailsController", TranspilerDetailsController);

    TranspilerDetailsController.$inject = ["$scope", "$routeParams"];

    function TranspilerDetailsController($scope, $routeParams) {
        $scope.transpiler = {
            name: $routeParams.transpiler,
            description: "Some description of " + $routeParams.transpiler + " ..."
        };
    }
}());
