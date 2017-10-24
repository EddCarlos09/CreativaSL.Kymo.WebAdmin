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
    public partial class frmNosotrosRedesSocialesGrid : System.Web.UI.Page
    {
        public string ID = string.Empty;
        public List<RR_RedesSociales> Lista = new List<RR_RedesSociales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_RedesSociales Datos = new RR_RedesSociales { Conexion = Comun.Conexion, IdMiembroxRedSocial = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                        NN.BNosotrosRedesSociales(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmNosotrosNuestroEquipoGrid.aspx");
                        }
                        else
                        {
                            //Mostrar Mensaje de error
                        }
                    }
                }
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "5")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_RedesSociales Datos = new RR_RedesSociales { Conexion = Comun.Conexion, IdMiembroxRedSocial = AuxID };
                        CargarGrid(Datos);
                    }
                }
                    if (!IsPostBack)
                {
                    ID = Request.QueryString["id"];
                }
                else
                {
                }                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CargarGrid(RR_RedesSociales Datos)
        {
            try
            {                
                RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                Lista = NN.ObtenerNosotrosRedesSociales(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}