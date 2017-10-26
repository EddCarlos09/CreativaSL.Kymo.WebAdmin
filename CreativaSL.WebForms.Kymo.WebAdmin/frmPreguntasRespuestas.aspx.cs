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
    public partial class frmPreguntasRespuestas : System.Web.UI.Page
    {
        public List<JL_Pregunta> Lista = new List<JL_Pregunta>();
        string IDPregunta;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "1")
                {
                    string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Los datos se guardaron correctamente", "Información", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
                else if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        this.IDPregunta = AuxID;
                        JL_Pregunta Datos = new JL_Pregunta { Conexion=Comun.Conexion, IDPregunta=IDPregunta, IDUsuario=Comun.IDUsuario};
                        JL_FAQNegocio FAQN = new JL_FAQNegocio();
                        FAQN.EliminarPreguntaXID(Datos);
                        if (Datos.Completado)
                        {
                            string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Registro eliminado correctamente.", "Información", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                        }
                    }
                }
                this.CargarGrid();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CargarGrid()
        {
            try
            {
                JL_Pregunta Datos = new JL_Pregunta { Conexion = Comun.Conexion };
                JL_FAQNegocio faqN = new JL_FAQNegocio();
                Lista = faqN.ObtenerPreguntas(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}