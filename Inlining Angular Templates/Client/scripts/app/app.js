(function() {
    "use strict";

    var app = angular.module("inlinedTemplates", ["ngRoute"]);

    app.config(["$routeProvider", function($routeProvider) {
        $routeProvider
            .when("/transpilers", {
                templateUrl: "templates/TranspilerList",
                controller: "TranspilerListController"
            })
            .when("/transpilers/:transpiler", {
                templateUrl: "templates/TranspilerDetails",
                controller: "TranspilerDetailsController"
            })
            .otherwise({
                redirectTo: "/transpilers"
            });
    }]);
}());
