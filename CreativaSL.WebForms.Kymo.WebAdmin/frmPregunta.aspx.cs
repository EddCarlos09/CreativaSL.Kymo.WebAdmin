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
    public partial class frmPregunta : System.Web.UI.Page
    {
        public string IDPregunta;
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
                            string ID = "";
                            ID = Request.QueryString["id"];
                            if (ID != string.Empty)
                            {
                                //Obtener los datos y dibujarlos.
                                JL_Pregunta DatosAux = new JL_Pregunta { Conexion = Comun.Conexion, IDPregunta = ID };
                                JL_FAQNegocio FAQN = new JL_FAQNegocio();
                                FAQN.ObtenerPreguntasXID(DatosAux);
                                if (DatosAux.Completado)
                                {
                                    this.CargarDatos(DatosAux);
                                }
                                else
                                {
                                    //Ocurrió un error
                                    Response.Redirect("frmPreguntasRespuestas.aspx?errorMessage=" + DatosAux.Completado);
                                }
                            }
                            else
                            {
                                Response.Redirect("frmPreguntasRespuestas.aspx?errorMessage=1");
                            }
                        }
                        else
                            Response.Redirect("frmPreguntasRespuestas.aspx?errorMessage=2");
                    }
                    else
                        Response.Redirect("frmPreguntasRespuestas.aspx?errorMessage=3");
                }
            }
            else
            {
                if (Request.Form.Count == 9)
                {
                    string IDPregunta = "";
                    int Orden = 0;
                    string Pregunta = Request.Form["ctl00$cph_MasterBody$txtPregunta"].ToString();
                    string Respuesta = Request.Form["ctl00$cph_MasterBody$txtRespuesta"].ToString();
                    int.TryParse(Request.Form["ctl00$cph_MasterBody$txtOrden"].ToString(), out Orden);
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        IDPregunta = AuxID;
                        bool NuevoRegistro = string.IsNullOrEmpty(IDPregunta);
                        this.Guardar(NuevoRegistro, IDPregunta,Pregunta,Respuesta,Orden);

                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message);
                    }
                }
            }
        }
        private void CargarDatos(JL_Pregunta DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IDPregunta.ToString();
                txtPregunta.Value = DatosAux.Pregunta.ToString();
                txtRespuesta.Value = DatosAux.Respuesta.ToString();
                txtOrden.Value = DatosAux.Orden.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void Guardar(bool NuevoRegistro, string IDPregunta, string Pregunta, string Respuesta, int Orden)
        {
            try
            {
                JL_Pregunta Datos = new JL_Pregunta
                {
                    NuevoRegistro = NuevoRegistro,
                    IDPregunta = IDPregunta,
                    Pregunta = Pregunta,
                    Respuesta = Respuesta,
                    Orden = Orden,
                    Conexion = Comun.Conexion,
                    IDUsuario = User.Identity.Name
                    
                };
                JL_FAQNegocio FAQN = new JL_FAQNegocio();
                FAQN.ACPreguntas(Datos);
                if (Datos.Completado)
                {
                    this.IDPregunta = Datos.IDPregunta.ToString();
                    hf.Value= Datos.IDPregunta.ToString();
                    Response.Redirect("frmPreguntasRespuestas.aspx?op=1",false);
                }
                else if (Datos.Resultado == 2)
                {
                    this.IDPregunta = Datos.IDPregunta.ToString();
                    hf.Value = Datos.IDPregunta.ToString();
                    string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Verifique número de orden ya exite para esta pregunta.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}