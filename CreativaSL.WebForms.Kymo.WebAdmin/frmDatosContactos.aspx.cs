using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using System.Globalization;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmDatosContactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EM_ContactoGeneral DatosAux = new EM_ContactoGeneral { Conexion = Comun.Conexion };
                EM_ContactoGeneralNegocio CN = new EM_ContactoGeneralNegocio();
                CN.ObtenerDatosContacto(DatosAux);
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
                    string Telefonos = Request.Form["ctl00$cph_MasterBody$txtTelefonos"].ToString();
                    CultureInfo esMX = new CultureInfo("es-MX");
                    double Latitud = 0, Longitud = 0;
                    double.TryParse(Request.Form["ctl00$cph_MasterBody$hfLatitud"].ToString().Replace(",", "."), NumberStyles.Currency, esMX, out Latitud);
                    double.TryParse(Request.Form["ctl00$cph_MasterBody$hfLongitud"].ToString().Replace(",", "."), NumberStyles.Currency, esMX, out Longitud);
                    string Direccion = Request.Form["ctl00$cph_MasterBody$address"].ToString();
                    string Correo = Request.Form["ctl00$cph_MasterBody$txtCorreo"].ToString();
                    //string Texto = Request.Form["ctl00$cph_MasterBody$txtTexto"].ToString();
                    //string Titulo = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    this.GuardarDatos(Telefonos, Direccion, Correo, Latitud, Longitud);
                }
            }
        }

        #region Metodos Genrales
        private void CargarDatos(EM_ContactoGeneral DatosAux)
        {
            try
            {
                string Aux01 = DatosAux.Latitud.ToString().Replace(",", ".");
                string Aux02 = DatosAux.Longitud.ToString().Replace(",", ".");
                string ScriptError =
                @"   jQuery(document).ready(function() {
                        Maps.init(false," + Aux01 + ", " + Aux02 + @");
                            console.log(" + Aux01 + ", " + Aux02 + @")
                        });";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);

                txtCorreo.Value = DatosAux.Correo;
                txtTelefonos.Value = DatosAux.Telefonos;
                address.Value = DatosAux.Direccion;
                //txtTitulo.Value = DatosAux.TituloContacto;
                //txtTexto.Value = DatosAux.TextoContacto;
                hfLatitud.Value = DatosAux.Latitud.ToString();
                hfLongitud.Value = DatosAux.Longitud.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void IniciarDatos()
        {
            try
            {
                hf.Value = string.Empty;
                txtCorreo.Value = string.Empty;
                txtTelefonos.Value = string.Empty;
                //txtTitulo.Value = string.Empty;
                //txtTexto.Value = string.Empty;
                address.Value = string.Empty;
                hfLatitud.Value = string.Empty;
                hfLongitud.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void GuardarDatos(string _Telefonos, string _Direccion, string _Correo, double _Latitud, double _Longitud)
        {
            try
            {
                EM_ContactoGeneral DatosAux = new EM_ContactoGeneral
                {
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario,
                    Telefonos = _Telefonos,
                    Direccion = _Direccion,
                    Correo = _Correo,
                    Latitud = _Latitud,
                    Longitud = _Longitud
                };
                EM_ContactoGeneralNegocio CN = new EM_ContactoGeneralNegocio();
                CN.AC_DatosDeContacto(DatosAux);
                if (DatosAux.Completado)
                {
                    string Aux01 = DatosAux.Latitud.ToString().Replace(",", ".");
                    string Aux02 = DatosAux.Longitud.ToString().Replace(",", ".");
                    string ScriptError =
                    @"   jQuery(document).ready(function() {
                        Maps.init(false," + Aux01 + ", " + Aux02 + @");
                            console.log(" + Aux01 + ", " + Aux02 + @")
                        });";
                    ScriptError += DialogMessage.Show(TipoMensaje.Success, "Datos actualizados.", "Confirmaci&oacute;n", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
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