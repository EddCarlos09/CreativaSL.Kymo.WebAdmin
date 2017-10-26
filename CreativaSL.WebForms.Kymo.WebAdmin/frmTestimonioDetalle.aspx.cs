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
    public partial class frmTestimonioDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                                RR_Testimoniales DatosAux = new RR_Testimoniales { Conexion = Comun.Conexion, IdTestimonial = ID, IDUsuario = Comun.IDUsuario };
                                RR_TestimonialNegocio APN = new RR_TestimonialNegocio();
                                APN.ObtenerTestimonialXId(DatosAux);
                                if (DatosAux.Completado)
                                {
                                    CargarDatos(DatosAux);
                                }
                                else
                                {
                                    Response.Redirect("frmTestimonioDetalle.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmTestimonioDetalle.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmTestimonioDetalle.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmTestimonioDetalle.aspx");
                    }
                }
                else
                {
                    Response.Redirect("frmTestimonioDetalle.aspx?error=" + "Error al cargar los datos&nError=1");
                }
            }
        }

        public void CargarDatos(RR_Testimoniales Datos)
        {
            hf.Value = Datos.IdTestimonial;
            txtTitulo.Value = Datos.NombreCompleto;
            txtDescripcion.Value = Datos.Comentario;
        }
    }
}