(function () {

    $.validator.addMethod('confirmpassword', function (value, element, params) {

        return value == $("#Password").val();
    });

    $.validator.unobtrusive.adapters.add('confirmpassword', function (options) {

        var element = $(options.form).find('#confirm_password')[0];

        options.rules['confirmpassword'] = [element];
        options.messages['confirmpassword'] = options.message;
    });


}());
