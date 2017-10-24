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
    public partial class frmNosotrosQuienesSomosGrid : System.Web.UI.Page
    {
        public List<RR_NosotrosQuienesSomos> Lista = new List<RR_NosotrosQuienesSomos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_NosotrosQuienesSomos Datos = new RR_NosotrosQuienesSomos { Conexion = Comun.Conexion, IdSeccion = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                        NN.EliminarNosotrosQuienesSomos(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmNosotrosQuienesSomosGrid.aspx");
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
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para obtener la lista de los registros en la tabla "Nosotros Quienes Somos"
        /// </summary>
        public void CargarGrid()
        {
            try
            {
                RR_NosotrosQuienesSomos Datos = new RR_NosotrosQuienesSomos { Conexion = Comun.Conexion };
                RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                Lista = NN.ObtenerCatalogoNosotrosQuienesSomos(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}