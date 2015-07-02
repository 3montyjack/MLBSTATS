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
    var promiseOfId = $http.get('api/stats/table');
    promiseOfId.then(function (payload) {
        $scope.statTable = payload.data;
        alert(payload.data);
    });
    vm.title = 'User';
    activate();

    function activate() {
        common.activateController([], controllerId)
            .then(
                function() {
                     log('Activated User View');
                }
            );
    }
}