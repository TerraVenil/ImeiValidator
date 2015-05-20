function ImeiRequest(number) {
    var self = this;

    self.number = ko.observable(number);

    self.validate = function () {
        var requestObject = ko.toJSON(this);

        $.ajax({
            url: '/api/imeivalidation/validateImei',
            type: 'post',
            data: requestObject,
            contentType: 'application/json',
            success: function (respone) {
                app.viewModels['imeiViewModel'].responseImeiViewModel.status(respone.status);
            }
        });
    }
}

function ImeiResponse(status) {
    var self = this;

    self.status = ko.observable(status);
}