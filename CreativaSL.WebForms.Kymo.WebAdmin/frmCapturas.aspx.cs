using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using System.IO;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmCapturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                JL_FaqDatosGenerales Datos = new JL_FaqDatosGenerales { Conexion = Comun.Conexion };
                JL_FaqDatosGeneralesNegocio negocio = new JL_FaqDatosGeneralesNegocio();
                negocio.ObtenerDatosGeneralesFaq(Datos);
                if (Datos.Completado)
                {
                    this.CargarDatos(Datos);
                }
                else
                {
                    this.IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count > 0)
                {
                    bool Band = false;
                    if (imgImagen.HasFile) //Hay cambio de imagen
                    {
                        Band = true;
                    }
                    string TituloPagina = Request.Form["ctl00$cph_MasterBody$txtTitulo"].ToString();
                    string TextAlternativo = Request.Form["ctl00$cph_MasterBody$txtTextoAlternativo"].ToString();
                    string NombreRemoverAcentos = Remover.RemoverAcentos(TextAlternativo);
                    string NombreGuardarImagen = Remover.RemoverSignosAcentos(NombreRemoverAcentos);
                    string TituloImagen = Request.Form["ctl00$cph_MasterBody$txtTituloImagen"].ToString();
                    string txtUrlImg = Band ? imgImagen.PostedFile.FileName : string.Empty;
                    string IDImagen = "";
                    HttpPostedFile bannerImage = imgImagen.PostedFile as HttpPostedFile;
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        IDImagen = AuxID;
                        bool NuevoRegistro = string.IsNullOrEmpty(IDImagen);
                        this.Guardar(NuevoRegistro, TituloPagina, IDImagen, TextAlternativo, TituloImagen, NombreGuardarImagen,
                           txtUrlImg, bannerImage, Band);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message, false);
                    }

                }
            }
        }
        private void CargarDatos(JL_FaqDatosGenerales DatosAux)
        {
            try
            {
                hf.Value = DatosAux.TablaDatos.Rows[0]["IdImagen"].ToString();
                txtTitulo.Value = DatosAux.TableTexto.Rows[0]["texto"].ToString();
                string BaseDir = Server.MapPath("");
                if (File.Exists(BaseDir + DatosAux.TablaDatos.Rows[0]["UrlImagen"].ToString()))
                {
                    Logo.Attributes.Remove("src");
                    Logo.Attributes.Add("src", DatosAux.TablaDatos.Rows[0]["UrlImagen"].ToString());
                }
                txtTextoAlternativo.Value = DatosAux.TablaDatos.Rows[0]["TextoAlternativo"].ToString();
                txtTituloImagen.Value = DatosAux.TablaDatos.Rows[0]["TituloImagen"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void IniciarDatos()
        {
            try
            {
                hf.Value = "";
                txtTitulo.Value = string.Empty;
                txtTextoAlternativo.Value = string.Empty;
                txtTituloImagen.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Guardar(bool NuevoRegistro, string NomPagina, string ID, string TextoAlter, string TituloImagan, string UrlImagen,
            string FileName, HttpPostedFile PostedImage, bool BandCambioImagen)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = BandCambioImagen ? Path.GetExtension(FileName) : string.Empty;
                JL_FaqDatosGenerales Datos = new JL_FaqDatosGenerales
                {
                    NuevoRegistro = NuevoRegistro,
                    TituloPagina = NomPagina,
                    IdImagen = ID,
                    IdPagina = 3,
                    Extencion = FileExtension,
                    CambiarImagen = BandCambioImagen,
                    UrlImagen = UrlImagen,
                    TextoAlternativo = TextoAlter,
                    TituloImagen = TituloImagan,
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario,
                };
                JL_FaqDatosGeneralesNegocio CN = new JL_FaqDatosGeneralesNegocio();
                CN.AC_ImagenFaq(Datos);
                if (Datos.Completado)
                {
                    if (BandCambioImagen)
                    {
                        if (PostedImage != null && PostedImage.ContentLength > 0)
                        {
                            try
                            {
                                Stream S = PostedImage.InputStream;
                                System.Drawing.Image Img = new System.Drawing.Bitmap(S);
                                Img.Save(BaseDir + Datos.UrlImagen);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    Response.Redirect("frmEjemplo.aspx", false);
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
    }
}