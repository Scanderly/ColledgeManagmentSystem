var app = angular.module('MyApp', ['angularUtils.directives.dirPagination']);

app.controller('courseController', function ($scope, $http) {
    //GEt all Courses
    $http.get('/Course/GetList').then(function (response) {
        $scope.courses = response.data;
    });
    //Get Course by Id
    $scope.GetCourse = function (tid) {
        $http({ method: 'Get', url: '/Course/GetCourseById', params: { id: tid } }).then(function (response) {
            $scope.course = response.data;
        });
    }
    //Update Course
    $scope.EditCourse = function (course) {
        $http({ method: 'POST', url: '/Course/Update', data: course })
            .then(function (response) {
                $scope.Msg = response.Name + " " + "Updated succesfully";

                $http.get('/Course/GetList').then(function (response) {
                    $scope.courses = response.data;
                });
            })
    }
    //Delete Course
    $scope.DeleteCourse = function (tid) {
        $http({ method: 'POST', url: '/Course/Delete', params: { id: tid } })
            .then(function (response) {
                $scope.Msg = "Removed succesfully";
            })
    }
    //Create Course
    $scope.CreateCourse = function (course) {
        $http({ method: 'POST', url: '/Course/Create', data: course })
            .then(function (response) {
                $scope.Msg = response.Name + " " + "Created succesfully";
            })
    }

})