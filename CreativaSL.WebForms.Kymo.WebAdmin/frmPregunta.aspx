<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmPregunta.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmPregunta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-white">
                <div class="panel-heading">
                    <h4 class="panel-title"><i class="fa fa-edit"></i><span class="text-bold">Captura de pregunta</span></h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <asp:HiddenField ID="hf" runat="server" />
                        <asp:HiddenField ID="hf2" runat="server" />
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="errorHandler alert alert-danger no-display">
                                <i class="fa fa-times-sign"></i>Hay errores en la captura de información. Revise las especificaciones de los campos.
                            </div>
                            <div class="successHandler alert alert-success no-display">
                                <i class="fa fa-ok"></i>La información se guardó correctamente
                            </div>
                        </div>
                        <div class="rows">
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label" for="cph_MasterBody_txtPregunta">
                                        Pregunta <span class="symbol required"></span>
                                    </label>
                                    <span class="input-icon">

                                        <input type="text" class="form-control tooltips" runat="server" id="txtPregunta" name="txtPregunta" data-original-title="Ingrese la Pregunta" data-rel="tooltip" title="" data-placement="top" />

                                    </span>
                                </div>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group">
                                    <label class="control-label" for="cph_MasterBody_txtPregunta">
                                        Respuesta <span class="symbol required"></span>
                                    </label>
                                    <span class="input-icon">

                                        <input type="text" class="form-control tooltips" runat="server" id="txtRespuesta" name="txtRespuesta" maxlength="150" data-original-title="Ingrese la Pregunta" data-rel="tooltip" title="" data-placement="top" />

                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="rows">
                            <div class="col-md-2">
                                <div class="form-group">
                                    <label class="control-label" for="cph_MasterBody_txtOrden">
                                        Orden de Pregunta <span class="symbol required"></span>
                                    </label>
                                    <span class="input-icon">
                                        <input type="number" class="form-control tooltips" runat="server" id="txtOrden" name="txtOrden" placeholder="" minlength="1" data-original-title="Ingrese el orden de respuesta" data-rel="tooltip" title="" data-placement="top" />
                                        <i class="fa fa-keyboard-o"></i>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="col-md-6">
                                <input type="submit" formaction="frmPregunta.aspx" class="btn btn-green btn-block" name="btnGuardar" value="Guardar" />
                            </div>
                            <div class="col-md-6">
                                <a href="frmPreguntasRespuestas.aspx" class='btn btn-red btn-block' name='btnCancelar'> Cancelar</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- start: MAIN JAVASCRIPTS -->
    <!--[if lt IE 9]>
        <script src="assets/plugins/respond.min.js"></script>
        <script src="assets/plugins/excanvas.min.js"></script>
        <script type="text/javascript" src="assets/plugins/jQuery/jquery-1.11.1.min.js"></script>
    <![endif]-->
    <!--[if gte IE 9]><!-->
    <script src="assets/plugins/jQuery/jquery-2.1.1.min.js"></script>
    <!--<![endif]-->
    <!-- start: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
    <script src="assets/js/form-validation3.js"></script>
    <script src="assets/js/ui-notifications.js"></script>
    <script src="assets/plugins/sweetalert/lib/sweet-alert.min.js"></script>
    <!-- end: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
    <!-- start: CORE JAVASCRIPTS  -->
    <script src="assets/js/main.js"></script>
    <!-- end: CORE JAVASCRIPTS  -->
    <script>
        jQuery(document).ready(function () {
            FormValidator.init(1);
        });
    </script>
</asp:Content>

