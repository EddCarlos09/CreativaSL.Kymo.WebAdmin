using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class EM_ContactoGeneralNegocio
    {
        public void AC_DatosDeContacto(EM_ContactoGeneral Datos)
        {
            try
            {
                EM_ContactoGeneralDatos CD = new EM_ContactoGeneralDatos();
                CD.AC_DatosDeContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ObtenerDatosContacto(EM_ContactoGeneral Datos)
        {
            try
            {
                EM_ContactoGeneralDatos CD = new EM_ContactoGeneralDatos();
                CD.ObtenerDatosContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
