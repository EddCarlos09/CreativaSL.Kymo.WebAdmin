using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_ProductosNegocio
    {
        #region Datos generales productos
        /// <summary>
        /// modifica los textos generales y la imagen de la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ACProductosDatosGenerales(RR_Productos Datos)
        {
            RR_ProductosDatos APD = new RR_ProductosDatos();
            APD.ACProductosDatosGenerales(Datos);

        }
        /// <summary>
        /// obtiene los textos generales y la imagen de la pagina terminos y condiciones 
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerProductosGeneralesXID(RR_Productos Datos)
        {
            RR_ProductosDatos NN = new RR_ProductosDatos();
            NN.ObtenerProductosGeneralesXID(Datos);
        }
        #endregion

        #region datos generales producto

        /// <summary>
        /// modifica los textos generales y la imagen de la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ACProductoDatosGenerales(RR_Productos Datos)
        {
            RR_ProductosDatos APD = new RR_ProductosDatos();
            APD.ACProductoDatosGenerales(Datos);

        }
        /// <summary>
        /// obtiene los textos generales y la imagen de la pagina terminos y condiciones 
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerProductoGeneralesXID(RR_Productos Datos)
        {
            RR_ProductosDatos NN = new RR_ProductosDatos();
            NN.ObtenerProductoGeneralesXID(Datos);
        }

        #endregion
    }
}
