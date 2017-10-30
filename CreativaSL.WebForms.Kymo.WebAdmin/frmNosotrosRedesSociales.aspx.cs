using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Negocio;
using CreativaSL.WebForms.Kymo.WebAdmin.ClaseAux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreativaSL.WebForms.Kymo.WebAdmin
{
    public partial class frmNosotrosRedesSociales : System.Web.UI.Page
    {
        public List<RR_RedesSociales> Lista = new List<RR_RedesSociales>();
        public string IDMiembroEquipo;
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarRedesSociales();
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
                                RR_RedesSociales DatosAux = new RR_RedesSociales {Conexion = Comun.Conexion, IdMiembroxRedSocial = ID };
                                RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
                                NG.ObtenerNosotrosRedesSocialesDetalle(DatosAux);
                                if (DatosAux.Completado)
                                {
                                    this.IDMiembroEquipo = DatosAux.IdMiembroEquipo;
                                    CargarDatos(DatosAux);
                                }
                                else
                                {
                                    Response.Redirect("frmNosotrosRedesSocialesGrid.aspx?error=" + "Error al cargar los datos&nError=1");
                                }
                            }
                            else
                            {
                                Response.Redirect("frmNosotrosRedesSocialesGrid.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("frmNosotrosRedesSocialesGrid.aspx");
                        }
                    }
                    else if(Request.QueryString["op"] == "1")
                    {
                        if (Request.QueryString["id"] != null)
                        {
                            string ID = Request.QueryString["id"].ToString();
                            if (Request.QueryString["id"].ToString() == ID)
                            {
                                this.IDMiembroEquipo = ID.ToString();
                                hf2.Value = ID.ToString();
                            }
                            else
                            {
                                Response.Redirect("frmNosotrosRedesSocialesGrid.aspx?op=0&id=" + this.ID.ToString(), false);
                            }
                        }
                        else
                            Response.Redirect("frmNosotrosRedesSocialesGrid", false);
                    }
                    else
                    {
                        Response.Redirect("frmNosotrosRedesSocialesGrid", false);
                    }
                }
                else
                {
                    IniciarDatos();
                }
            }
            else
            {
                if(Request.Form.Count == 8)
                {
                    string nickName = Request.Form["ctl00$cph_MasterBody$txtNickName"].ToString();
                    int idredSocial = 6;
                    //string red      = int.TryParse(Request.Form["cmbRedSocial"].ToString(), out idredSocial);
                    try
                    {
                        string IdMiembroRed = Request.Form["ctl00$cph_MasterBody$hf"].ToString();
                        string IdMiembro = Request.Form["ctl00$cph_MasterBody$hf2"].ToString();
                        bool NuevoRegistro  = string.IsNullOrEmpty(IdMiembroRed);
                        Guardar(NuevoRegistro, nickName, idredSocial, IdMiembroRed, IdMiembro);
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {

                }
            }
        }

        public void Guardar(bool _nuevoRegistro, string _nickName, int _idRedSocial, string _idMiembroRed, string _idMiembro)
        {
            RR_RedesSociales DatosAux = new RR_RedesSociales
            {
                NuevoRegistro       = _nuevoRegistro,
                CuentaRedSocial     = _nickName,
                IdTipoRedSocial     = _idRedSocial,
                IdMiembroxRedSocial = _idMiembroRed,
                IdMiembroEquipo     = _idMiembro,
                Conexion            = Comun.Conexion,
                IDUsuario           = User.Identity.Name
            };
            RR_NosotrosNegocio NG = new RR_NosotrosNegocio();
            NG.ACNosotrosRedesSociales(DatosAux);
            if (DatosAux.Completado)
            {
                Response.Redirect("frmNosotrosNuestroEquipoGrid.aspx");
            }
            else
            {
                string ScriptError = DialogMessage.Show(TipoMensaje.Error, "Error al guardar los datos.", "Error", ShowMethod.FadeIn, HideMethod.FadeOut, ToastPosition.TopFullWidth, true);
                ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
            }
        }

        public void CargarDatos(RR_RedesSociales Datos)
        {
            hf.Value = Datos.IdMiembroxRedSocial;
            hf2.Value = IDMiembroEquipo;
            txtNickName.Value = Datos.CuentaRedSocial;            
            string ScriptError = @"
                    $(document).ready(
                        function() {                        
                        document.getElementById('cmbIconos').value=" + Datos.IdTipoRedSocial + @";
                    });";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", ScriptError, true);
        }

        public List<RR_RedesSociales> CargarRedesSociales()
        {
            try
            {
                RR_RedesSociales DatosAux = new RR_RedesSociales { Conexion = Comun.Conexion};
                RR_NosotrosNegocio NG     = new RR_NosotrosNegocio();
                return Lista              =  NG.ObtenerRedesSoc(DatosAux);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void IniciarDatos()
        {
            hf.Value = string.Empty;
            txtNickName.Value = string.Empty;
        }

    }
}