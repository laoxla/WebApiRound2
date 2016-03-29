namespace WebApiRound2 {

    angular.module('WebApiRound2', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/home.html',
                controller: WebApiRound2.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/about.html',
                controller: WebApiRound2.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('bookList', {
                url: '/books',
                templateUrl: '/ngApp/bookList.html',
                controller: WebApiRound2.Controllers.BookListController,
                controllerAs: 'controller'
            })
            .state('bookCreate', {
                url: '/create',
                templateUrl: '/ngApp/bookcreate.html',
                controller: WebApiRound2.Controllers.BookCreateController,
                controllerAs: 'controller'
            })

            .state('bookEdit', {
                url: '/books/edit/:id',
                templateUrl: '/ngApp/bookcreate.html',
                controller: WebApiRound2.Controllers.BookEditController,
                controllerAs: 'controller'
            })

            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

}
