using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class EM_ContactoImagenesNegocio
    {
        /// <summary>
        /// Es el metodo conector a la capa de datos EM_ContatoImagenesDatos
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void AC_ContactoImagenes(EM_ContactoImagen Datos)
        {
            try
            {
                EM_ContatoImagenesDatos CD = new EM_ContatoImagenesDatos();
                CD.AC_ImagenContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Es el metodo conector a la capa de datos EM_ContatoImagenesDatos
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void ObtenerContactoImagenes(EM_ContactoImagen Datos)
        {
            try
            {
                EM_ContatoImagenesDatos CD = new EM_ContatoImagenesDatos();
                CD.ObtenerImagenContacto(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
