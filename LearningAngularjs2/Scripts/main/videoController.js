mainApp.controller("videoController", ['$scope', '$http', '$window', '$sce', function ($scope, $http, $window, $sce) {
    $scope.video = {};
    $scope.videos = [];

    $scope.get('/API/VideosAPI/')
    .success(function (data) {
        angular.forEach(data, function (value, key) {
            data[key].link_video = $scope.trusAsResourceUrl(value.link_video)
            if (key == 0) {
                $scope.video = value;
            }
        })
        $scope.video = data;
    })
}])