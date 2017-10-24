<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="frmTestimonialesGrid.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.WebAdmin.frmTestimonialesGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_MasterBody" runat="server">
	<div class="row">
		<div class="col-md-12">
			<!-- start: DYNAMIC TABLE PANEL -->
			<div class="panel panel-white">
				<div class="panel-heading">
					<h4 class="panel-title">Catálogo <span class="text-bold">Nosotros Datos Generales</span></h4>
				</div>
				<div class="panel-body">
					<div class="row">
						<div class="col-md-12 space20">
							<a href="frmTestimonialesGrid.aspx" class="btn btn-green">
								Nuevo
								<i class="fa fa-plus"></i>
							</a>
						</div>
					</div>
					<div class="table-responsive">
						<table class="table table-striped table-bordered table-hover table-full-width" id="sample_1">
							<thead>
								<tr>
									<th>Testimoniales</th>                                    
									<th>Acciones</th>
								</tr>
							</thead>
							<tbody>                  
								<% foreach (var Item in Lista)
									{ %>
								<tr>
									<td><%=Item.NombreCompleto %></td>									
									<td>
										<div class="visible-md visible-lg hidden-sm hidden-xs">
											<%Response.Write("<a href='frmTestimonialesGrid.aspx?op=2&id=" + Item.IdTestimonial.ToString() + "' class='btn btn-xs btn-blue tooltips' data-placement='top' data-original-title='Leer Comentario'> <i class='fa fa-eye'> </i> </a>"); %>
                                            <%Response.Write("<a data-placement='top' data-target='.bs-example-modal-sm1" + Item.IdTestimonial.ToString() + "' data-toggle='modal'  class='btn btn-xs btn-yellow tooltips' data-placement='top' data-original-title='Mostrar en Pagina'> <i class='fa fa-check fa fa-check'> </i> </a>");%>
											<%Response.Write("<a data-placement='top' data-target='.bs-example-modal-sm" + Item.IdTestimonial.ToString() + "' data-toggle='modal'  class='btn btn-xs btn-red tooltips' data-placement='top' data-original-title='Eliminar'> <i class='fa fa-times fa fa-white'> </i> </a>");%>                                            
										</div>

										<div class="visible-xs visible-sm hidden-md hidden-lg">
											<div class="btn-group">
												<a class="btn btn-green dropdown-toggle btn-sm" data-toggle="dropdown" href="#">
													<i class="fa fa-cog"></i> <span class="caret"></span>
												</a>
												<ul role="menu" class="dropdown-menu pull-right dropdown-dark">
													<li>
														<%Response.Write("<a href='frmTestimonialesGrid.aspx?op=2&id=" + Item.IdTestimonial.ToString() + "' role='menuitem' tabindex='-1' class='tooltips' data-placement='top' data-original-title='Editar'><i class='fa fa-eye'></i>Editar</a>"); %>
													</li>
													<li>
														<%Response.Write("<a data-placement='top' data-target='.bs-example-modal-sm" + Item.IdTestimonial.ToString() + "' role='menuitem' tabindex='-1' data-toggle='modal'  class='tooltips' data-placement='top' data-original-title='Eliminar'><i class='fa fa-check fa fa-check'></i>Eliminar</a>");%>
													</li>
                                                    <li>
														<%Response.Write("<a data-placement='top' data-target='.bs-example-modal-sm1" + Item.IdTestimonial.ToString() + "' role='menuitem' tabindex='-1' data-toggle='modal'  class='tooltips' data-placement='top' data-original-title='Mostrar en Pagina'><i class='fa fa-eye fa fa-white'></i>Mostrar en Pagina</a>");%>
													</li>                                                    
												</ul>
											</div>
										</div>
										<div class="modal fade bs-example-modal-sm<% = Item.IdTestimonial.ToString() %>" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
										<div class="modal-dialog modal-sm">
											<div class="modal-content">
												<div class="modal-header">
													<button aria-hidden="true" data-dismiss="modal" class="close" type="button">
														×
													</button>
													<h4 id="mySmallModalLabel" class="modal-title">Confirmación</h4>
												</div>
												<div class="modal-body">
													<p>
														¿Está seguro de eliminar el registro seleccionado?
													</p>
												</div>
												<div class="modal-footer">                     
													<button data-dismiss="modal" class="btn btn-red" type="button">No</button>
													<% Response.Write("<a  href='frmTestimonialesGrid.aspx?op=3&id=" + Item.IdTestimonial.ToString() + "' class='btn btn-green add-row' runat='server'>Si</a>");%>                                                    
												</div> 
											</div>
										</div>
									  </div>
                                        
                                        <div class="modal fade bs-example-modal-sm1<% = Item.IdTestimonial.ToString() %>" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel1" aria-hidden="true">
										<div class="modal-dialog modal-sm">
											<div class="modal-content">
												<div class="modal-header">
													<button aria-hidden="true" data-dismiss="modal" class="close" type="button">
														×
													</button>
													<h4 id="mySmallModalLabel1" class="modal-title">Confirmación</h4>
												</div>
												<div class="modal-body">
													<p>
														¿Está seguro de agregar el registro seleccionado?
													</p>
												</div>
												<div class="modal-footer">                     
													<button data-dismiss="modal" class="btn btn-red" type="button">No</button>
													<% Response.Write("<a  href='frmTestimonialesGrid.aspx?op=4&id=" + Item.IdTestimonial.ToString() + "' class='btn btn-green add-row' runat='server'>Si</a>");%>                                                    
												</div> 
											</div>
										</div>
									  </div>
                                        
                                                                               
									</td>
								</tr>
								<% } %>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>
	</div>
	
	<!-- start: MAIN JAVASCRIPTS -->
		<script src="assets/plugins/jQuery/jquery-2.1.1.min.js"></script>
	<!-- end: MAIN JAVASCRIPTS -->
	<!-- start: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
	<script type="text/javascript" src="assets/plugins/select2/select2.min.js"></script>
	<script type="text/javascript" src="assets/js/table-data.js"></script>
	<!-- end: JAVASCRIPTS REQUIRED FOR THIS PAGE ONLY -->
	<!-- start: CORE JAVASCRIPTS  -->
	<script src="assets/js/main.js"></script>
	<!-- end: CORE JAVASCRIPTS  -->
	<script>
		jQuery(document).ready(function () {
			TableData.init();
		});
	</script>
    </asp:Content>