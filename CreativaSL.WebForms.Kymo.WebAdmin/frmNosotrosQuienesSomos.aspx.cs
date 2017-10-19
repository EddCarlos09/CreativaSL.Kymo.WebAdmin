using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using CreativaSL.WebForms.Kymo.WebAdmin.ClasesAux;
using System;
using System.Collections.Generic;
using System.IO;
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
                                RR_NosotrosQuienesSomos DatosAux = new RR_NosotrosQuienesSomos { Conexion = Comun.Conexion, IdSeccion = ID};
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                NG.ObtenerNosotrosQuienesSomosXID(DatosAux);
                                if (DatosAux.Completado)
                                {
                                   CargarDatos(DatosAux);
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
                if(Request.Form.Count == 10)
                {
                    bool Band = false;
                    if (imgImagen.HasFile) //Hay cambio de imagen
                    {
                        Band = true;
                    }
                    string titulo              = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    string textoHtml           = HttpUtility.HtmlDecode(txtDescripcion.InnerHtml);
                    string textoAlternativo    = Request.Form["ctl00$cph_MasterBody$txtTextoAlternativo"].ToString();
                    string tituloImagen        = Request.Form["ctl00$cph_MasterBody$txtTituloImagen"].ToString();
                    string txtUrlImg           = Band ? imgImagen.PostedFile.FileName : string.Empty;
                    HttpPostedFile bannerImage = imgImagen.PostedFile as HttpPostedFile;

                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();  
                        string AuxIDImg = Request.Form["ctl00$cph_MasterBody$hfImg"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxID);
                        Guardar(NuevoRegistro, AuxID, AuxIDImg, titulo, textoHtml, textoAlternativo, tituloImagen, txtUrlImg, bannerImage, Band);
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

        #region Metodos

        /// <summary>
        /// Metodo para guardar en la tabla "Nosotros quienes somos" y "Cat Imagen"
        /// </summary>
        /// <param name="_nuevoRegistro">Indica si es nuevo registro o no</param>
        /// <param name="_idSeccion">Identificador de la pagina</param>
        /// <param name="_idImagen">Identificador de la imagen</param>
        /// <param name="_titulo">Titulo de la pagina</param>
        /// <param name="_textoHtml">texto html de la pagina</param>
        /// <param name="_textoAlternativo">texto alternativo de la imagen</param>
        /// <param name="_tituloImagen">titulo de la imagen</param>
        /// <param name="_urlImagen">url de la imagen</param>
        /// <param name="PostedImage"></param>
        /// <param name="BandCambioImagen">Si se cambio la imagen</param>
        private void Guardar(bool _nuevoRegistro, string _idSeccion, string _idImagen, string _titulo, string _textoHtml, string _textoAlternativo, string _tituloImagen, string _urlImagen, HttpPostedFile PostedImage, bool BandCambioImagen)
        {
            try
            {                
                string BaseDir = Server.MapPath("");
                string FileExtension = BandCambioImagen ? Path.GetExtension(_urlImagen) : string.Empty;
                string nombreImagen =  Remover.RemoverSignosAcentos(_urlImagen);
                RR_NosotrosQuienesSomos Datos = new RR_NosotrosQuienesSomos
                {
                    NuevoRegistro    = _nuevoRegistro,
                    IdImagen         = _idImagen,
                    TextoAlternativo = _textoAlternativo,
                    TituloImagen     = _tituloImagen,
                    NumPosition      = 1,// A QUE SE REFIERE CON NUM POSITION EN LA BD!!!!!
                    UrlImagen        = BaseDir,
                    NombreImagen     = nombreImagen,
                    Extencion        = FileExtension,                    
                    CambioImagen     = BandCambioImagen,
                    IdPagina         = 2,//COMO SE QUE TIPO DE PAGINA ASIGNARLE ? SE LE ASIGNA EL NUM DE PAG POR DEFAULT??
                    IdSeccion        = _idSeccion,
                    Titulo           = _titulo,
                    TextoHtml        = _textoHtml,
                    Conexion         = Comun.Conexion,
                    IDUsuario        = User.Identity.Name
                };
                RR_NosotrosNegocio CN = new RR_NosotrosNegocio();
                CN.ACNosotrosQuienesSomos(Datos);                
                if (Datos.Completado)
                {                    
                    Response.Redirect("frmMiembrosEquipoTrabajo.aspx", false);
                }
                else
                {
                    string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga los datos que se van a editar
        /// </summary>
        /// <param name="DatosAux"></param>
        private void CargarDatos(RR_NosotrosQuienesSomos DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IdSeccion;
                hfImg.Value = DatosAux.IdImagen;
                txtTitulo.Value = DatosAux.Titulo;
                txtDescripcion.Value = DatosAux.TextoHtml;
                txtTextoAlternativo.Value = DatosAux.TextoAlternativo;
                txtTituloImagen.Value = DatosAux.TituloImagen;
                string BaseDir = Server.MapPath("");                
                if (File.Exists(BaseDir + DatosAux.UrlImagen))
                {
                    Logo.Attributes.Remove("src");
                    Logo.Attributes.Add("src", DatosAux.UrlImagen);
                }
                Response.Cookies.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicializa los campos de la pagina a un valor vacion
        /// </summary>
        private void IniciarDatos()
        {
            try
            {
                hf.Value                  = "";
                hfImg.Value               = "";               
                txtTitulo.Value           = string.Empty;
                txtDescripcion.Value      = string.Empty;
                txtTextoAlternativo.Value = string.Empty;
                txtTituloImagen.Value     = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}