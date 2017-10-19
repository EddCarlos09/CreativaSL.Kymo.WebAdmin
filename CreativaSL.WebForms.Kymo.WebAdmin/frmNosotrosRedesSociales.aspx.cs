using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmNosotrosRedesSociales : System.Web.UI.Page
    {
        public List<RR_RedesSociales> Lista = new List<RR_RedesSociales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarRedesSociales();
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

                            }
                            else
                            {
                                Response.Redirect("frmNosotrosNuestroEquipo.aspx?error=" + "Error al cargar los datos&nError=1");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                    }
                }
                else
                {
                    Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                }
            }
            else
            {
                //IniciarDatos();
            }
        }

        public List<RR_RedesSociales> CargarRedesSociales()
        {
            try
            {
                RR_RedesSociales DatosAux = new RR_RedesSociales { Conexion = Comun.Conexion};
                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                return Lista =  NG.ObtenerRedesSoc(DatosAux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}