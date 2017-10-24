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
    public partial class frmPatrocinadoresGrid : System.Web.UI.Page
    {
        public List<EM_Patrocinadores> Lista = new List<EM_Patrocinadores>();
        protected void Page_Load(object sender, EventArgs e)
        {
            EM_Patrocinadores DatosAux = new EM_Patrocinadores { Conexion = Comun.Conexion, IDUsuario = Comun.IDUsuario };
            EM_PatrocinadoresNegocio FN = new EM_PatrocinadoresNegocio();

            if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
            {
                if (Request.QueryString["id"] != null)
                {
                    string AuxID = Request.QueryString["id"].ToString();
                    DatosAux.IdPatrocinadores= AuxID;
                    FN.EliminarPatrocinador(DatosAux);
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
            Lista = FN.ObtenerPatrocinadores(DatosAux);
        }
    }
}