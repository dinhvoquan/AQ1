/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('aq1',
        ['aq1.products',
         'aq1.product_categories',
         'aq1.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();

