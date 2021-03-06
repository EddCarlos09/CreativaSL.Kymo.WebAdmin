﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNosotrosDatosGenerales.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmNosotrosDatosGenerales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
    <div class="row">
        <div class="col-md-12">
        </div>
        <div class="col-sd-12">
            <div class="panel panel-white">
                <div class="panel-heading">
                    <h4 class="panel-title"><span class="text-bold">Nosotros "Datos Generales"</span></h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <asp:HiddenField ID="hf" runat="server" />
                        <asp:HiddenField ID="hfImg" runat="server" />
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
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTitulo">
                                    T&iacute;tulo<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtTitulo" name="txtTitulo" maxlength="200" data-original-title="Ingrese el T&iacute;tulo" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-user"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <label class="control-label">
                                Foto <span class="symbol required"></span>
                            </label>
                            <div class="fileupload fileupload-new" data-provides="fileupload">
                                <div class="fileupload-new thumbnail">
                                    <img src="assets/images/NoImage.png" alt="" id="Logo" runat="server" />
                                </div>
                                <div class="fileupload-preview fileupload-exists thumbnail"></div>
                                <div>
                                    <span class="btn btn-light-grey btn-file"><span class="fileupload-new"><i class="fa fa-picture-o"></i>Seleccione una imagen</span><span class="fileupload-exists"><i class="fa fa-picture-o"></i> Cambiar</span>
                                        <asp:FileUpload CssClass="fileupload" name="imgImagen" ID="imgImagen" runat="server" />
                                    </span>
                                    <a href="#" class="btn fileupload-exists btn-light-grey" data-dismiss="fileupload">
                                        <i class="fa fa-times"></i>Quitar
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTextoAlternativo">
                                    Texto Alternativo<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtTextoAlternativo" name="txtTextoAlternativo" maxlength="200" data-original-title="Ingrese el texto alternativo" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTituloImagen">
                                    T&iacute;tulo Imagen<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtTituloImagen" name="txtTituloImagen" maxlength="200" data-original-title="Ingrese el t&iacute;tulo de la imagen" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTituloImagen">
                                    T&iacute;tulo Secci&oacute;n 2<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtSeccion2" name="txtSeccion2" maxlength="200" data-original-title="Ingrese el t&iacute;tulo de la secci&oacute;n 2" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTituloImagen">
                                    T&iacute;tulo Secci&oacute;n 3<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtSeccion3" name="txtSeccion3" maxlength="200" data-original-title="Ingrese el t&iacute;tulo de la secci&oacute;n 3" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-circle"></i>
                                </span>
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
                            <div class="col-md-6">
                                <div class="form-group">
                                    <div class="col-md-6">
                                        <input type="submit" formaction="frmNosotrosDatosGenerales.aspx" class="btn btn-green btn-block" name="btnGuardar" value="Guardar" />
                                    </div>
                                    <div class="col-md-6">
                                        <a href="frmNosotrosDatosGeneralesGrid.aspx" class="btn btn-red btn-block" name="btnCancelar">Cancelar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    
                </div>
            </div>
        </div>
    </div>
        <script src="assets/plugins/jQuery/jquery-2.1.1.min.js"></script>
		<script src="assets/js/form-validation.js"></script>
        <script src="assets/js/ui-notifications.js"></script>
        <script src="assets/plugins/sweetalert/lib/sweet-alert.min.js"></script>
        <script src="assets/plugins/ckeditor/ckeditor.js"></script>
		<script src="assets/plugins/ckeditor/adapters/jquery.js"></script>
		<script src="assets/js/main.js"></script>
		<script>
		    jQuery(document).ready(function () {
		        FormValidator.init(4);
		    });
		</script>
</asp:Content>