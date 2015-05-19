function PieChartViewModel() {
    var context1 = document.getElementById('pie-chart1').getContext('2d');
    var pieChart1 = new Chart(context1).Pie([
        { label: 'Волинська', value: 16, color: '#F7464A' },
        { label: 'Київська', value: 28, color: '#4D5360' },
        { label: 'Чернигівська', value: 15, color: '#00FF00' },
        { label: 'Львівська', value: 14, color: '#248F24' },
        { label: 'Донецька', value: 19, color: '#7DDEFF' },
        { label: 'Дніпропетровська', value: 5, color: '#336680' }
    ]);
    var context2 = document.getElementById('pie-chart2').getContext('2d');
    var pieChart2 = new Chart(context2).Pie([
        { label: '0129*', value: 65, color: '#4747D1' },
        { label: '5223*', value: 20, color: '#FF19FF' },
        { label: '8856*', value: 5, color: '#5C5C33' },
        { label: '5896*', value: 7, color: '#CC6699' }
    ]);
    var context3 = document.getElementById('pie-chart3').getContext('2d');
    var pieChart3 = new Chart(context3).Pie([
      { label: 'Чорні', value: 75, color: '#F7464A' },
      { label: 'Білі', value: 23, color: '#4D5360' }
    ], { labelAlign: 'center' });
}