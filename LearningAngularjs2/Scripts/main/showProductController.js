mainApp.controller("showProductController", ['$scope', '$http', '$window', 'Product', function ($scope, $http, $window, Product) {
    $scope.product = {};
    $scope.realateProducts = [];
    $scope.idCategoryProduct;
    $scope.idProduct = angular.element('#idProuct').val();

    $http.get('/API/ProductsAPI/' + $scope.idProduct)
    .success(function (data) {
        $scope.product = data;
        $scope.idCategoryProduct = data.idCategoryProduct;

        $http.get('/Propduct/relateProduct?idProduct=' + $scope.product.idProduct + '&numLimit=4')
        .success(function (products) {
            $scope.realateProducts = products;
        })
    })
}])