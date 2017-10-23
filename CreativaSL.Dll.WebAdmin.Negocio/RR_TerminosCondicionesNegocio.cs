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

        public void ACTerminosCondicionesDatosGenerales(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ACTerminosDatosGenerales(Datos);

        }

        public void ObtenerTerminosCondicionesGeneralesXID(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos NN = new RR_TerminosCondicionesDatos();
            NN.ObtenerTerminosCondicionesGeneralesXID(Datos);
        }

        #endregion

        #region Avisos de Privacidad

        public void ACTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ACTerminosCondiciones(Datos);
        }

        public void EliminarTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.EliminarTerminosCondiciones(Datos);
        }

        public List<RR_TerminosCondiciones> ObtenerTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            return APD.ObtenerTerminosCondiciones(Datos);
        }

        public void ObtenerTerminosCondicionesdXID(RR_TerminosCondiciones Datos)
        {
            RR_TerminosCondicionesDatos APD = new RR_TerminosCondicionesDatos();
            APD.ObtenerTerminosCondicionesXID(Datos);
        }




        #endregion
    }
}
