function bindDropdown(ctrl, data, enableSelect2) {
    $(ctrl).children().remove();
    $.each(data, function (idx, elem) {
        $(ctrl).append('<option value="' + elem.Value + '">' + elem.Text + '</option>');
    });
    if (enableSelect2)
        convertToSelect2(ctrl);
}

function convertToSelect2(ctrl) {
    $(ctrl).select2('destroy');
    $(ctrl).select2();
}