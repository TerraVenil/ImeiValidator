var imeiViewModel;

function ImeiRequest(number) {
    var self = this;

    self.number = ko.observable(number);

    self.validate = function () {
        var requestObject = ko.toJSON(this);

        $.ajax({
            url: '/api/imeivalidation',
            type: 'post',
            data: requestObject,
            contentType: 'application/json',
            success: function (respone) {
                imeiViewModel.responseImeiViewModel.status(respone.status);
            }
        });
    }
}

function ImeiResponse(status) {
    var self = this;

    self.status = ko.observable(status);
}

imeiViewModel = { requestImeiViewModel: new ImeiRequest(), responseImeiViewModel: new ImeiResponse() }

$(document).ready(function () {
    ko.applyBindings(imeiViewModel);
});