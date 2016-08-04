myApp.controller("danhsachCustomerRegisterController", ['$scope', '$http', '$window', 'uiGridConstants', function ($scope, $http, $window, uiGridConstants) {

    $scope.gridOptions = [];

    //Lấy danh sách đăng ký
    $http.get('/API/CustomerRegistersAPI/')
    .success(function (data) {
        $scope.gridOptions.data = data;
    });

    //Chỉnh cột
    $scope.gridOptions.columnDef=
        [
            {
                displayName: "STT",
                name: 'stt',
                enableCellEdit: false,
                enableSorting: false,
                enableFiltering: false,
                width: 55,
                cellTemplate: '<div class="ui-grid-cell-contents text-center">{{grid.renderContainers.body.visibleRowCache.indexOf(row)+1}}</div>'
            },
            {
                displayName: "ID",
                name: 'id',
                enableSorting: false,
                width: 60,
            },
            {
                displayName: "Email",
                name: 'email'
            },
            {
                displayName: "",
                name: 'delete',
                enableSorting: false,
                enableFiltering: false,
                width: 100,
                enableCellEdit: false,
                cellTemplate: '<div ><button style="margin-left: 10px; margin-top: 3px;" class="btn btn-xs btn-danger" ng-click="grid.appScope.DeleteCustomerRegister(row.entity.id)"><span class="fa fa-bitbucket"></span></button></div>',
            }
        ]

    //Chia trang
    $scope.gridOptions.paginationPageSizes = [10, 25, 50, 75];
    $scope.gridOptions.paginationPageSize = 25;

    //Tìm kiếm
    $scope.gridOptions.enableFiltering = true;

    //lựa chọn
    $scope.gridOptions.enableRowSelection = true;
    $scope.gridOptions.enableRowHeaderSelection = false;
    $scope.gridOptions.multiSelect = false;

    //Grid API
    $scope.gridOptions.onRegisterAPI = function (gridAPI) { }

    //Xóa
    $scope.DeleteCustomerRegister = function (id) {
        var id = id;

        if (confirm("Bạn có chắc chắn muốn xóa?")) {
            //Xóa
            $http.delete('/API/CustomerRegistersAPI/' + id)
            .success(function () {
                $http.get('/API/CustomerRegistersAPI/').success(function (data) { $scope.gridOptions.data = data; });
                toastr.success('Thành công', 'Xóa');
            });
        }
    }
}])