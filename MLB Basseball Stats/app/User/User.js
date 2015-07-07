'use strict';
var controllerId = 'user';
angular.module('app').controller(controllerId, ['common', '$scope', '$http', user]);

function user(common, $scope, $http) {
    /// <summary></summary>
    /// <param name="common" type=""></param>
    var getLogFn = common.logger.getLogFn;
    var log = getLogFn(controllerId);

    var vm = this;
    //var id;
    var promiseOfTeam = $http.get('api/stats/TeamTable');
    promiseOfTeam.then(function (payload) {
        $scope.teamTable = payload.data;
        //$scope.id = payload.data;
        //alert(payload.data);
    });

    var promiseOfPlayer = $http.get('api/stats/PlayerTable');
    promiseOfPlayer.then(function (payload) {
        $scope.playerTable = payload.data;
        //$scope.id = payload.data;
        //alert(payload.data);
    });


    var team = "XYZ";
    $scope.sortPlayers = function (teamValue , teamName) {
        //alert(teamValue);
        team = teamValue;
        $scope.TTeam = teamName;
    }

    

    $scope.filterPlayers = function (player) {
        if (team == "") {
            return true;
        }
        return player.Team == team;
    }


    vm.title = 'Statistics';
    activate();

    function activate() {
        common.activateController([], controllerId)
            .then(
                function () {
                    log('Activated User View');
                }
            );
    }
}