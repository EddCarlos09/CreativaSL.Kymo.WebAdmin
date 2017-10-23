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
    public partial class frmTerminosCondicionesGrid : System.Web.UI.Page
    {
        public List<RR_TerminosCondiciones> Lista = new List<RR_TerminosCondiciones>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_TerminosCondiciones Datos = new RR_TerminosCondiciones { Conexion = Comun.Conexion, IdTermino = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_TerminosCondicionesNegocio NN = new RR_TerminosCondicionesNegocio();
                        NN.EliminarTerminosCondiciones(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmTerminosCondicionesGrid.aspx");
                        }
                        else
                        {
                            //Mostrar Mensaje de error
                        }
                    }
                }
                if (!IsPostBack)
                {

                }
                else
                {
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
                RR_TerminosCondiciones Datos = new RR_TerminosCondiciones { Conexion = Comun.Conexion };
                RR_TerminosCondicionesNegocio NN = new RR_TerminosCondicionesNegocio();
                Lista = NN.ObtenerTerminosCondiciones(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}