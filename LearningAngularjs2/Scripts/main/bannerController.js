mainApp.controller("bannerController", ['$scope', '$http', '$windows', function ($scope, $http, $windows) {
    $scope.banner = [];

    $http.get('/API/BannersAPI/')
    .success(function (data) {
        $scope.banner = data;
    })
}])