<%@ Page Language="C#" MasterPageFile="~/Site.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="frmNosotrosPorqueElegirnos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmNosotrosPorqueElegirnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
    <div class="row">
        <div class="col-md-12">
        </div>
        <div class="col-sd-12">
            <div class="panel panel-white">
                <div class="panel-heading">
                    <h4 class="panel-title"><span class="text-bold">Datos Porque Elegirnos</span></h4>
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
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTitulo">
                                    T&iacute;tulo<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtTitulo" name="txtTitulo" data-original-title="Ingrese el T&iacute;tulo" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-user"></i>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cmbIconos">
                                    Icono <span class="symbol required"></span>
                                </label>
                                <select id="cmbIconos" name="cmbIconos" class="form-control search-select" onchange="cambiarContenido()">
                                   <% foreach (var Item in Lista)
                                           {
                                            Response.Write("<option value='" + Item.IdClassIcono.ToString() + "'>" + Item.CssClass.ToString() + "</option>");
                                           }
                                       %>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTituloImagen">
                                    Vista Previa
                                </label>
                                <span class="input-icon" >                                    
                                    <i id="icono" style="font-size:30px"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-sm-12">
                            <div class="form-group">
                                <label class="control-label">
                                    Descripci&oacute;n
                                </label>
                                <textarea name="txtDescripcion" id="txtDescripcion" runat="server" class="ckeditor form-control" maxlength="100000000"></textarea>
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
                                        <input type="submit" formaction="frmNosotrosPorqueElegirnos.aspx" class="btn btn-green btn-block" name="btnGuardar" value="Guardar" />
                                    </div>
                                    <div class="col-md-6">
                                        <a href="frmNosotrosPorqueElegirnosGrid.aspx" class="btn btn-red btn-block" name="btnCancelar">Cancelar</a>
                                    </div>
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
		        FormValidator.init(3);
		    });
		</script>
        <script>
            function cambiarContenido() {
                var select = $("#cmbIconos option:selected").text();
                $("#cmbIconos").val(select);
                document.getElementById("icono").className = select;
                
            }
        </script>
</asp:Content>