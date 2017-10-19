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
    public partial class frmNosotrosNuestroEquipo : System.Web.UI.Page
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
                                //RR_NosotrosEquipoTrabajo DatosAux = new RR_NosotrosEquipoTrabajo { Conexion = Comun.Conexion, IdSeccion = ID};
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                //NG.ObtenerNosotrosQuienesSomosXID(DatosAux);
                                //if (DatosAux.Completado)
                                //{
                                //   //CargarDatos(DatosAux);
                                //}
                                //else
                                //{
                                //    Response.Redirect("frmNosotrosQuienesSomos.aspx?error=" + "Error al cargar los datos&nError=1");
                                //}
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
                if(Request.Form.Count == 10)
                {
                    bool Band = false;
                    if (imgImagen.HasFile) //Hay cambio de imagen
                    {
                        Band = true;
                    }
                    string titulo              = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();                    
                    string textoAlternativo    = Request.Form["ctl00$cph_MasterBody$txtTextoAlternativo"].ToString();
                    string tituloImagen        = Request.Form["ctl00$cph_MasterBody$txtTituloImagen"].ToString();
                    string txtUrlImg           = Band ? imgImagen.PostedFile.FileName : string.Empty;
                    HttpPostedFile bannerImage = imgImagen.PostedFile as HttpPostedFile;

                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();  
                        string AuxIDImg = Request.Form["ctl00$cph_MasterBody$hfImg"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxID);
                        //Guardar(NuevoRegistro, AuxID, AuxIDImg, titulo, textoHtml, textoAlternativo, tituloImagen, txtUrlImg, bannerImage, Band);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message);
                    }
                }
                else
                {

                }
            }
        }
    }
}