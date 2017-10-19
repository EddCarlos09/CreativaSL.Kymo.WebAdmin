using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{    
    public partial class frmNosotrosPorqueElegirnos : System.Web.UI.Page
    {
        public List<RR_Iconos> Lista = new List<RR_Iconos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            if (!IsPostBack)
            {
                if (Request.QueryString["op"] != null)
                {
                    if (Request.QueryString["op"] == "2")
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            string ID = Request.QueryString["id"].ToString() != null ? Request.QueryString["id"].ToString() : string.Empty;
                            if (Request.QueryString["id"].ToString() == ID)
                            {
                                RR_NosotrosPorqueElegirnos Datos = new RR_NosotrosPorqueElegirnos { Conexion = Comun.Conexion, IdSeccion = ID };
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                NG.ObtenerNosotrosElegirnosXID(Datos);
                                if (Datos.Completado)
                                {
                                    CargarDatos(Datos);
                                }
                                else
                                {
                                    Response.Redirect("frmNosotrosPorqueElegirnos.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmNosotrosPorqueElegirnos.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmNosotrosPorqueElegirnos.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmNosotrosPorqueElegirnos.aspx");
                    }
                }
                else
                {
                    IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count == 8)
                {
                    string titulo = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    string textoHtml = HttpUtility.HtmlDecode(txtDescripcion.InnerHtml);                    
                    string icono = Request.Form["cmbIconos"].ToString();
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxID);
                        Guardar(NuevoRegistro, AuxID, titulo, textoHtml, icono);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                else
                {

                }
            }
        }

        public void Guardar(bool _nuuevoRegistro, string _idSeccion, string _titulo, string _descripcion, string _icono)
        {
            RR_NosotrosPorqueElegirnos DatosAux = new RR_NosotrosPorqueElegirnos
            {
                NuevoRegistro = _nuuevoRegistro,
                IdSeccion = _idSeccion,
                Titulo = _titulo,
                Texto = _descripcion,
                IdClaseIcono = _icono,
                Conexion = Comun.Conexion,
                IDUsuario = User.Identity.Name
            };

            RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
            NG.ACNosotrosPorqueElegirnos(DatosAux);
            if (DatosAux.Completado)
            {
                Response.Redirect("frmNosotrosPorqueElegirnosGrid.aspx");
            }
            else
            {
                string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
            }
        }

        public void CargarDatos(RR_NosotrosPorqueElegirnos Datos)
        {
            txtTitulo.Value = Datos.Titulo;
            txtDescripcion.Value = Datos.Texto;
            string ScriptError = @"
                    $(document).ready(
                        function() {                        
                        document.getElementById('cmbIconos').value=" + Datos.IdClaseIcono.ToString() + @";
                    });";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
        }

        private void CargarComboBox()
        {
            RR_Iconos Iconos = new RR_Iconos { Conexion = Comun.Conexion };
            RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
            Lista = NG.ObtenerIconos(Iconos);
        }

        private void IniciarDatos()
        {
            hf.Value             = string.Empty;
            txtTitulo.Value      = string.Empty;
            txtDescripcion.Value = string.Empty;
        }
    }
}