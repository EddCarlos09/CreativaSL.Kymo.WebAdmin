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
    public partial class frmProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RR_Productos DatosAux = new RR_Productos { Conexion = Comun.Conexion };
                RR_ProductosNegocio NN = new RR_ProductosNegocio();
                NN.ObtenerProductosGeneralesXID(DatosAux);
                if (DatosAux.Completado)
                {
                    CargarDatos(DatosAux);
                }
                else
                {
                    IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count == 10)
                {
                    bool Band = false;
                    if (imgImagen.HasFile) //Hay cambio de imagen
                    {
                        Band = true;
                    }
                    string titulo = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    string titulo2 = Request.Form["ctl00$cph_MasterBody$txtTitulo2"].ToString();
                    string textoAlternativo = Request.Form["ctl00$cph_MasterBody$txtTextoAlternativo"].ToString();
                    string tituloImagen = Request.Form["ctl00$cph_MasterBody$txtTituloImagen"].ToString();
                    string NombreRemoverAcentos = Remover.RemoverAcentos(textoAlternativo);
                    string NombreGuardarImagen = Remover.RemoverSignosAcentos(NombreRemoverAcentos);
                    string txtUrlImg = Band ? imgImagen.PostedFile.FileName : string.Empty;
                    HttpPostedFile bannerImage = imgImagen.PostedFile as HttpPostedFile;

                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        string AuxIDImg = Request.Form["ctl00$cph_MasterBody$hfImg"].ToString();
                        bool NuevoRegistro = string.IsNullOrEmpty(AuxIDImg);
                        Guardar(NuevoRegistro, AuxID, AuxIDImg, titulo, titulo2, NombreGuardarImagen, tituloImagen, txtUrlImg, bannerImage, Band);
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
        private void Guardar(bool _nuevoRegistro, string _idTexto, string _idImagen, string _titulo, string _titulo2, string _textoAlternativo, string _tituloImagen, string _urlImagen, HttpPostedFile _postedImage, bool _bandCambioImagen)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = _bandCambioImagen ? Path.GetExtension(_urlImagen) : string.Empty;
                RR_Productos Datos = new RR_Productos
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
                    IdPagina = 8,//COMO SE QUE TIPO DE PAGINA ASIGNARLE ? SE LE ASIGNA EL NUM DE PAG POR DEFAULT??
                    IdTexto = _idTexto,
                    Texto = _titulo,
                    Texto2 = _titulo2,
                    Conexion = Comun.Conexion,
                    IDUsuario = User.Identity.Name
                };
                RR_ProductosNegocio CN = new RR_ProductosNegocio();
                CN.ACProductosDatosGenerales(Datos);
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
                    Response.Redirect("frmProductos.aspx", false);
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
        private void CargarDatos(RR_Productos DatosAux)
        {
            try
            {
                hfImg.Value = DatosAux.TablaDatos.Rows[0]["IdImagen"].ToString();
                txtTitulo.Value = DatosAux.TableTexto.Rows[0]["texto"].ToString();
                txtTitulo2.Value = DatosAux.TableTexto.Rows[0]["texto2"].ToString();
                txtTextoAlternativo.Value = DatosAux.TablaDatos.Rows[0]["TextoAlternativo"].ToString();
                txtTituloImagen.Value = DatosAux.TablaDatos.Rows[0]["TituloImagen"].ToString();
                string BaseDir = Server.MapPath("");

                if (File.Exists(BaseDir + DatosAux.TablaDatos.Rows[0]["UrlImagen"].ToString()))
                {
                    Logo.Attributes.Remove("src");
                    Logo.Attributes.Add("src", DatosAux.TablaDatos.Rows[0]["UrlImagen"].ToString());
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
                hfImg.Value = "";                
                txtTitulo.Value = string.Empty;                
                txtTextoAlternativo.Value = string.Empty;
                txtTituloImagen.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}