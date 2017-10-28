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
    public partial class frmHomeImagenesGenerales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EM_HomeGenerales DatosAux = new EM_HomeGenerales { Conexion = Comun.Conexion };
                EM_HomeGeneralesNegocio CN = new EM_HomeGeneralesNegocio();
                CN.ObtenerHomeImagenes(DatosAux);
                if (DatosAux.Completado)
                {
                    this.CargarDatos(DatosAux);
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
                        this.Guardar(NuevoRegistro, IDImagen, TextAlternativo, TituloImagen, NombreGuardarImagen,
                           txtUrlImg, bannerImage, Band);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message, false);
                    }

                }
            }
        }
        #region Métodos

        private void CargarDatos(EM_HomeGenerales DatosAux)
        {
            try
            {
                hf.Value = DatosAux.TablaDatos.Rows[0]["IdImagen"].ToString();
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

        private void Guardar(bool NuevoRegistro, string ID, string TextoAlter, string TituloImagan, string UrlImagen,
            string FileName, HttpPostedFile PostedImage, bool BandCambioImagen)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = BandCambioImagen ? Path.GetExtension(FileName) : string.Empty;
                EM_HomeGenerales Datos = new EM_HomeGenerales
                {
                    NuevoRegistro = NuevoRegistro,
                    IdImagen = ID,
                    IdPagina = 4,
                    Extencion = FileExtension,
                    CambiarImagen = BandCambioImagen,
                    UrlImagen = UrlImagen,
                    TextoAlternativo = TextoAlter,
                    TituloImagen = TituloImagan,
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario,
                };
                EM_HomeGeneralesNegocio CN = new EM_HomeGeneralesNegocio();
                CN.AC_HomeImagenes(Datos);
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
                    Response.Redirect("frmHomeImagenesGenerales.aspx", false);
                }
                else
                {
                    if (Datos.Resultado == 2)
                    {
                        string ScriptError = DialogMessage.Show(TipoMensaje.Info, "Se tiene que modificar la imagen", "Informaci&oacute;n", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    }
                    else
                    {
                        string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                    }
                }
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