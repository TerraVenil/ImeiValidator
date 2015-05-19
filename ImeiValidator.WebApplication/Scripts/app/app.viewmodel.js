function AppViewModel() {
    // Private state
    var self = this;

    self.viewModels = {
        imeiViewModel: { requestImeiViewModel: new ImeiRequest(), responseImeiViewModel: new ImeiResponse() },
        pieChartViewModel : new PieChartViewModel()
    };
}

var app = new AppViewModel();