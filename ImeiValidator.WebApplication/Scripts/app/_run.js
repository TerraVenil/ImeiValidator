$(function () {
    // Activate Knockout
    ko.validation.init({ grouping: { observable: false } });
    ko.applyBindings(app);
});
