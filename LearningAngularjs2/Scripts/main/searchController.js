mainApp.controller("searchController", ['$scope', '$http', '$windows', '$cookieStore', function ($scope, $http, $window, $cookieStore) {
    $scope.search = function () {
        $cookieStore.put('search', $scope.searchText);
        $window.location.href = '/tim-kiem';
    }
}])