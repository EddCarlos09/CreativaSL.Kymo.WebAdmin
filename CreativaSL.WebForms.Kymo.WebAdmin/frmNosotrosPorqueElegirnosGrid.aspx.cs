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
    public partial class frmNosotrosPorqueElegirnosGrid : System.Web.UI.Page
    {
        public List<RR_NosotrosPorqueElegirnos> Lista = new List<RR_NosotrosPorqueElegirnos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_NosotrosPorqueElegirnos Datos = new RR_NosotrosPorqueElegirnos { Conexion = Comun.Conexion, IdSeccion = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                        NN.BNosotrosPorqueElegirnos(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmNosotrosPorqueElegirnosGrid.aspx");
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
                RR_NosotrosPorqueElegirnos Datos = new RR_NosotrosPorqueElegirnos { Conexion = Comun.Conexion };
                RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                Lista = NN.ObtenerCatalogoNosotrosElegirnos(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}