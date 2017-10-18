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
        /// <summary>
        /// El el metodo es para dar de alta y modificacion de los Datos de Contacto
        /// </summary>
        /// <param name="Datos">Es la coleccion de datos que puede recibir de Tipo EM_CantactoGeneral</param>
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

        /// <summary>
        /// El metedo es para obtener y pintar los datos de contactos
        /// </summary>
        /// <param name="Datos"></param>
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
