angular.module('raiweb.about.directives')

.directive('aboutPage', [function () {
    return {
        restrict: 'AE',
        template: "<h2>THIS IS : {{title}}</h2>",
        link: function (scope, element, attrs) {
            scope.title = "MY ABOUT PAGE";
        }
    };
}]);