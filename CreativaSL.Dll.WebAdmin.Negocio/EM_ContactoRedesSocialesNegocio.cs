using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    /// <summary>
    /// Es el Conector para la capa de datos 
    /// </summary>
    public class EM_ContactoRedesSocialesNegocio
    {
        public void AC_ContactoRedesSociales(EM_ContactoRedesSociales Datos)
        {
            try
            {
                EM_ContactoRedesSocialesDatos CD = new EM_ContactoRedesSocialesDatos();
                CD.AC_RedesSocialesContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<EM_ContactoRedesSociales> ObtenerContactoRedesSociales(EM_ContactoRedesSociales Datos)
        {
            try
            {
                EM_ContactoRedesSocialesDatos CD = new EM_ContactoRedesSocialesDatos();
                return CD.ObtenerDatosContactoRedes(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerDetalleContactoRedSocial(EM_ContactoRedesSociales Datos)
        {
            try
            {
                EM_ContactoRedesSocialesDatos CD = new EM_ContactoRedesSocialesDatos();
                CD.ObtenerDetalleRedesSocialesContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EM_ContactoRedesSociales> ObtenerComboRedesSocialesTipo(EM_ContactoRedesSociales Datos)
        {
            try
            {
                EM_ContactoRedesSocialesDatos CD = new EM_ContactoRedesSocialesDatos();
                return CD.ObtenerComboTipoRedeSociale(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarContactoRedesSocialesXID(EM_ContactoRedesSociales Datos)
        {
            try
            {
                EM_ContactoRedesSocialesDatos CD = new EM_ContactoRedesSocialesDatos();
                CD.EliminarRedeSocialContactoXID(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
