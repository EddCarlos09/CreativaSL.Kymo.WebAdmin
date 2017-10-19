var FormValidator = function () {
    "use strict";
    var validateCheckRadio = function (val) {
        $("input[type='radio'], input[type='checkbox']").on('ifChecked', function (event) {
            $(this).parent().closest(".has-error").removeClass("has-error").addClass("has-success").find(".help-block").hide().end().find('.symbol').addClass('ok');
        });
    };

    var runValidator = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);
        $.validator.addMethod("getEditorValue", function () {
            $("#editor1").val($('#form2 .summernote').code());
            if ($("#editor1").val() != "" && $("#editor1").val().replace(/(<([^>]+)>)/ig, "") != "") {
                $('#editor1').val('');
                return true;
            } else {
                return false;
            }
        }, 'This field is required.');
        //form2.validate({
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("ckeditor")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {

                ctl00$cph_MasterBody$txtGenero: {
                    minlength: 2,
                    required: true
                },
                ctl00$cph_MasterBody$txtLetra: {
                    minlength: 1,
                    required: true
                }

            },
            messages: {
                ctl00$cph_MasterBody$txtGenero: "Por favor, ingrese el g&eacutenero.",
                ctl00$cph_MasterBody$txtLetra: "Por favor, ingrese la sigla del g&eacutenero"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator1 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);

        $.validator.addMethod("validarImagen", function () {
            if (document.getElementById("cph_MasterBody_hf").value === '') {
                if ((document.getElementById("cph_MasterBody_imgImagen").value === ''))
                    return false;
                else
                    return true;
            }
            else
                return true;
        }, 'Debe seleccionar una imagen.');
        //var campo = $('#id_del_input').val();
        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("fileupload")) {
                    error.appendTo($(element).closest('.form-group'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                ctl00$cph_MasterBody$txtTitulo: {
                    required: true
                },
                ctl00$cph_MasterBody$txtTextoAlternativo: {
                    required: true
                },
                ctl00$cph_MasterBody$txtTituloImagen: {
                    required: true
                },
                ctl00$cph_MasterBody$imgImagen: "validarImagen",
                ctl00$cph_MasterBody$txtTituloDatos: {
                    required: true
                },
                ctl00$cph_MasterBody$txtTextoExtra: {
                    required: true
                }

            },
            messages: {
                ctl00$cph_MasterBody$txtTitulo: "Por favor, ingrese el t&iacute;tulo de la p&aacute;gina.",
                ctl00$cph_MasterBody$txtTituloImagen: "Por favor, ingrese el t&iacute;tulo de la imagen",
                ctl00$cph_MasterBody$txtTextoAlternativo: "Por favor, ingrese la un texto alternativo.",
                ctl00$cph_MasterBody$txtTituloDatos: "Por favor, ingrese el t&iacute;tulo de contacto",
                ctl00$cph_MasterBody$txtTextoExtra: "Por favor, ingrese el texto extra de contacto"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator2 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);

        $.validator.addMethod("MapRequired", function () {
            if ((document.getElementById("cph_MasterBody_hfLongitud").value === '') || (document.getElementById("cph_MasterBody_hfLatitud").value === '')) {
                return false;
            }
            else {
                return true;
            }
        }, 'Seleccione un punto en el mapa.');

        $.validator.addMethod("phoneNumbers", function () {
            var dataTxt = document.getElementById("cph_MasterBody_txtTelefonos").value;
            if (dataTxt === '') {
                return false;
            }
            else {
                var tagslist = dataTxt.split(",");
                if (tagslist.length < 3) {
                    var band = true;
                    for (var i = 0; i < tagslist.length; i++) {
                        console.log(tagslist[i])
                        if (!tagslist[i].match(/^[0-9]{10}$/)) {
                            band = false;
                            break;
                        }
                    }
                    return band;
                }
                else {
                    return false;
                }
            }
        }, 'Verifique que cada n&uacute;mero telef&oacute;nico cuente con el formato a 10 d&iacute;gitos. Solo se pueden agregar 3 n&uacute;meros telef&oacute;nicos.');

        $.validator.addMethod("Correos", function () {
            var CorreoTxt = document.getElementById("cph_MasterBody_txtCorreo").value;
            if (CorreoTxt === '') {
                return false;
            }
            else {
                var tagslist = CorreoTxt.split(",");
                if (tagslist.length < 3) {
                    var band = true;
                    for (var i = 0; i < tagslist.length; i++) {
                        console.log(tagslist[i])
                        if (!tagslist[i].match(/^(?:[^<>()[\].,;:\s@"]+(\.[^<>()[\].,;:\s@"]+)*|"[^\n"]+")@(?:[^<>()[\].,;:\s@"]+\.)+[^<>()[\]\.,;:\s@"]{3,63}$/i)) {
                            band = false;
                            break;
                        }
                    }
                    return band;
                }
                else {
                    return false;
                }
            }
        }, 'Verifique que cada direcci&oacute;n de correo electr&oacute;nico contenga el formato de nombre@dominio.com');

        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.hasClass("map")) {
                    error.appendTo($(element).closest('.map'));
                } else if (element.hasClass("map")) {
                    error.appendTo($(element).closest('.map'));
                } else {
                    error.insertAfter(element);
                }
            },
            ignore: "",
            rules: {
                ctl00$cph_MasterBody$hfLatitud: "MapRequired",
                ctl00$cph_MasterBody$address: { required: true },
                ctl00$cph_MasterBody$txtTitulo: { required: true },
                ctl00$cph_MasterBody$txtTexto: { required: true },
                ctl00$cph_MasterBody$txtCorreo: "Correos",
                ctl00$cph_MasterBody$txtTelefonos: "phoneNumbers"

            },
            messages: {
                //ctl00$cph_MasterBody$txtTelefonos: { required: "Debe ingresar al menos un n&uacute;mero de tel&eacute;fono." },
                ctl00$cph_MasterBody$address: { required: "Debe ingresar la direcci&oacute;n de contacto." },
                ctl00$cph_MasterBody$txtTitulo: { required: "Debe ingresar el t&iacute;tulo a mostrar en la p&aacute;gina de contacto." },
                ctl00$cph_MasterBody$txtTexto: { required: "Debe ingresar el texto a mostrar en la p&aacute;gina de contacto." }//,
                //ctl00$cph_MasterBody$txtCorreo: {
                //    required: "Debe ingresar una direcci&oacute;n de correo electr&oacute;nico de contacto.",
                //    email: "Su direcci&oacute;n de correo electr&oacute;nico debe tener el formato de nombre@dominio.com"
                //}
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                successHandler2.show();
                errorHandler2.hide();
                this.submit();
            }
        });
    };

    var runValidator3 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);

        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                cmbRedSocial: {
                    required: true
                },
                ctl00$cph_MasterBody$txtNickName: {
                    required: true
                }
            },
            messages: {
                cmbRedSocial: "Por favor, Selecciones una red social.",
                ctl00$cph_MasterBody$txtNickName: "Por favor, Ingrese el perfil de la red social"
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };

    var runValidator4 = function () {
        var form2 = $('#frmMaster');
        var errorHandler2 = $('.errorHandler', form2);
        var successHandler2 = $('.successHandler', form2);

        $('#frmMaster').validate({
            errorElement: "span", // contain the error msg in a small tag
            errorClass: 'help-block',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                ctl00$cph_MasterBody$txtCorreoEnvio: {
                    required: true,
                    email: true
                },
                ctl00$cph_MasterBody$txtPassword: {
                    required: true
                },
                ctl00$cph_MasterBody$txtCorreoDestino: {
                    required: true,
                    email: true
                },
                ctl00$cph_MasterBody$txtHost: {
                    required: true
                },
                ctl00$cph_MasterBody$txtPuerto: {
                    required: true,
                    number: true,
                },
            },
            messages: {
                ctl00$cph_MasterBody$txtCorreoEnvio: {
                    required: "Por favor, ingrese el correo de env&iacute;o",
                    email: "Por favor, verifique que el correo electr&oacute;nico tenga el formato correcto 'nombre@dominio.com'"
                },
                ctl00$cph_MasterBody$txtPassword: "Por favor, ingrese el password del correo",
                ctl00$cph_MasterBody$txtCorreoDestino: {
                    required: "Por favor, ingrese el correo de destino",
                    email: "Por favor, verifique que el correo electr&oacute;nico tenga el formato correcto 'nombre@dominio.com'"
                },
                ctl00$cph_MasterBody$txtHost: "Por favor, ingrese el host de env&iacute;o",
                ctl00$cph_MasterBody$txtPuerto: {
                    required: "Por favor, ingrese un puerto saliente de correo",
                    number: "Por favor, verfique el puerto",
                }
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler2.hide();
                errorHandler2.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form2) {
                //successHandler2.show();
                errorHandler2.hide();
                // submit form
                this.submit();
                //$('#frmMaster').trigger("submit");
            }
        });
    };
    return {
        //main function to initiate template pages
        init: function (aux) {
            //runValidator();
            switch (aux) {
                case 1: runValidator();
                    break;
                case 2: runValidator1();
                    break;
                case 3: runValidator2();
                    break;
                case 4: runValidator3();
                    break;
                case 5: runValidator4();
                    break;
            }
        }
    };
}();
