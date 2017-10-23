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

        public void ACAvisoPrivacidadDatosGenerales(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ACAvisoPrivacidadDatosGenerales(Datos);

        }

        public void ObtenerAvisoPrivacidadDatosGeneralesXID(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos NN = new RR_AvisoPrivacidadDatos();
            NN.ObtenerAvisoPrivacidadDatosGeneralesXID(Datos);
        }

        #endregion

        #region Avisos de Privacidad

        public void ACAvisoPrivacidad (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ACAvisoPrivacidad(Datos);
        }

        public void EliminarAvisoPrivacidad (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.EliminarAvisoPrivacidad(Datos);
        }

        public List<RR_AvisoPrivacidadDatosGenerales> ObtenerAvisosPrivacidad(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            return APD.ObtenerAvisosPrivacidad(Datos);
        }

        public void ObtenerAvisoPrivacidadXID (RR_AvisoPrivacidadDatosGenerales Datos)
        {
            RR_AvisoPrivacidadDatos APD = new RR_AvisoPrivacidadDatos();
            APD.ObtenerAvisoPrivacidadXID(Datos);
        }




        #endregion

    }
}
