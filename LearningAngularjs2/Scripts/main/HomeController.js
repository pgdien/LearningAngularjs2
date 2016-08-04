mainApp.controller("HomeController", ['$scope', '$http', '$windows', 'CategoryPost', function ($scope, $http, $Window, CategoryPost) {
    $scope.products = [];
    $scope.posts = [];

    $scope.idCategory = angular.element('#idCategory').val();

    $http.get('/API/CategoriesAPI/')
    .success(function (data) {
        var categories = categoryPost.getallCategory(data);
        angular.forEach(categories, function (value, key) {
            if (value.idCategoryParent != null) {
                $scope.categories.push(value);
            }
        })
    })

    $http.get('API/PostsAPI/')
    .success(function (data) {
        angular.forEach(data, function (data) {
            $scope.posts.push(value);
        })
    })
}])