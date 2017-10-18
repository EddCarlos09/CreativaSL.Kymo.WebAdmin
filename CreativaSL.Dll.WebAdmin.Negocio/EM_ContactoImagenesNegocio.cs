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
