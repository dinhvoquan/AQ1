/// <reference path="/Assets/admin/libs/angular/angular.js" />
//(function () {
//    angular.module('aq1.products', ['aq1.common']).config(config);

//    config.$inject = ['$stateProvider', '$urlRouterProvider'];

//    function config($stateProvider, $urlRouterProvider) {
//        $stateProvider.state('products', {
//            url: "/products",
//            templateUrl: "/app/components/products/productListView.html",
//            controller: "productListController"
//        }).state('product_add', {
//            url: "/product_add",
//            templateUrl: "/app/components/products/productAddView.html",
//            controller: "productAddController"
//        });
//    }
//})();

(function () {
    angular.module('aq1.products', ['aq1.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('product_add', {
            url: "/product_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        });
    }
})();