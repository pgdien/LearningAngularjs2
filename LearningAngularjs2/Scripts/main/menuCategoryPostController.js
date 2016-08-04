mainApp.controller("menuCategoryPostController", ['$scope', '$http', '$windows', 'CategoryPost', function ($scope, $http, $windows, CategoryPost) {
    $scope.categories = [];
    $scope.posts = [];

    $http.get('/API/CategoriesAPI/')
        .success(function (data) {
            var categories = CategoryPost.getallCategory(data);
            angular.forEach(categories, function (value, key) {
                if (value.idCategoryParent == 0) {
                    $scope.categories.push(value);
                }
            });
        });

    $http.get('/API/PostsAPI/')
        .success(function (data) {
            angular.forEach(data, function (value, key) {
                if (value.idCategory == 0) {
                    $scope.posts.push(value);
                }
            });
        });
}])