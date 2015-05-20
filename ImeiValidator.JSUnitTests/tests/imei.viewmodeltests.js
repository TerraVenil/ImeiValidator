(function ($, qUnit, imeiRequestViewModel) {
    "use strict";
    qUnit.test("initialize ImeiRequestViewModel", function () {
        var imeRequestViewModel = new imeiRequestViewModel();
        qUnit.equal(imeRequestViewModel.number.length, 0);
    });

    qUnit.test("initialize ImeiRequestViewModel with number", function () {
        var imeRequestViewModel = new imeiRequestViewModel(6);
        qUnit.equal(imeRequestViewModel.number(), 6);
    });

    qUnit.asyncTest("validate ImeiRequestViewModel with number", function () {
        var status;
        $.mockjax({
            url: '/api/imeivalidation',
            type: 'post',
            responseTime: 30,
            contentType: 'application/json',
            response: function(response) {
                status = "Validation is success";
            }
        });

        var imeRequestViewModel = new imeiRequestViewModel(6);
        imeRequestViewModel.validate();

        setTimeout(function() {
            qUnit.ok(true, "Passed and ready to resume!");
            start();
            qUnit.equal(status, "Validation is success");
        }, 100);
    });
}(jQuery, QUnit, ImeiRequest));

(function ($, qUnit, imeiResponseViewModel) {
    "use strict";
    qUnit.test("initialize ImeiResponseViewModel", function () {
        var imeResponseViewModel = new imeiResponseViewModel();
        qUnit.equal(imeResponseViewModel.status.length, 0);
    });

    qUnit.test("initialize ImeiResponseViewModel with status", function () {
        var imeResponseViewModel = new imeiResponseViewModel("Validation failed");
        qUnit.equal(imeResponseViewModel.status(), "Validation failed");
    });
}(jQuery, QUnit, ImeiResponse));