(function (app) {
    app.factory('notificationService', notificationService);

    function notificationService() {
        toastr.option = {
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "fadeIn": 300, // hiện lên trong vòng 0,3s
            "fadeOut": 1000,// tắt trong vòng 1s
            "timeOut": 3000,
            "extendedTimeOut": 1000
        };
        return {
            displaySuccess: displaySuccess,
            displayError: displayError,
            displayWarning: displayWarning,
            displayInfor: displayInfor
        }
        function displaySuccess(message) {
            toastr.success(message);
        }
        function displayError(error) {
            if (Array.isArray(error)) {
                error.each(function (err) {
                    toastr.error(err);
                });
            }
            else {
                toastr.error(error);
            }
        }
        function displayWarning(message) {
            toastr.warning(message);
        }
        function displayInfor(message) {
            toastr.infor(message);
        }
    }
})(angular.module('onlineShop.common'));