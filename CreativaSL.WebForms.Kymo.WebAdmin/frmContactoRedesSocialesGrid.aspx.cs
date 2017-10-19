using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmContactoRedesSocialesGrid : System.Web.UI.Page
    {
        public List<EM_ContactoRedesSociales> _ListaRedesSocial = new List<EM_ContactoRedesSociales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string IdAux = Request.QueryString["id"].ToString();
                        EM_ContactoRedesSociales Datos = new EM_ContactoRedesSociales { Conexion = Comun.Conexion, IdRedSocial = IdAux, IDUsuario = Comun.IDUsuario };
                        EM_ContactoRedesSocialesNegocio CN = new EM_ContactoRedesSocialesNegocio();
                        CN.EliminarContactoRedesSocialesXID(Datos);
                        if (Datos.Completado)
                        {
                            //Mostrar mensaje Success
                            string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Registro eliminado correctamente.", "Información", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                        }
                        else
                        {
                            //Mostrar Mensaje de error
                            string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                        }
                    }
                }
                if (!IsPostBack)
                {

                }
                else
                {
                }

                this.CargarGridContactoRedesSociales();

                if (Request.QueryString["errorMessage"] != null)
                {
                    string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al cargar los datos. Intenté nuevamente", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
            }
            catch (Exception ex)
            {
                Response.Redirect("PageError.aspx?errorNumber=" + ex.HResult);
            }
        }

        public void CargarGridContactoRedesSociales()
        {
            try
            {
                EM_ContactoRedesSociales Datos = new EM_ContactoRedesSociales { Conexion = Comun.Conexion };
                EM_ContactoRedesSocialesNegocio CN = new EM_ContactoRedesSocialesNegocio();
                _ListaRedesSocial = CN.ObtenerContactoRedesSociales(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}