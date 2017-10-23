using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_TerminosCondicionesNegocio
    {
        #region Datos generales aviso de privacidad
        /// <summary>
        /// modifica los textos generales y la imagen de la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ACTerminosCondicionesDatosGenerales(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ACTerminosDatosGenerales(Datos);

        }
        /// <summary>
        /// obtiene los textos generales y la imagen de la pagina terminos y condiciones 
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerTerminosCondicionesGeneralesXID(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos NN = new RR_TerminosCondicionesDatos();
            NN.ObtenerTerminosCondicionesGeneralesXID(Datos);
        }

        #endregion

        #region Avisos de Privacidad
        /// <summary>
        /// altas y cambios en los texto de terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ACTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ACTerminosCondiciones(Datos);
        }
        /// <summary>
        /// bajas en los textos de terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.EliminarTerminosCondiciones(Datos);
        }
        /// <summary>
        /// Obtiene una lista de todos los textos que estan en la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_TerminosCondiciones> ObtenerTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            return APD.ObtenerTerminosCondiciones(Datos);
        }
        /// <summary>
        /// obtiene un texto especifico de la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerTerminosCondicionesdXID(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ObtenerTerminosCondicionesXID(Datos);
        }




        #endregion
    }
}
