mainApp.controller("allCategoryPostController", ['$scope', '$http', '$windows', 'CategoryPost', function ($scope, $http, $window, CategoryPost) {
    $scope.categories = [];
    $http.get('/API/CategoriesAPI/')
    .success(function (data) {
        var categories = CategoryPost.getallCategory(data);
        angular.forEach(categories, function (value, key) {
            if (value.idcategoryParent == '1') {
                $scope.categories.push(value)
            }
        })
    })
}])