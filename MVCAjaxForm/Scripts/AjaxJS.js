//全局变量
var Global = {};
Global.FormHelper = function (formElement, options, onSuccess, onError) {
    //全局变量
    var settings = {};
    settings = $.extend({}, settings, options);
    formElement.validate(settings.validateSettings);
    formElement.submit(function (e) {
        if (formElement.valid()) {
            $.ajax(formElement.attr("action"), {
                type: "POST",
                data: formElement.serializeArray(),
                success: function (result) {
                    if (onSuccess === null || onSuccess === undefined) {
                        if (result.isSuccess) {
                            window.location.href = result.redirectUrl;
                        }
                        else {
                            if (settings.updateTargetId) {
                                $("#" + settings.updateTargetId).html(result.data);
                            }
                        }
                    }
                    else {
                        onSuccess(result);
                    }
                },
                error: function (jqXHR, status, error) {
                    if (onError !== null && onError !== undefined) {
                        onError(jqXHR, status, error);
                        $("#" + settings.updateTargetId).html(error);
                    }
                },
                conplete: function () {

                }
            });
        }
        e.preventDefault();
    });
    return formElement;
};