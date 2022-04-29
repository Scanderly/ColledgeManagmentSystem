var app = angular.module('MyApp', ['angularUtils.directives.dirPagination']);

app.controller('teacherController', function ($scope, $http) {
    //GEt all Teachers
    $http.get('/Teacher/GetList').then(function (response) {
        $scope.teachers = response.data;
    });
    //Get Teacher by Id
    $scope.GetTeacher = function (tid) {
        $http({ method: 'Get', url: '/Teacher/GetTeacherById', params: { id: tid } }).then(function (response) {
            $scope.teacher = response.data;
        });
    }
    //Update teacher
    $scope.EditTeacher = function (teacher) {
        $http({ method: 'POST', url: '/Teacher/Update', data: teacher })
            .then(function (response) {
                $scope.Msg = response.FullName + " " + "Updated succesfully";

                $http.get('/Teacher/GetList').then(function (response) {
                    $scope.teachers = response.data;
                });
            })
    }
    //Delete teacher
    $scope.DeleteTeacher = function (tid) {
        $http({ method: 'POST', url: '/Teacher/Delete', params: { id: tid } })
            .then(function (response) {
                $scope.Msg ="Removed succesfully";
            })
    }
    //Create teacher
    $scope.CreateTeacher = function (teacher) {
        $http({ method: 'POST', url: '/Teacher/Create', data: teacher })
            .then(function (response) {
                $scope.Msg = response.FullName +" "+ "Created succesfully";
            })
    }

})
//app.factory('teacherCrudservice', function ($http) {
//    teacherObj = {};

//    teacherObj.getAll = function () {
//        var teachers;
//        teachers = $http({ method: 'Get', url: '/Teacher/GetList' }).then(function (response) {
//            return response.data;
//        });
//        return teachers;
//    }

//    teacherObj.getById = function (tid) {
//        var teacher;
//        teacher = $http({ method: 'Get', url: '/Teacher/GetTeacherById', params: { id=tid } })
//            .then(function (result) {
//                return result.data;
//            });
//        return teacher;
//    }
//    return teacherObj;
//});
//app.controller('teacherController', function ($scope, teacherCrudservice) {

//    teacherCrudservice.getAll().then(function (result) {
//        $scope.teachers = result;
//    });

//    teacherCrudservice.getById().then(function (response) {
//        $scope.teacher = response;
//    })


//})
