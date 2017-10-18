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
    public partial class frmNosotrosQuienesSomos : System.Web.UI.Page
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
                                RR_NosotrosQuienesSomos DatosAux = new RR_NosotrosQuienesSomos();
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                NG.ObtenerNosotrosQuienesSomosXID(DatosAux);
                                if (DatosAux.Completado)
                                {
                                   // CargarDatos(Aux);
                                }
                                else
                                {
                                    Response.Redirect("frmNosotrosQuienesSomos.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmNosotrosQuienesSomos.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmNosotrosQuienesSomos.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmNosotrosQuienesSomos.aspx");
                    }
                }
                else
                {
                    //IniciarDatos();
                }                
            }
            else
            {
                
            }
        }
    }
}