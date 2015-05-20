function AppViewModel() {
    // Private state
    var self = this;

    self.viewModels = {
        imeiViewModel: { requestImeiViewModel: new ImeiRequest(), responseImeiViewModel: new ImeiResponse() },
        pieChartViewModel : new PieChartViewModel().initialize()
    };
}

var app = new AppViewModel();