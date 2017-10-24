<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="frmTestimonioDetalle.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmTestimonioDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
    <div class="row">
        <div class="col-md-12">
        </div>
        <div class="col-sd-12">
            <div class="panel panel-white">
                <div class="panel-heading">
                    <h4 class="panel-title"><span class="text-bold">Testimonio Cliente</span></h4>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <asp:HiddenField ID="hf" runat="server" />                        
                    </div>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label class="control-label" for="cph_MasterBody_txtTitulo">
                                    Nombre Cliente<span class="symbol required"></span>
                                </label>
                                <span class="input-icon">
                                    <input type="text" class="form-control tooltips" runat="server" id="txtTitulo" name="txtTitulo"  data-original-title="Ingrese el primer T&iacute;tulo" data-rel="tooltip" title="" data-placement="top" />
                                    <i class="fa fa-user"></i>
                                </span>
                            </div>
                        </div>
                        <div class="col-sm-12">
                            <div class="form-group">
                                <label class="control-label">
                                    Descripci&oacute;n
                                </label>
                                <textarea name="txtDescripcion" id="txtDescripcion" runat="server" class="ckeditor form-control" cols="10" rows="10" maxlength="1056"></textarea>
                            </div>
                        </div>
                    </div>
                    <div class="row">
							<div class="col-md-6">
								<div class="form-group">									
									<div class="col-md-6">
										<a href="frmTestimonialesGrid.aspx" class="btn btn-red btn-block" name="btnCancelar">Regresar</a>
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
</asp:Content>