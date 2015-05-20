function PieChartViewModel() {
    var self = this;

    self.initialize = function () {
        loadStatisticByRegions();
        loadMostPopularMaskNumbers();
        loadRelationPhones();
    }

    var loadStatisticByRegions = function () {
        $.ajax({
            url: '/api/Statistics/getStatisticByRegions',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                var context1 = document.getElementById('pie-chart1').getContext('2d');
                var pieChart1 = new Chart(context1).Pie(respone);
            }
        });
    };

    var loadMostPopularMaskNumbers = function () {
        $.ajax({
            url: '/api/Statistics/getMostPopularMaskNumbers',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                var context2 = document.getElementById('pie-chart2').getContext('2d');
                var pieChart2 = new Chart(context2).Pie(respone);
            }
        });
    };

    var loadRelationPhones = function () {
        $.ajax({
            url: '/api/Statistics/getRelationPhones',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                var context3 = document.getElementById('pie-chart3').getContext('2d');
                var pieChart3 = new Chart(context3).Pie(respone);
            }
        });
    };
}