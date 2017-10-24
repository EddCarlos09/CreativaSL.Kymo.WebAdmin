using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmContactoRedesSociales : System.Web.UI.Page
    {
        public List<EM_ContactoRedesSociales> _ListaTipoRedSocial = new List<EM_ContactoRedesSociales>();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CargarComboBox();
            if (!IsPostBack)
            {
                //Se inicializan campos, datos, valores
                if (Request.QueryString["op"] != null)
                {
                    if (Request.QueryString["op"] == "2")
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            string IDAux = Request.QueryString["id"].ToString();
                            //Obtener los datos y dibujarlos.
                            EM_ContactoRedesSociales DatosAux = new EM_ContactoRedesSociales() { Conexion = Comun.Conexion, IdRedSocial = IDAux };
                            EM_ContactoRedesSocialesNegocio CN = new EM_ContactoRedesSocialesNegocio();
                            CN.ObtenerDetalleContactoRedSocial(DatosAux);
                            if (DatosAux.Completado)
                            {
                                this.CargarDatos(DatosAux);
                            }
                            else
                            {
                                Response.Redirect("frmContactoRedesSocialesGrid.aspx?errorMessage=" + DatosAux.Resultado);
                            }
                        }
                        else
                            Response.Redirect("frmContactoRedesSocialesGrid.aspx?errorMessage=2");
                    }
                    else
                        Response.Redirect("frmContactoRedesSocialesGrid.aspx?errorMessage=3");
                }
                else
                {
                    this.IniciarDatos();
                }
            }
            else
            {
                if (Request.Form.Count == 7)
                {
                    string txtCuenta = Request.Form["ctl00$cph_MasterBody$txtNickName"].ToString();
                    int IdTipoRed = 0;
                    int.TryParse(Request.Form["cmbRedSocial"].ToString(), out IdTipoRed);
                    string IdRed = "";
                    try
                    {
                        string AuxID = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        IdRed = AuxID;
                        bool NuevoRegistro = string.IsNullOrEmpty(IdRed);
                        this.Guardar(NuevoRegistro, IdRed, IdTipoRed, txtCuenta);
                    }
                    catch (Exception ex)
                    {
                        Response.Redirect("ErrorPage.aspx?msjError=" + ex.Message);
                    }
                }
            }
        }

        #region Metodos
        private void CargarDatos(EM_ContactoRedesSociales DatosAux)
        {
            try
            {
                hf.Value = DatosAux.IdRedSocial.ToString();
                txtNickName.Value = DatosAux.Cuenta.ToString();
                string ScriptError = @"
                    $(document).ready(
                        function() {                        
                        document.getElementById('cmbRedSocial').value=" + DatosAux.IdTipoRedSocial + @";
                    });";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarComboBox()
        {
            EM_ContactoRedesSociales Datos = new EM_ContactoRedesSociales { Conexion = Comun.Conexion };
            EM_ContactoRedesSocialesNegocio CN = new EM_ContactoRedesSocialesNegocio();
            _ListaTipoRedSocial = CN.ObtenerComboRedesSocialesTipo(Datos);
        }

        private void Guardar(bool nuevoRegistro, string IDImga, int IdTipoRed, string Cuen)
        {
            try
            {
                EM_ContactoRedesSociales Datos = new EM_ContactoRedesSociales
                {
                    NuevoRegistro = nuevoRegistro,
                    IdRedSocial = IDImga,
                    IdTipoRedSocial = IdTipoRed,
                    Cuenta = Cuen,
                    Conexion = Comun.Conexion,
                    IDUsuario = Comun.IDUsuario
                };
                EM_ContactoRedesSocialesNegocio CN = new EM_ContactoRedesSocialesNegocio();
                CN.AC_ContactoRedesSociales(Datos);
                if (Datos.Completado)
                {
                    Response.Redirect("frmContactoRedesSocialesGrid.aspx", false);
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
                txtNickName.Value = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}