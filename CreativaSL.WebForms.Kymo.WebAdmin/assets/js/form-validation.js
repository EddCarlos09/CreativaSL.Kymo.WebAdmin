var FormValidator = function () {
	"use strict";
	var validateCheckRadio = function (val) {
        $("input[type='radio'], input[type='checkbox']").on('ifChecked', function(event) {
			$(this).parent().closest(".has-error").removeClass("has-error").addClass("has-success").find(".help-block").hide().end().find('.symbol').addClass('ok');
		});
    }; 
    // function to initiate Validation Sample 1
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
	            ctl00$cph_MasterBody$txtNombre: {
	                required: true
	            },
	            ctl00$cph_MasterBody$txtPuesto: {
	                required: true
	            },
	            ctl00$cph_MasterBody$txtTextoAlternativo: {
	                required: true
	            },
	            ctl00$cph_MasterBody$txtTituloImagen: {
	                required: true
	            },
	            ctl00$cph_MasterBody$imgImagen: "validarImagen."

	        },
	        messages: {
	            ctl00$cph_MasterBody$txtTitle: "Por favor, ingrese el nombre.",
	            ctl00$cph_MasterBody$txtPuesto: "Por favor, ingrese el puesto.",
	            ctl00$cph_MasterBody$txtTituloImagen: "Por favor, ingrese el t&iacute;tulo de la imagen.",
	            ctl00$cph_MasterBody$txtTextoAlternativo: "Por favor, ingrese la un texto alternativo."
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
	            ctl00$cph_MasterBody$txtNickName: {
	                required: true
	            }
	        },
	        messages: {
	            ctl00$cph_MasterBody$txtNickName: "Por favor, ingrese el perfil de la red social."

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
	            case 1: runValidator1();
	                break;
	            case 2: runValidator2();
	                break;
	        }
	    }
	};
}();