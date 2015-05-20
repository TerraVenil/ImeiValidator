(function ($, qUnit, pieChartViewModel) {
    "use strict";
    qUnit.asyncTest("initialize PieChartViewModel", function () {
        var statisticByRegions, mostPopularMaskNumbers, relationPhones;
        $.mockjax({
            url: '/api/Statistics/getStatisticByRegions',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            response: function (respone) {
                statisticByRegions = { label: 'Київська', value: 28, color: '#4D5360' };
            }
        });

        $.mockjax({
            url: '/api/Statistics/getMostPopularMaskNumbers',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            response: function (respone) {
                mostPopularMaskNumbers = { label: '0129*', value: 65, color: '#4747D1' };
            }
        });

        $.mockjax({
            url: '/api/Statistics/getRelationPhones',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            response: function (respone) {
                relationPhones = { label: 'Чорні', value: 75, color: '#F7464A' };
            }
        });

        var chartViewModel = new pieChartViewModel();
        chartViewModel.initialize();

        setTimeout(function () {
            qUnit.ok(true, "Passed and ready to resume!");
            start();
            qUnit.propEqual(statisticByRegions, { label: 'Київська', value: 28, color: '#4D5360' });
            qUnit.propEqual(mostPopularMaskNumbers, { label: '0129*', value: 65, color: '#4747D1' });
            qUnit.propEqual(relationPhones, { label: 'Чорні', value: 75, color: '#F7464A' });
        }, 100);
    });
}(jQuery, QUnit, PieChartViewModel));