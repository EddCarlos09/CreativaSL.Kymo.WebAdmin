using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_AvisoPrivacidadNegocio
    {
        #region Datos generales aviso de privacidad
        /// <summary>
        /// Modifica los datos generales de la pagina aviso de privacidad
        /// </summary>
        /// <param name="Datos"></param>
        public void ACAvisoPrivacidadDatosGenerales(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ACAvisoPrivacidadDatosGenerales(Datos);

        }

        /// <summary>
        /// obtiene los datos generales de la pagina aviso de privacidad
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerAvisoPrivacidadDatosGeneralesXID(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos NN = new RR_AvisoPrivacidadDatos();
            NN.ObtenerAvisoPrivacidadDatosGeneralesXID(Datos);
        }

        #endregion

        #region Avisos de Privacidad

        /// <summary>
        /// Altas y cambios de textos en la pagina aviso de privacidad
        /// </summary>
        /// <param name="Datos"></param>
        public void ACAvisoPrivacidad (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ACAvisoPrivacidad(Datos);
        }
        /// <summary>
        /// elimina texto en la pagina aviso de privacidad
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarAvisoPrivacidad (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.EliminarAvisoPrivacidad(Datos);
        }
        /// <summary>
        /// obtiene la lista de los textos Aviso de privacidad
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_AvisoPrivacidadDatosGenerales> ObtenerAvisosPrivacidad(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            return APD.ObtenerAvisosPrivacidad(Datos);
        }
        /// <summary>
        /// obtiene el detalle del aviso de privacidad seleccionado
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerAvisoPrivacidadXID (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ObtenerAvisoPrivacidadXID(Datos);
        }
        
        #endregion

    }
}
