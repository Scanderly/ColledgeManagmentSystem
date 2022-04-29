var app = angular.module('MyApp', ['angularUtils.directives.dirPagination']);

app.controller('studentController', function ($scope, $http) {
    // get all students
    $http.get('/Student/GetList').then(function (response) {
        $scope.students = response.data;
    });
    //get student by Id
    $scope.GetStudent = function (tid) {
        $http({ method: 'Get', url: '/Student/GetById', params: { id: tid } }).then(function (response) {
            $scope.student = response.data;
        });
    }
    //delte student
    $scope.DeleteStudent = function (tid) {
        $http({ method: 'POST', url: '/Student/Delete', params: { id: tid } })
            .then(function (response) {
                $scope.Msg = "Removed succesfully";
            })
    }
    //add new student
    $scope.CreateStudent = function (student) {
        $http({ method: 'POST', url: '/Student/Create', data: student })
            .then(function (response) {
                $scope.Msg = response.FullName + "Created succesfully";
            })
    }
     //update student
    $scope.EditStudent = function (student) {
        $http({ method: 'POST', url: '/Student/Update', data: student })
            .then(function (response) {
                $scope.Msg = response.FullName + " " + "Updated succesfully";

                $http.get('/Student/GetList').then(function (response) {
                    $scope.students = response.data;
                });
            })
    }
})