﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDatosContactos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmDatosContactos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
     <div class="row">
		<div class="col-sm-12">
		    <div class="panel panel-white">
				<div class="panel-heading">
					<h4 class="panel-title"><span class="text-bold">Datos de contacto</span></h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <asp:HiddenField ID="hf" runat="server" />
                    </div> 

                    <div class="row">
                        <div class="col-md-12">
						    <div class="errorHandler alert alert-danger no-display">
							    <i class="fa fa-times-sign"></i> Hay errores en la captura de información. Revise las especificaciones de los campos.
						    </div>
                            <div class="successHandler alert alert-success no-display">
                                <i class="fa fa-ok"></i>Your form validation is successful!
                            </div>
					    </div>
                    </div>

                    
                    <div class="row">
						<div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_address">
							        Ingrese la direcci&oacute;n de contacto y presione Buscar. Posteriormente, seleccione un punto en el mapa.<span class="symbol required"></span>
						        </label>
							    <div class="input-group">
								    <input type="text" class="form-control dir" runat="server" placeholder="" id="address" name="address" data-original-title="Ingrese la dirección del contacto" data-rel="tooltip"  title="" data-placement="top">                                    
                                    <input type="hidden" name="hfLatitud" id="hfLatitud" runat="server">
                                    <input type="hidden" name="hfLongitud" id="hfLongitud" runat="server">
								    <span class="input-group-btn" style="vertical-align:top;">
									    <button id="btnSearchDir" class="btn btn-bricky" type="button">
										    Buscar
									    </button> 
								    </span>
							    </div>
						    </div>
                            <div class="map" id="map1">
							</div>
						</div>
					</div>
                    <br />
                    <div class="row">            
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTelefonos">
							        Tel&eacute;fono(s) <span class="symbol required"></span>
						        </label>
						        <span class="input-icon">
                                    <input type="text" class="form-control" runat="server" id="txtTelefonos" name="txtTelefonos" placeholder="" maxlength="30"/>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="row">            
                        <div class="col-md-12">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtCorreo">
                                    Correo <span class="symbol required"></span>
						        </label>
						        <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtCorreo" name="txtCorreo" placeholder="" maxlength="600" data-original-title="Ingrese el correo de contacto" data-rel="tooltip"  title="" data-placement="top" />
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
					    <div class="col-md-12">
						    <div>
							    <span class="symbol required"></span> Campos Requeridos
							    <hr>
						    </div>
					    </div>
				    </div>

                    <div class="row ">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <div class="form-group">
				                <div class="col-md-6">
                                    <input type="submit" formaction="frmDatosContactos.aspx" class="btn btn-green btn-block" name ="btnGuardar" value="Guardar" />
                                </div>
                                <div class="col-md-6">
                                    <a href="frmEjemplo.aspx" class ="btn btn-red btn-block" name ="btnCancelar" >Regresar</a>
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
        <script src="assets/js/mapsContacto.js"></script>
        <script>
			jQuery(document).ready(function() {
			    FormValidator.init(3);
			    if ((document.getElementById("cph_MasterBody_hfLongitud").value === ''))
			        Maps.init(true, 0, 0);
			});
		</script>
</asp:Content>