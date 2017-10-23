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
    public partial class frmAvisoPrivacidadAvisos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                                RR_AvisoPrivacidadDatosGenerales DatosAux = new RR_AvisoPrivacidadDatosGenerales {Conexion = Comun.Conexion, IdAviso = ID, IDUsuario = Comun.IDUsuario};
                                RR_AvisoPrivacidadNegocio APN = new RR_AvisoPrivacidadNegocio();
                                APN.ObtenerAvisoPrivacidadXID(DatosAux);
                                if (DatosAux.Completado)
                                {
                                    CargarDatos(DatosAux);
                                }
                                else
                                {
                                    Response.Redirect("frmAvisoPrivacidadAvisos.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmAvisoPrivacidadAvisos.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmAvisoPrivacidadAvisos.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmAvisoPrivacidadAvisos.aspx");
                    }
                }
                else
                {
                    IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count == 7)
                {
                    string titulo = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    string texto = HttpUtility.HtmlDecode(txtDescripcion.InnerHtml);
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxID);
                        Guardar(NuevoRegistro, AuxID, titulo, texto);
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

        public void Guardar(bool _nuuevoRegistro, string _idAviso, string _titulo, string _texto)
        {
            RR_AvisoPrivacidadDatosGenerales DatosAux = new RR_AvisoPrivacidadDatosGenerales
            {
                NuevoRegistro = _nuuevoRegistro,
                IdAviso = _idAviso,
                TituloAviso = _titulo,
                TextoAviso = _texto,                
                Conexion = Comun.Conexion,
                IDUsuario = User.Identity.Name
            };

            RR_AvisoPrivacidadNegocio NG = new RR_AvisoPrivacidadNegocio();
            NG.ACAvisoPrivacidad(DatosAux);
            if (DatosAux.Completado)
            {
                Response.Redirect("frmAvisoPrivacidadAvisosGrid.aspx");
            }
            else
            {
                string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
            }
        }

        public void CargarDatos(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            hf.Value = Datos.IdAviso;
            txtTitulo.Value = Datos.TituloAviso;
            txtDescripcion.Value = Datos.TextoAviso;            
        }      

        private void IniciarDatos()
        {
            hf.Value = string.Empty;
            txtTitulo.Value = string.Empty;
            txtDescripcion.Value = string.Empty;
        }
    }
}