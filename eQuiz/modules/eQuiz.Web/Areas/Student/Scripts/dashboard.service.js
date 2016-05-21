/// <reference path="E:\MyFork_eQuiz\eQuiz\modules\eQuiz.Web\Scripts/libs/angularjs/angular.js" />
(function (angular) {
    var equizModule = angular.module("equizModule");

    equizModule.service("dashboardService", ["$http", 
        function quizService($http) {
            return {
                getQuizzes: function (page, pageSize) {
                    return $http.get('GetQuizzes?page=' + page + '&pageSize=' + pageSize);
                }
            }
        }]);

    //function getQuestionsByIdAjax(id) {
    //    var promise = $http.post('GetQuestionsById', id, config)
    //    .success(function (data, status, headers, config) {
    //        console.log('Ok');
    //    })
    //    .error(function (data, status, header, config) {
    //        console.log('NotOk');
    //    });
    //};

})(angular);