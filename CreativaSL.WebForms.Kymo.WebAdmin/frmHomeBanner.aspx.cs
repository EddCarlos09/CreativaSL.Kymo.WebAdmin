using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using System.IO;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmHomeBanner : System.Web.UI.Page
    {
        public List<EM_HomeBanner> _ListaTipoBanner = new List<EM_HomeBanner>();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CargarComboBox();
            if (!IsPostBack)
            {
                if (Request.QueryString["op"] != null)
                {
                    if (Request.QueryString["op"] == "2")
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            string ID = Request.QueryString["id"].ToString();
                            EM_HomeBanner DatosAux = new EM_HomeBanner { Conexion = Comun.Conexion, IdBanner = ID };
                            EM_HomeBannerNegocio CN = new EM_HomeBannerNegocio();
                            CN.ObtenerDetalleIDBanner(DatosAux);
                            if (DatosAux.Completado)
                            {
                                this.CargarDatos(DatosAux);
                            }
                            else
                            {
                                Response.Redirect("frmHomeBannerGrid.aspx?error=" + "Error al cargar los datos&nError=1");
                            }
                        }
                        else
                            Response.Redirect("frmHomeBannerGrid.aspx");
                    }
                    else
                        Response.Redirect("frmHomeBannerGrid.aspx");
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
                    string txtNombreInicial = Request.Form["ctl00$cph_MasterBody$txtNombreInicial"].ToString();
                    string txtNombreBanner = Request.Form["ctl00$cph_MasterBody$txtNombreBanner"].ToString();
                    bool verMas = false;
                    string Todos = Request.Form["txtverMas"] != null ? Request.Form["txtverMas"].ToString() : string.Empty;
                    bool.TryParse(Todos, out verMas);
                    int IDTBanner = 0;
                    int.TryParse(Request.Form["cmbTipoBanner"].ToString(), out IDTBanner);
                    string txtUrlBanner = Request.Form["ctl00$cph_MasterBody$txtUrlBanner"].ToString();
                    string txtButton = Request.Form["ctl00$cph_MasterBody$txtButton"].ToString();
                    string txtUrlImg = Band ? imgLogo.PostedFile.FileName : string.Empty;
                    string txtAlt = Request.Form["ctl00$cph_MasterBody$txtAlt"].ToString();
                    string txtTitle = Request.Form["ctl00$cph_MasterBody$txtTitle"].ToString();
                    string NombreImagenAC = Remover.RemoverAcentos(txtTitle);
                    string NombreImagenReal = Remover.RemoverSignosAcentos(NombreImagenAC);
                    HttpPostedFile bannerImage = imgLogo.PostedFile as HttpPostedFile;
                    string IdBanner = "";
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        IdBanner = AuxID;
                        bool NuevoRegistro = string.IsNullOrEmpty(IdBanner);
                        this.Guardar(NuevoRegistro, IdBanner, IDTBanner, NombreImagenReal, txtNombreInicial, txtNombreBanner, verMas, txtUrlBanner, txtButton, txtUrlImg, txtTitle, txtAlt, bannerImage, Band);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message);
                    }
                }
            }
        }
        private void CargarDatos(EM_HomeBanner DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IdBanner;
                txtNombreInicial.Value = DatosAux.TextoInicial;
                txtNombreBanner.Value = DatosAux.TextoPrincipal;
                txtTitle.Value = DatosAux.Title;
                txtAlt.Value = DatosAux.Alt;
                if (DatosAux.Comprar == true)
                {
                    string ScriptError = @"
                $(document).ready(
                    function() {
                    $('#txtverMas').prop('checked', " + DatosAux.Comprar.ToString().ToLower() + @");
                    $('#cph_MasterBody_mostrar').show();
                    document.getElementById('cmbTipoBanner').value=" + DatosAux.IdTipoBanner + @";                 
                });";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
                }
                else
                {
                    string ScriptErrors = @"
                $(document).ready(
                    function() {
                    document.getElementById('cmbTipoBanner').value=" + DatosAux.IdTipoBanner + @";                    
                });";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptErrors, true);
                }
                txtUrlBanner.Value = DatosAux.UrlDestino;
                txtButton.Value = DatosAux.TextoButton;
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

        private void Guardar(bool NuevoRegistro, string IDIBanner, int IDTBanner, string NombreImag, string TextoInicial, string TextoPrincipal, bool verMas, string URLBanner, string TextoButtton, string FileName, string Title, string Alt, HttpPostedFile PostedImage,  bool Band)
        {
            try
            {
                string BaseDir = Server.MapPath("");
                string FileExtension = Band ? Path.GetExtension(FileName) : string.Empty;
                EM_HomeBanner Datos = new EM_HomeBanner
                {
                    NuevoRegistro = NuevoRegistro,
                    IdBanner = IDIBanner,
                    IdTipoBanner = IDTBanner,
                    TextoInicial = TextoInicial,
                    TextoPrincipal = TextoPrincipal,
                    Comprar = verMas,
                    UrlDestino = URLBanner,
                    TextoButton = TextoButtton,
                    UrlImagen = FileName,
                    Alt = Alt,
                    Title = Title,
                    CambiarImagen = Band,
                    NombreImagen = NombreImag,
                    Extencion = FileExtension,
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario
                };
                EM_HomeBannerNegocio LB = new EM_HomeBannerNegocio();
                LB.AC_Banner(Datos);
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
                    Response.Redirect("frmHomeBannerGrid.aspx", false);
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
                txtNombreInicial.Value = string.Empty;
                txtNombreBanner.Value = string.Empty;
                txtUrlBanner.Value = string.Empty;
                txtButton.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboBox()
        {
            EM_HomeBanner Datos = new EM_HomeBanner { Conexion = Comun.Conexion };
            EM_HomeBannerNegocio CN = new EM_HomeBannerNegocio();
            _ListaTipoBanner = CN.ObtenerComboTipoBanner(Datos);
        }
    }
}
  