var app = angular.module('MyApp', ['angularUtils.directives.dirPagination']);

app.controller('studentController', function ($scope, $http) {
    $http.get('/Student/GetList').then(function (response) {
        $scope.students = response.data;
    });
    $scope.GetStudent = function (tid) {
        $http({ method: 'Get', url: '/Student/GetById', params: { id: tid } }).then(function (response) {
            $scope.student = response.data;
        });
    }
    $scope.EditStudent = function (student) {
        $http({ method: 'POST', url: '/Student/Update', data: student })
            .success()
    }
    $scope.DeleteStudent = function (tid) {
        $http({ method: 'POST', url: '/Student/Delete', params: { id: tid } })
            .then(function (response) {
                $scope.Msg = "Removed succesfully";
            })
    }
    $scope.CreateStudent = function (student) {
        $http({ method: 'POST', url: '/Student/Create', data: student })
            .then(function (response) {
                $scope.Msg = response.FullName + "Created succesfully";
            })
    }

})