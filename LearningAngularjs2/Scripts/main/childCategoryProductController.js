mainApp.controller("childCategoryProductController", ['$scope', '$http', '$window', 'CategoryProduct', function ($scope, $http, $window, CategoryProduct) {
    $scope.categories = [];
    $scope.propducts = [];

    $scope.idCategory = angular.element('#idcategory').val();

    $http.get('/API.CategoryProductsAPI/')
    .success(function (data) {
        var categories = CategoryProduct.getallCategory(data);
        angular.forEach(categories, function (value, key) {
            if (value.idCategoryParent == $scope.idCategory) {
                $scope.categories.push(value);
            }
        });
    })

    $http.get('/API/ProductAPI/')
    .success(function (data) {
        angular.forEach(data, function (value, key) {
            if (value.idCategoryproduct == $$scope.idcategory) {
                $scope.propducts.push(value);
            }
        })
    })
}])