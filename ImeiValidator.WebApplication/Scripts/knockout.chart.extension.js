(function (ko, Chart) {

    ko.bindingHandlers.chartType = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            if (!allBindings.has('chartData')) {
                throw Error('chartType must be used in conjunction with chartData and (optionally) chartOptions');
            }
        },
        update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            var ctx = element.getContext('2d'),
              type = ko.unwrap(valueAccessor()),
              data = ko.unwrap(allBindings.get('chartData')),
              options = ko.unwrap(allBindings.get('chartOptions')) || {};

            ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
                $(element).chart.destroy();
                delete $(element).chart;
            });

            $(element).chart = new Chart(ctx)[type](data, options);
        }
    };

    ko.bindingHandlers.chartData = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            if (!allBindings.has('chartType')) {
                throw Error('chartData must be used in conjunction with chartType and (optionally) chartOptions');
            }
        }
    };

    ko.bindingHandlers.chartOptions = {
        init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
            if (!allBindings.has('chartData') || !allBindings.has('chartType')) {
                throw Error('chartOptions must be used in conjunction with chartType and chartData');
            }
        }
    };

})(ko, Chart);