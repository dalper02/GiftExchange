var giftExchangeApp = angular.module('giftExchangeApp', ['ngAnimate']);
//var giftExchangeApp = angular.module('giftExchangeApp', ['googleplus', 'facebook', 'ngAnimate', 'ui.bootstrap']);


giftExchangeApp.controller('giftExchangeController',
function ($http, $scope, $rootScope, $filter) {

    $scope.NewUPC = '';
    $scope.productReturns = [];

    $scope.confirmationPage = false;


    $scope.RemoveReturn = function (productReturn) {
        var index = $scope.productReturns.indexOf(productReturn);
        if (index > -1) {
            $scope.productReturns.splice(index, 1);
        }
    }


    
    $scope.AddUPC = function () {
        if ($scope.NewUPC.length < 1) {
            alert('Please Enter UPC');
            return;
        }


        $http({
            url: '/MyExchange/FindUPC/' + $scope.NewUPC,
            method: "GET",
        }).success(function (data, status, headers, config) {

            if (data.UPC == undefined || data.UPC.length == 0 || data.description == undefined || data.description.length == 0) {
                alert('Product Not Found');
                return;
            }

            $scope.productReturns.push(data);
            $scope.NewUPC = '';

        }).error(function (data, status, headers, config) {
            alert(status);
            console.log(status);
        });


    };


    $scope.SaveReturns = function () {
        $http({
            url: '/MyExchange/SaveReturns',
            method: "POST",
            data: $scope.productReturns, //this is your json data string
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