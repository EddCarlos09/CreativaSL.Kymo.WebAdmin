using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using System;
using System.Collections.Generic;
using System.IO;
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
                                RR_NosotrosEquipoTrabajo DatosAux = new RR_NosotrosEquipoTrabajo { Conexion = Comun.Conexion, IdMiembroEquipo = ID };
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                NG.ObtenerNosotrosQuienesSomosXID(DatosAux);
                                if (DatosAux.Completado)
                                {
                                    CargarDatos(DatosAux);
                                }
                                else
                                {
                                    Response.Redirect("frmNosotrosNuestroEquipo.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("frmNosotrosNuestroEquipo.aspx");
                    }
                }
                else
                {
                    IniciarDatos();
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
                    string nombre              = Request.Form["ctl00$cph_MasterBody$txtNombre"].ToString();                    
                    string puesto              = Request.Form["ctl00$cph_MasterBody$txtPuesto"].ToString();
                    string tituloImagen        = Request.Form["ctl00$cph_MasterBody$txtTituloImagen"].ToString();
                    string textoAlternativo = Request.Form["ctl00$cph_MasterBody$txtTextoAlternativo"].ToString();
                    string NombreRemoverAcentos = Remover.RemoverAcentos(textoAlternativo);
                    string NombreGuardarImagen = Remover.RemoverSignosAcentos(NombreRemoverAcentos);
                    string txtUrlImg           = Band ? imgImagen.PostedFile.FileName : string.Empty;
                    HttpPostedFile bannerImage = imgImagen.PostedFile as HttpPostedFile;

                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        string AuxIDImg = Request.Form["ctl00$cph_MasterBody$hfImg"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxID);
                        Guardar(NuevoRegistro, AuxID, AuxIDImg, nombre, puesto, NombreGuardarImagen, tituloImagen, txtUrlImg, bannerImage, Band);
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
        private void Guardar(bool _nuevoRegistro, string _idMiembroEquipo, string _idImagen, string _nombre, string _puesto, string _textoAlternativo, string _tituloImagen, string _urlImagen, HttpPostedFile _postedImage, bool _bandCambioImagen)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = _bandCambioImagen ? Path.GetExtension(_urlImagen) : string.Empty;                
                RR_NosotrosEquipoTrabajo Datos = new RR_NosotrosEquipoTrabajo
                {
                    NuevoRegistro = _nuevoRegistro,
                    IdImagen = _idImagen,
                    TextoAlternativo = _textoAlternativo,
                    TituloImagen = _tituloImagen,
                    NumPosition = 1,// A QUE SE REFIERE CON NUM POSITION EN LA BD!!!!!
                    UrlImagen = BaseDir,
                    NombreImagen = _textoAlternativo,
                    Extencion = FileExtension,
                    CambioImagen = _bandCambioImagen,
                    IdPagina = 2,//COMO SE QUE TIPO DE PAGINA ASIGNARLE ? SE LE ASIGNA EL NUM DE PAG POR DEFAULT??
                    IdMiembroEquipo = _idMiembroEquipo,
                    NombreMostrar = _nombre,
                    Puesto = _puesto,
                    Conexion = Comun.Conexion,
                    IDUsuario = User.Identity.Name
                };
                RR_NosotrosNegocio CN = new RR_NosotrosNegocio();
                CN.ACNosotrosEquipoTrabajo(Datos);
                if (Datos.Completado)
                {
                    if (_bandCambioImagen)
                    {
                        if (_postedImage != null && _postedImage.ContentLength > 0)
                        {
                            try
                            {
                                Stream S = _postedImage.InputStream;
                                System.Drawing.Image Img = new System.Drawing.Bitmap(S);
                                Img.Save(BaseDir + Datos.UrlImagen);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    Response.Redirect("frmNosotrosNuestroEquipoGrid.aspx", false);
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
        private void CargarDatos(RR_NosotrosEquipoTrabajo DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IdMiembroEquipo;
                hfImg.Value = DatosAux.IdImagen;        
                txtNombre.Value = DatosAux.NombreMostrar;
                txtPuesto.Value = DatosAux.Puesto;
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
                hf.Value = "";                
                txtNombre.Value = string.Empty;
                txtPuesto.Value = string.Empty;
                txtTextoAlternativo.Value = string.Empty;
                txtTituloImagen.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}