var app = angular.module('MyApp', [])
app.factory('teacherCrudservice', function ($http) {
    teacherObj = {};
    teacherObj.getAll = function () {
        var teachers;
        teachers = $http({ method: 'Get', url: '/Teacher/getlist' }).then(function (response) {
            return response.data;
        });
        return teachers;
    }
    teacherObj.getById = function () {
        var teacher;
        teacher = $http({method:'Get',url:'/Teacher/'})
    }
    return teacherObj;
});
app.controller('teacherControler', function ($scope, teacherCrudservice ) {

    teacherCrudservice.getAll().then(function (result) {
        $scope.teachers = result;
    });
    
    $scope.GetTeacher = function (id) {
        $http.get('/Teacher/GetTeacherById?id='+id).then(function (response) {
            $scope.teacher = response.data;
        });
    }
    
})