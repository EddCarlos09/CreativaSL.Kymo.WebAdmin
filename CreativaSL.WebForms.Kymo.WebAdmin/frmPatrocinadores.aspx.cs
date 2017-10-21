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
    public partial class frmPatrocinadores : System.Web.UI.Page
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
                            string ID = Request.QueryString["id"].ToString();
                            EM_Patrocinadores DatosAux = new EM_Patrocinadores { Conexion = Comun.Conexion, IdPatrocinadores = ID };
                            EM_PatrocinadoresNegocio CN = new EM_PatrocinadoresNegocio ();
                            CN.ObtenerDetallePatrocinadores(DatosAux);
                            if (DatosAux.Completado)
                            {
                                this.CargarDatos(DatosAux);
                            }
                            else
                            {
                                Response.Redirect("frmPatrocinadoresGrid.aspx?error=" + "Error al cargar los datos&nError=1");
                            }
                        }
                        else
                            Response.Redirect("frmPatrocinadoresGrid.aspx");
                    }
                    else
                        Response.Redirect("frmPatrocinadoresGrid.aspx");
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
                    if (imgLogo.HasFile)
                    {
                        Band = true;
                    }
                    string txtNombreCompleto = Request.Form["ctl00$cph_MasterBody$txtNombreP"].ToString();
                    string txtUrlDes = Request.Form["ctl00$cph_MasterBody$txtUrlDestino"].ToString();
                    string txtUrlImg = Band ? imgLogo.PostedFile.FileName : string.Empty;
                    string txtAlt = Request.Form["ctl00$cph_MasterBody$txtAlt"].ToString();
                    string txtTitle = Request.Form["ctl00$cph_MasterBody$txtTitle"].ToString();
                    string NombreImagenAC = Remover.RemoverAcentos(txtTitle);
                    string NombreImagenReal = Remover.RemoverSignosAcentos(NombreImagenAC);
                    HttpPostedFile bannerImage = imgLogo.PostedFile as HttpPostedFile;
                    string IDPatro = "";
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        IDPatro = AuxID;
                        bool NuevoRegistro = string.IsNullOrEmpty(IDPatro);
                        this.Guardar(NuevoRegistro, IDPatro, txtNombreCompleto, txtTitle, txtAlt, txtUrlDes, NombreImagenReal, txtUrlImg, bannerImage, Band);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message);
                    }
                }
            }
        }

        private void CargarDatos(EM_Patrocinadores DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IdPatrocinadores;
                txtNombreP.Value = DatosAux.NombreCompleto;
                txtTitle.Value = DatosAux.Title;
                txtAlt.Value = DatosAux.Alt;
                txtUrlDestino.Value = DatosAux.UrlDestino;
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

        private void Guardar(bool NuevoRegistro, string IDPatrocinador, string NombreCompl, string Title, string Alt, string UrlDestino, string NombreImagen, string FileName,  HttpPostedFile PostedImage, bool Band)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = Band ? Path.GetExtension(FileName) : string.Empty;
                EM_Patrocinadores Datos = new EM_Patrocinadores
                {
                    NuevoRegistro = NuevoRegistro,
                    IdPatrocinadores = IDPatrocinador,
                    NombreCompleto = NombreCompl,
                    UrlDestino = UrlDestino,
                    UrlImagen = FileName,
                    Alt = Alt,
                    Title = Title,
                    CambiarImagen = Band,
                    NombreImagen = NombreImagen,
                    Extencion = FileExtension,
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario
                };
                EM_PatrocinadoresNegocio LB = new EM_PatrocinadoresNegocio();
                LB.AC_Patrocinadores(Datos);
                if (Datos.Completado)
                {
                    if (Band)
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
                    Response.Redirect("frmPatrocinadoresGrid.aspx", false);
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

        private void IniciarDatos()
        {
            try
            {
                hf.Value = "";
                txtTitle.Value = string.Empty;
                txtAlt.Value = string.Empty;
                txtNombreP.Value = string.Empty;
                txtUrlDestino.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}