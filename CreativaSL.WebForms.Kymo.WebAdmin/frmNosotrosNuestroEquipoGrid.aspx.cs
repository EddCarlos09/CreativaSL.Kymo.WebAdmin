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
    public partial class frmNosotrosNuestroEquipoGrid : System.Web.UI.Page
    {
        public List<RR_NosotrosEquipoTrabajo> Lista = new List<RR_NosotrosEquipoTrabajo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_NosotrosEquipoTrabajo Datos = new RR_NosotrosEquipoTrabajo { Conexion = Comun.Conexion, IdMiembroEquipo = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                        NN.EliminarNosotrosEquipoTrabajo(Datos);
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

        /// <summary>
        /// Metodo para obtener la lista de los registros en la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        public void CargarGrid()
        {
            try
            {
                RR_NosotrosEquipoTrabajo Datos = new RR_NosotrosEquipoTrabajo { Conexion = Comun.Conexion };
                RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                Lista = NN.ObtenerCatalogoNosotrosEquipoTrabajo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}