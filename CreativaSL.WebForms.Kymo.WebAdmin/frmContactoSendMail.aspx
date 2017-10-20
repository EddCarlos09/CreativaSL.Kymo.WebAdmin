<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmContactoSendMail.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmContactoSendMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
     <div class="row">
        <div class="col-md-12">
        </div> 
        <div class="col-sd-12">
            <div class="panel panel-white">
                <div class="panel-heading">
                    <h4 class="panel-title"><span class="text-bold">DATOS CONTACTOS SEND-EMAIL</span></h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <asp:HiddenField ID="hf" runat="server" />
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="errorHandler alert alert-danger no-display">
                                <i class="fa fa-times-sign"></i>Hay errores en la captura de información. Revise las especificaciones de los campos.
                            </div>
                            <div class="successHandler alert alert-success no-display">
                                <i class="fa fa-ok"></i>Your form validation is successful!
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtCorreoEnvio">
                                    Correo Env&iacute;o<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtCorreoEnvio" name="txtCorreoEnvio" maxlength="300" data-original-title="Ingrese el correo env&iacute;o" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtPassword">
                                    Password<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtPassword" name="txtPassword" maxlength="50" data-original-title="Ingrese el password del correo env&iacute;o" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtCorreoDestino">
                                    Correo Destino<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtCorreoDestino" name="txtCorreoDestino" maxlength="300" data-original-title="Ingrese el correo de destino" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtHost">
                                    Host<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtHost" name="txtHost" maxlength="300" data-original-title="Ingrese el Host de env&iacute;o" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtPuerto">
                                    Puerto de Env&iacute;o<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtPuerto" name="txtPuerto" maxlength="20" data-original-title="Ingrese el puesto de env&iacute;o" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                         <div class="col-md-3">
                            <div class="form-group">
                                <label class="checkbox-inline">
                                    <input type="checkbox" value="true"  id="ckEnableSsl" name="ckEnableSsl">
                                    EnableSsl
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div>
                                <span class="symbol required"></span>Campos Obligatorios
								<hr>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <div class="col-md-6">
                                    <input type="submit" formaction="frmContactoSendMail.aspx" class="btn btn-green btn-block" name="btnGuardar" value="Guardar"/>
                                </div>
                                <div class="col-md-6">
                                    <a href="frmEjemplo.aspx" class="btn btn-red btn-block" name="btnCancelar">Cancelar</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
        <script src="assets/plugins/jQuery/jquery-2.1.1.min.js"></script>
		<script src="assets/js/form-validation2.js"></script>
        <script src="assets/js/ui-notifications.js"></script>
        <script src="assets/plugins/sweetalert/lib/sweet-alert.min.js"></script>
		
		<script>
		    jQuery(document).ready(function () {
		        FormValidator.init(5);
		    });
		</script>
</asp:Content>