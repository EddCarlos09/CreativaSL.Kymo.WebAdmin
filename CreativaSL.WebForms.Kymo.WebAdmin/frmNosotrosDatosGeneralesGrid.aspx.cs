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
    public partial class frmNosotrosDatosGeneralesGrid : System.Web.UI.Page
    {
        public List<RR_NosotrosDatosGenerales> Lista = new List<RR_NosotrosDatosGenerales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_NosotrosDatosGenerales Datos = new RR_NosotrosDatosGenerales { Conexion = Comun.Conexion, IdTexto = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_NosotrosNegocio NN = new RR_NosotrosNegocio();
                        NN.EliminarNosotrosDatosGenerales(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmNosotrosDatosGeneralesGrid.aspx");
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
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}