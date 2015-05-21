function AppViewModel() {
    // Private state
    var self = this;

    self.viewModels = {
        imeiViewModel: { requestImeiViewModel: new ImeiRequest(), responseImeiViewModel: new ImeiResponse() },
        pieChartViewModel : new PieChartViewModel()
    };

    self.viewModels['pieChartViewModel'].initialize();
}

var app = new AppViewModel();