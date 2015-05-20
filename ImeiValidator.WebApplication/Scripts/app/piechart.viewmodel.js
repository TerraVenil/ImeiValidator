function PieChartViewModel() {
    var self = this;

    var context3 = document.getElementById('pie-chart3').getContext('2d');
    var pieChart3 = new Chart(context3).Pie([
      { label: 'Чорні', value: 75, color: '#F7464A' },
      { label: 'Білі', value: 23, color: '#4D5360' }
    ], { labelAlign: 'center' });

    self.initialize = function () {
        loadStatisticByRegions();
        loadMostPopularMaskNumbers();
    }

    var loadStatisticByRegions = function () {
        $.ajax({
            url: '/api/Statistics/getStatisticByRegions',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                var chartData = mappingFromResponse(respone);

                var context1 = document.getElementById('pie-chart1').getContext('2d');
                var pieChart1 = new Chart(context1).Pie(chartData);
            }
        });
    };

    var loadMostPopularMaskNumbers = function () {
        $.ajax({
            url: '/api/Statistics/getMostPopularMaskNumbers',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                var chartData = mappingFromResponse(respone);

                var context2 = document.getElementById('pie-chart2').getContext('2d');
                var pieChart2 = new Chart(context2).Pie(chartData);
            }
        });
    };

    var mappingFromResponse = function (data) {
        return $.map(data, function (item, i) {
            return { label: item.label, value: item.value, color: item.color };
        });
    }
}