/*
  处理异步请求4个认证
 */

//
var getTwoAndFace = function (twoAndFace) {
    return abp.ajax({
        url: 'ctids/getTwoAndFace',
        data: JSON.stringify(twoAndFace),
        enctype: 'multipart/form-data'

    }).done(function (data) {
        abp.notify.success('created new person with id = ' + data.personId);
    });
};

$(function () {

    var _ctidRecogService = abp.services.app.ctidRecog;
    var _$modal = $('#TwoAndFaceCreateModal');
    var _$form = _$modal.find('form');
    //abp.log(_$form);

    _$form.find('button[type="submit"]').click(function (e) {
        e.preventDefault();

        if (!_$form.valid()) {
            return;
        }

        var twoAndFace = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

        abp.ui.setBusy(_$modal);
        getTwoAndFace(twoAndFace).done(function () {
            _$modal.modal('hide');
            location.reload(true); //reload page to see new user!
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    });


    $('#ExportCtidRecogToExcelButton').click(function () {
        _ctidRecogService
            .getCtidRecogToExecl({})
            .done(function (result) {
                app.downloadTempFile(result);
            });
    });


});

