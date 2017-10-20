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
    public partial class frmContactoSendMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EM_ContactoGeneral DatosAux = new EM_ContactoGeneral { Conexion = Comun.Conexion };
                EM_ContactoGeneralNegocio CN = new EM_ContactoGeneralNegocio();
                CN.ObtenerContactoSendMail(DatosAux);
                if (DatosAux.Completado)
                {
                    CargarDatos(DatosAux);
                }
                else
                {
                    IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count > 0)
                {
                    string CorreoEnvio = Request.Form["ctl00$cph_MasterBody$txtCorreoEnvio"].ToString();
                    string Pass = Request.Form["ctl00$cph_MasterBody$txtPassword"].ToString();
                    string CorreoDest = Request.Form["ctl00$cph_MasterBody$txtCorreoDestino"].ToString();
                    string HostTex = Request.Form["ctl00$cph_MasterBody$txtHost"].ToString();
                    int puerto = 0;
                    bool Enable = false;
                    int.TryParse(Request.Form["ctl00$cph_MasterBody$txtPuerto"].ToString(), out puerto);
                    string EnableSL = Request.Form["ckEnableSsl"] != null ? Request.Form["ckEnableSsl"].ToString() : string.Empty;
                    if (bool.TryParse(EnableSL, out Enable) == true)
                    {
                        Enable = true;
                    }
                    this.GuardarDatos(CorreoEnvio, Pass, CorreoDest, HostTex, puerto, Enable);
                }
            }
        }
        #region Metodos Genrales
        /// <summary>
        /// El metodo es el encargado de asignar los valor para dibujar en el HTML
        /// </summary>
        /// <param name="DatosAux">Son los datos que Obtuvieron de la base de datos</param>
        private void CargarDatos(EM_ContactoGeneral DatosAux)
        {
            try
            {
                txtCorreoEnvio.Value = DatosAux.Correo;
                txtPassword.Value = DatosAux.Password;
                txtCorreoDestino.Value = DatosAux.CorreoDestinatario;
                txtHost.Value = DatosAux.HostText;
                txtPuerto.Value = DatosAux.Puerto.ToString();
                string ScriptError =@"
                    $(document).ready(
                        function() {
                        $('#ckEnableSsl').prop('checked', " + DatosAux.EnableSSL.ToString().ToLower() + @");
                }); ";
                    
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                Response.Cookies.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Es el encargo de incializar todo las varibles del html vacio
        /// </summary>
        private void IniciarDatos()
        {
            try
            {
                hf.Value = string.Empty;
                txtCorreoEnvio.Value = string.Empty;
                txtPassword.Value = string.Empty;
                txtCorreoDestino.Value = string.Empty;
                txtHost.Value = string.Empty;
                txtPuerto.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        private void GuardarDatos(string _CorreoEnvio, string _Pass, string _CorreoDest, string _Host, int _Puer, bool _Ena)
        {
            try
            {
                EM_ContactoGeneral DatosAux = new EM_ContactoGeneral
                {
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario,
                    Correo = _CorreoEnvio,
                    Password = _Pass,
                    CorreoDestinatario = _CorreoDest,
                    HostText = _Host,
                    Puerto = _Puer,
                    EnableSSL = _Ena
                };
                EM_ContactoGeneralNegocio CN = new EM_ContactoGeneralNegocio();
                CN.AC_ContactoSendMail(DatosAux);
                if (DatosAux.Completado)
                {
                    string ScriptError = DialogMessage.Show(TipoMensaje.Success, "Datos actualizados.", "Confirmaci&oacute;n", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    //Response.Redirect("frmDatosContacto.aspx", false);
                }
                else
                {
                    string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}