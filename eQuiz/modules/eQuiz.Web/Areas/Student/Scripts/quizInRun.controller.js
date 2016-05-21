/// <reference path="D:\MyFork_eQuiz\eQuiz\modules\eQuiz.Web\Scripts/libs/angularjs/angular.js" />
(function (angular) {
    var equizModule = angular.module("equizModule");

    equizModule.controller("quizInRunCtrl", ["$scope", "$http", "$routeParams", function ($scope, $http, $routeParams) {
        $scope.quizQuestions = null;
        $scope.quizId = $routeParams.id;
        $scope.quizDuration = $routeParams.dura;
        $scope.currentQuestion = 0;
        $scope.finalUserResult = [];

        $scope.setCurrentQuestion = function (questionId) {
            if (questionId < $scope.quizQuestions.length && questionId >= 0)
            $scope.currentQuestion = questionId;
        };

        getQuestionById($scope.quizId);

        function getQuestionById(questionId) {
            $http({
                method: "GET",
                url: "GetQuestionsById",
                params: { id: questionId }

            }).then(function (response) {
                console.log(response.data);
                $scope.quizQuestions = response.data;
            });
        };

    }]);
})(angular);