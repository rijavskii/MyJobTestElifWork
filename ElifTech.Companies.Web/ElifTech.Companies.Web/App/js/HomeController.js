
//angular.module('eliftechApp', []).controller('HomeController', ['$scope', '$http', function ($httpProvider, $scope, $http) {

//    $scope.company = {};

//    $scope.update = function (user) {

//        $scope.company = angular.copy(user);
//    };
    
//    $http.get("api/companies/get/company")
//    .then(function (response) { $scope.companies = response.data.records; });

//    $scope.AddToDbFunc = function () {


//        $http({

//            url: '',
//            method: 'POST',
//        })
//    };
   
//}]);
eliftech.controller('HomeController', function ($scope, $http) {
    $scope.company = {
    name:'sfasf'};

        $scope.update = function (user) {

            $scope.company = angular.copy(user);
        };

    $http.get("companies")
        .then(function (response) { $scope.companies = response.data.records; });

    $scope.AddToDbFunc = function () {

        $http.post("companies", $scope.company);

            };
    
});