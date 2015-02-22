(function() {
    "use strict";

    angular
        .module("lordOfTheRings")
        .directive("wikipediaLink", WikipediaLink);

    function WikipediaLink() {
        return {
            scope: {
                articleName: "=wikipediaLink"
            },
            link: function(scope, element) {
                var wikipediaArticleUrl = "https://en.wikipedia.org/wiki/" + encodeURIComponent(scope.articleName);
                var linkTitle = scope.articleName + " on Wikipedia";

                element
                    .attr("href", wikipediaArticleUrl)
                    .attr("title", linkTitle);
            }
        };
    }
}());
