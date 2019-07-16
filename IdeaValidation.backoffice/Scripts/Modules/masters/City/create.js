var stateList = {};

$(document).ready(function () {
    convertToSelect2($('#selectCountry'));
    $('#selectCountry').on('change', function (e) {
        var countryId = this.value;
        var data = [];
        if (_.has(stateList, countryId)) {
            data = stateList[countryId];
            bindDropdown($('#StateID'), data, true);
        }
        else {
            $.ajax({
                url: '/Master/GetStateByCountry?countryId=' + countryId,
                dataType: 'json',
                success: function (result) {
                    var data = result.Data;
                    stateList[countryId] = data;
                    bindDropdown($('#StateID'), data, true);
                }
            })
        }
    });
});



function OnSuccess(result) {
    if (result === 1) {
        $.smallBox({
            title: "Ding Dong!",
            content: "City Added succesfully",
            color: "green",
            icon: "fa fa-check swing animated"
        });
        $('#lastRecordCode').html('Last record saved : ' + $('#Name').val() + ' (State : ' + $("#StateID option:selected").text() + ')');
        $('#Name').val('');
        $('#CityCode').val('');
    }
    else {
        OnFailure();
    }
}

function OnFailure(err) {
    $.smallBox({
        title: "Sorry!",
        content: "Unable to save this record",
        color: "red",
        icon: "fa fa-tick swing animated"
    });
}