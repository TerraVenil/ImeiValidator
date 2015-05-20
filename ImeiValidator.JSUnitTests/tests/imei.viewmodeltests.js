(function ($, qUnit, imeiRequestViewModel) {
    "use strict";
    qUnit.test("initialize ImieRequestViewModel", function () {
        var imeRequestViewModel = new imeiRequestViewModel();
        qUnit.equal(imeRequestViewModel.number.length, 0);
    });

    qUnit.test("initialize ImieRequestViewModel with number", function () {
        var imeRequestViewModel = new imeiRequestViewModel(6);
        qUnit.equal(imeRequestViewModel.number(), 6);
    });
}(jQuery, QUnit, ImeiRequest));