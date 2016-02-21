angular.module('raiweb.services', []);
angular.module('raiweb.controllers', []);
angular.module('raiweb.directives', []);

angular.module('raiweb', [
    "ui.router",
	"ui.router.stateHelper",
    'raiweb.services',
    'raiweb.controllers',
    'raiweb.directives',
    'raiweb.about'
]);

angular.module('raiweb')
.config(['$urlRouterProvider', '$locationProvider', '$stateProvider', 'stateHelperProvider', function ($urlRouterProvider, $locationProvider, $stateProvider, stateHelperProvider) {
    $locationProvider.html5Mode(true);
    $urlRouterProvider.otherwise('/');
    stateHelperProvider.createStates([
        {
            name: 'home',
            url: '/',
            templateUrl: '/home'
        },
        {
            name: 'about',
            url: '/about',
            templateUrl: '/about'
        }
    ]);
}])
.run(["$rootScope", "$state", "$stateParams", function ($rootScope, $state, $stateParams) {
    $rootScope.$state = $state;
    $rootScope.$stateParams = $stateParams;
}]);
