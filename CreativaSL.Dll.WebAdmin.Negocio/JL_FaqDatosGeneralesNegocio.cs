using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class JL_FaqDatosGeneralesNegocio
    {
        public void AC_ImagenFaq(JL_FaqDatosGenerales Datos)
        {
            try
            {
                JL_FaqDatosGeneralesDatos datos = new JL_FaqDatosGeneralesDatos();
                datos.AC_ImagenFaq(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDatosGeneralesFaq(JL_FaqDatosGenerales Datos)
        {
            try
            {
                JL_FaqDatosGeneralesDatos datos = new JL_FaqDatosGeneralesDatos();
                datos.ObtenerDatosGeneralesFaq(Datos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
