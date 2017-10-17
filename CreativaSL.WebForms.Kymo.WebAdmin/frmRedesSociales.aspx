﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRedesSociales.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmRedesSociales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
	 <div class="row">
		<div class="col-md-12">
		</div>
		<div class="col-sd-12">
			<div class="panel panel-white">
				<div class="panel-heading">
					<h4 class="panel-title"><span class="text-bold">Datos Redes Sociales</span></h4>
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
                                <label for="cph_MasterBody_redesSociales">
                                    Redes Sociales
                                </label>
                                <select id="cph_MasterBody_cmbRedes" class="form-control search-select">
                                    <option value="">&nbsp;</option>
                                    <option value="fb">Facebook</option>
                                    <option value="ins">Instagram</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTituloImagen">
                                    Nick Name(Perfil Red Social)<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtNickName" name="txtNickName" maxlength="200" data-original-title="Ingrese el nombre del perfil" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-user"></i>
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
						<div class="col-md-6"></div>
						<div class="col-md-6">
							<div class="form-group">
								<div class="col-md-6">
									<input type="submit" formaction="frmRedesSociales.aspx" class="btn btn-green btn-block" name="btnGuardar" value="Guardar"/>
								</div>
								<div class="col-md-6">
									<a href="frmRedesSocialesGrid.aspx" class="btn btn-red btn-block" name="btnCancelar">Cancelar</a>
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
		<script src="assets/js/main.js"></script>
		<script>
			jQuery(document).ready(function () {
				FormValidator.init(2);
			});
		</script>
</asp:Content>