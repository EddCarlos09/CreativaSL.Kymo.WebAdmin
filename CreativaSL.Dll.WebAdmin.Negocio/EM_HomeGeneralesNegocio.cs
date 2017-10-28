using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class EM_HomeGeneralesNegocio
    {
        /// <summary>
        /// Es el metodo conector a la capa de datos EM_ContactoImagen
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void AC_HomeImagenes(EM_HomeGenerales Datos)
        {
            try
            {
                EM_HomeGeneralesDatos CD = new EM_HomeGeneralesDatos();
                CD.AC_ImagenHome(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Es el metodo conector a la capa de datos EM_ContactoImagen
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void ObtenerHomeImagenes(EM_HomeGenerales Datos)
        {
            try
            {
                EM_HomeGeneralesDatos CD = new EM_HomeGeneralesDatos();
                CD.ObtenerImagenHome(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
