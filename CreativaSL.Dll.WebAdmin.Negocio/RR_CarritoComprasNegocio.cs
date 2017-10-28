using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_CarritoComprasNegocio
    {
        public void ACCarritoComprasDatosGeneral(RR_CarritoComprasDatosGenerales Datos)
        {
            RR_CarritoComprasDatos CCD = new RR_CarritoComprasDatos();
            CCD.ACCarritoComprasDatosGeneral(Datos);
        }

        public void ObtenerTextosCarritoComprasDatosGeneralesXID(RR_CarritoComprasDatosGenerales Datos)
        {
            RR_CarritoComprasDatos NN = new RR_CarritoComprasDatos();
            NN.ObtenerTextosCarritoComprasDatosGeneralesXID(Datos);
        }
    }
}
