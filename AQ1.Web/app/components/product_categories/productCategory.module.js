﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('aq1.product_categories', ['aq1.common']).config(config);

    //config.$inject = ['$stateProvider', '$urlRouterProvider'];

    //function config($stateProvider, $urlRouterProvider) {

    //    $stateProvider.state('product_categories', {
    //        url: "/product_categories",
    //        templateUrl: "/app/components/product_categories/productCategoryListView.html",
    //        controller: "productCategoryListController"
    //    }).state('add_product_category', {
    //        url: "/add_product_category",
    //        templateUrl: "/app/components/product_categories/productCategoryAddView.html",
    //        controller: "productCategoryAddController"
    //    });
    //}
    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {

        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "productCategoryListController"
        }).state('add_product_category', {
            url: "/add_product_category",
            templateUrl: "/app/components/product_categories/productCategoryAddView.html",
            controller: "productCategoryAddController"
        });
    }
})();