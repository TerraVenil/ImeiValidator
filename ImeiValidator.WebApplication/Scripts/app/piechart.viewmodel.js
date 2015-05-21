function PieChartViewModel() {
    var self = this;

    self.dummyRegions = ko.observable();
    self.dummyPhoneNumbers = ko.observable();
    self.dummyPhones = ko.observable();

    var regionsData, phoneNumbersData, phonesData;

    self.regions = ko.computed(function () {
        self.dummyRegions();
        return regionsData;
    }, this);

    self.phoneNumbers = ko.computed(function () {
        self.dummyPhoneNumbers();
        return phoneNumbersData;
    }, this);

    self.phones = ko.computed(function () {
        self.dummyPhones();
        return phonesData;
    }, this);

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
                regionsData = respone;
                self.dummyRegions.notifySubscribers();
            }
        });
    };

    var loadMostPopularMaskNumbers = function () {
        $.ajax({
            url: '/api/Statistics/getMostPopularMaskNumbers',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                phoneNumbersData = respone;
                self.dummyPhoneNumbers.notifySubscribers();
            }
        });
    };

    var loadRelationPhones = function () {
        $.ajax({
            url: '/api/Statistics/getRelationPhones',
            type: 'get',
            contentType: 'application/json',
            success: function (respone) {
                phonesData = respone;
                self.dummyPhones.notifySubscribers();
            }
        });
    };
}
