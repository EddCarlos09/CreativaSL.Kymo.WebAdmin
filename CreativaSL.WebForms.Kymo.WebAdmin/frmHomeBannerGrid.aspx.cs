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
    public partial class frmHomeBannerGrid : System.Web.UI.Page
    {
        public List<EM_HomeBanner>Lista = new List<EM_HomeBanner>();
        protected void Page_Load(object sender, EventArgs e)
        {
            EM_HomeBanner DatosAux = new EM_HomeBanner { Conexion = Comun.Conexion, IDUsuario = Comun.IDUsuario };
            EM_HomeBannerNegocio FN = new EM_HomeBannerNegocio();

            if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
            {
                if (Request.QueryString["id"] != null)
                {
                    string AuxID = Request.QueryString["id"].ToString();
                    DatosAux.IdBanner = AuxID;
                    FN.EliminarBannerHome(DatosAux);
                    if (DatosAux.Completado)
                    {
                        string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Registro eliminado correctamente.", "Información", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    }
                    else
                    {
                        string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al eliminar el registro.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    }
                }
            }
            Lista = FN.ObtenerListaBanner(DatosAux);
            if (Request.QueryString["errorMessage"] != null)
            {
                string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al cargar los datos. Intenté nuevamente", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
            }
        }
    }
}