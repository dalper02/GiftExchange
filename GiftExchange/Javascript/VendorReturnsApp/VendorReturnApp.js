var VendorReturnApp = angular.module('VendorReturnApp', ['ngAnimate', 'ngRoute']);


VendorReturnApp.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider.
            when('/', {
                templateUrl: '/Javascript/VendorReturnsApp/Templates/ReturnsReport.html',
                controller: 'ViewController'
            }).
            when('/view/:returnid', {
                templateUrl: '/Javascript/VendorReturnsApp/Templates/ViewReturn.html',
                controller: 'ViewController'
            }).
            when('/route2', {
                templateUrl: '/Javascript/VendorReturnsApp/Templates/ViewReturn.html',
                //controller: 'VendorReturnController'
            }).
            otherwise({
                redirectTo: '/'
            });
    }]);

VendorReturnApp.controller('VendorReturnController',
function ($http, $scope, $rootScope, $filter) {

    $http({
        url: '/Vendor/GetReturns',
        method: "GET",
        //headers: {
        //    'Content-type': 'application/json'
        //},
    }).success(function (data, status, headers, config) {
        //var blob = new Blob([data], { type: "application/pdf" });
        //saveAs(blob, 'Resume.pdf');
        console.log(data);
        $scope.ReturnRequests = data;
        $scope.confirmationPage = true;

    }).error(function (data, status, headers, config) {
        console.log(status);
        console.log(data);
        //upload failed
    });

});


VendorReturnApp.controller('ViewController',
function ($http, $scope, $routeParams, $filter) {
    $scope.returnid = $routeParams.returnid;

    $http({
        url: '/Vendor/GetReturn/' + $scope.returnid,
        method: "GET",
        //headers: {
        //    'Content-type': 'application/json'
        //},
    }).success(function (data, status, headers, config) {
        //var blob = new Blob([data], { type: "application/pdf" });
        //saveAs(blob, 'Resume.pdf');
        console.log(data);
        $scope.ReturnRequest = data;
        $scope.confirmationPage = true;

    }).error(function (data, status, headers, config) {
        console.log(status);
        console.log(data);
        //upload failed
    });

    $scope.goto = function(location)
    {
        alert('hello');
        //window.location.replace(location);
    }

    $scope.CreateNewReturnOffer = function (ReturnRequest)
    {
        console.log('starting');

        //$http({
        //    url: '/api/getbook',
        //    method: "POST"
        //    //responseType: 'arraybuffer'
        //}).success(function (data, status, headers, config) {
        //    //var blob = new Blob([data], { type: "application/pdf" });
        //    //saveAs(blob, 'Resume.pdf');
        //    console.log('success');
        //    console.log(data);
        //    $scope.Return = data;
        //    $scope.confirmationPage = true;

        //}).error(function (data, status, headers, config) {
        //    console.log('failure');
        //    console.log(status);
        //    //console.log(data);
        //    //upload failed
        //});


        $http({
            url: '/Vendor/SaveReturnOffer',
            method: "POST",
            data: ReturnRequest, //this is your json data string
            headers: {
                'Content-type': 'application/json'
            },
            //responseType: 'arraybuffer'
        }).success(function (data, status, headers, config) {
            //var blob = new Blob([data], { type: "application/pdf" });
            //saveAs(blob, 'Resume.pdf');
            console.log(data);
            $scope.Return = data;
            $scope.confirmationPage = true;

        }).error(function (data, status, headers, config) {
            //upload failed
        });

    }

});