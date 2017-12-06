/// <reference path="/Assets/admin/libs/angular/angular.js" />
// đặt những cấu hình tạo module chính
(function () {
    angular.module('onlineShop',
        ['onlineShop.products',
         'onlineShop.product_categories',
         'onlineShop.common'])
        .config(config);

    config.$inject = ["$stateProvider", '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller:"homeController"
        });
        $urlRouterProvider.otherwise('/admin');// neu khong thi quay lai admin

    }
})();