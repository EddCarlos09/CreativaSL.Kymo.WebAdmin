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
    public partial class frmAvisoPrivacidadAvisosGrid : System.Web.UI.Page
    {
        public List<RR_AvisoPrivacidadDatosGenerales> Lista = new List<RR_AvisoPrivacidadDatosGenerales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_AvisoPrivacidadDatosGenerales Datos = new RR_AvisoPrivacidadDatosGenerales { Conexion = Comun.Conexion, IdAviso = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_AvisoPrivacidadNegocio NN = new RR_AvisoPrivacidadNegocio();
                        NN.EliminarAvisoPrivacidad(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmAvisoPrivacidadAvisosGrid.aspx");
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
                RR_AvisoPrivacidadDatosGenerales Datos = new RR_AvisoPrivacidadDatosGenerales { Conexion = Comun.Conexion };
                RR_AvisoPrivacidadNegocio NN = new RR_AvisoPrivacidadNegocio();
                Lista = NN.ObtenerAvisosPrivacidad(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}