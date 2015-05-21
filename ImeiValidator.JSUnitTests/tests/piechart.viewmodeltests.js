(function ($, qUnit, pieChartViewModel) {
    "use strict";
    qUnit.asyncTest("initialize PieChartViewModel", function () {
        var statisticByRegions, mostPopularMaskNumbers, relationPhones;
        $.mockjax({
            url: '/api/Statistics/getStatisticByRegions',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            responseText: JSON.stringify({ label: 'Київська', value: 28, color: '#4D5360' })
        });

        $.mockjax({
            url: '/api/Statistics/getMostPopularMaskNumbers',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            responseText: JSON.stringify({ label: '0129*', value: 65, color: '#4747D1' })
        });

        $.mockjax({
            url: '/api/Statistics/getRelationPhones',
            type: 'get',
            responseTime: 30,
            contentType: 'application/json',
            responseText: JSON.stringify({ label: 'Чорні', value: 75, color: '#F7464A' })
        });

        var chartViewModel = new pieChartViewModel();
        chartViewModel.initialize();

        setTimeout(function () {
            qUnit.ok(true, "Passed and ready to resume!");
            start();
            qUnit.propEqual(chartViewModel.regions(), { label: 'Київська', value: 28, color: '#4D5360' });
            qUnit.propEqual(chartViewModel.phoneNumbers(), { label: '0129*', value: 65, color: '#4747D1' });
            qUnit.propEqual(chartViewModel.phones(), { label: 'Чорні', value: 75, color: '#F7464A' });
        }, 100);
    });
}(jQuery, QUnit, PieChartViewModel));