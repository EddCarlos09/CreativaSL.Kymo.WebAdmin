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
    public partial class frmTestimonialesGrid : System.Web.UI.Page
    {
        public List<RR_Testimoniales> Lista = new List<RR_Testimoniales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["op"] != null && Request.QueryString["op"] == "3")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_Testimoniales Datos = new RR_Testimoniales { Conexion = Comun.Conexion, IdTestimonial = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_TestimonialNegocio NN = new RR_TestimonialNegocio();
                        NN.EliminarTestimonial(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmTestimonialesGrid.aspx");
                        }
                        else
                        {
                            //Mostrar Mensaje de error
                        }
                    }                    
                }
                else if (Request.QueryString["op"] != null && Request.QueryString["op"] == "4")
                {
                    if (Request.QueryString["id"] != null)
                    {
                        string AuxID = Request.QueryString["id"];
                        RR_Testimoniales Datos = new RR_Testimoniales { Conexion = Comun.Conexion, IdTestimonial = AuxID, IDUsuario = Comun.IDUsuario };
                        RR_TestimonialNegocio NN = new RR_TestimonialNegocio();
                        NN.ActivarTestimonial(Datos);
                        if (Datos.Completado)
                        {
                            Response.Redirect("frmTestimonialesGrid.aspx");
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
                RR_Testimoniales Datos = new RR_Testimoniales { Conexion = Comun.Conexion };
                RR_TestimonialNegocio NN = new RR_TestimonialNegocio();
                Lista = NN.ObtenerTestimonial(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}