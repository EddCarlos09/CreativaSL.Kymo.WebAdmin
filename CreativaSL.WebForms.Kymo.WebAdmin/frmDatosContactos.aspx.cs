using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmDatosContactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //CH_Contacto DatosAux = new CH_Contacto { Conexion = Comun.Conexion };
                //CH_ContactoNegocio CN = new CH_ContactoNegocio();
                //CN.ObtenerDatosContacto(DatosAux);
                //if (DatosAux.Completado)
                //{
                //    CargarDatos(DatosAux);
                //}
                //else
                //{
                //    IniciarDatos();
                //}
            }
            else
            {
                //if (Request.Form.Count > 0)
                //{
                //    string Telefonos = Request.Form["ctl00$cph_MasterBody$txtTelefonos"].ToString();
                //    CultureInfo esMX = new CultureInfo("es-MX");
                //    double Latitud = 0, Longitud = 0;
                //    double.TryParse(Request.Form["ctl00$cph_MasterBody$hfLatitud"].ToString().Replace(",", "."), NumberStyles.Currency, esMX, out Latitud);
                //    double.TryParse(Request.Form["ctl00$cph_MasterBody$hfLongitud"].ToString().Replace(",", "."), NumberStyles.Currency, esMX, out Longitud);
                //    string Direccion = Request.Form["ctl00$cph_MasterBody$address"].ToString();
                //    string Correo = Request.Form["ctl00$cph_MasterBody$txtCorreo"].ToString();
                //    string Texto = Request.Form["ctl00$cph_MasterBody$txtTexto"].ToString();
                //    string Titulo = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                //    this.GuardarDatos(Telefonos, Direccion, Correo, Latitud, Longitud, Titulo, Texto);
                //}
            }
        }
    }
}