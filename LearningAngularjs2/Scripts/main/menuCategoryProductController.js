mainApp.controller("menuCategoryProductController", ['$scope', '$http', '$windows', 'CategoryProduct', function ($scope, $http, $window, CategoryProduct) {
    $scope.categoryProducts = [];

    $http.get('/CategoryProducts/GetCategoryProduct/')
    .success(function (categoryProducts) {
        $scope.categoryProducts = categoryProducts;
    })
}])