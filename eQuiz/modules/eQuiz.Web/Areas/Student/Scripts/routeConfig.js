/// <reference path="templetes/QuizInRunTemplete.html" />
(function (angular) {
    var equizModule = angular.module("equizModule");
    equizModule.config(function ($routeProvider) {
        $routeProvider.when("/", {
            templateUrl: "/Areas/Student/Scripts/templates/DashboardTemplate.html",
            controller: "dashboardCtrl",
            controllerAs: "dashboardCtrl"
        })
        .when("/quizInRun/:id/:dura/", {
            templateUrl: "/Areas/Student/Scripts/templates/QuizInRunTemplate.html",
            controller: "quizInRunCtrl",
            controllerAs: "quizCtrl"
        })
        .otherwise({
            redirectTo: '/'
        });

    });
})(angular);