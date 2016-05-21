
(function (angular) {
    var equizModule = angular.module("equizModule");

    equizModule.controller("dashboardCtrl", ["$scope", "$http", "$location", "$routeParams", "dashboardService", 
        function ($scope, $http, $location, $routeParams, dashboardService) {
        
        $scope.quizzes = [];

        $scope.isSearching = false;

        $scope.page = 0;
        $scope.pagesCount = 0;

        $scope.search = function (page) {
            page = page || 0;

            var _onSuccess = function (value) {
                $scope.page = value.data.Page;
                $scope.pagesCount = value.data.TotalPages;
                $scope.totalCount = value.data.TotalCount;
                $scope.isSearching = false;
                $scope.quizzes = value.data.Items;
                console.log($scope.quizzes);
            };
            var _onError = function () {
                $scope.isSearching = false;
                console.log("Cannot load quizzes list");
            };

            $scope.isSearching = true;

            dashboardService.getQuizzes(page, pageSize = 3)
                .then(_onSuccess, _onError);
        };

        $scope.search();

        //activate();
        //function activate() {
        //    var quizPromise = dashboardService.getQuizzes();
        //    quizPromise.success(function (data) {
        //        $scope.allQuizes = data;
        //    });
        //};

        //$scope.getQuestionById = function (questionId) {

        //    $http({
        //        method: "GET",
        //        url: "GetQuestionsById",
        //        params: { id: questionId }

        //    }).then(function (response) {
        //        console.log(response.data);
        //    });
        //};
    }]);

})(angular);