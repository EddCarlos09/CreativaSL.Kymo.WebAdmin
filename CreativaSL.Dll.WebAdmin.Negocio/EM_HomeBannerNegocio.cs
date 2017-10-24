using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class EM_HomeBannerNegocio
    {
        /// <summary>
        /// El metodo es para dar de alta y cambios de un baner de home
        /// </summary>
        /// <param name="Datos">se envian la cadena de conexion y los parametos</param>
        public void AC_Banner(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeBannerDatos LB = new EM_HomeBannerDatos();
                LB.AGBanner(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtener los datos que se van a pintar en el grid
        /// </summary>
        /// <param name="Datos">Las parametos de caneda de coxion y los parametos que recibe</param>
        /// <returns>Retorna una lista</returns>
        public List<EM_HomeBanner> ObtenerListaBanner(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeBannerDatos LD = new EM_HomeBannerDatos();
                return LD.ObtenerListBanner(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtenemos los daos de un registro para modificarlos
        /// </summary>
        /// <param name="Datos">Enviamos y retornamos los datos</param>
        public void ObtenerDetalleIDBanner(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeBannerDatos BD = new EM_HomeBannerDatos();
                BD.ObtenerDetalleHomeBannerID(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Es para darle de baja a un banner 
        /// </summary>
        /// <param name="Datos">Se envia el id de lo que se va a eliminar</param>
        public void EliminarBannerHome(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeBannerDatos FD = new EM_HomeBannerDatos();
                FD.EliminarHomeBanner(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// llena el tipo de banner
        /// </summary>
        /// <param name="Datos">Enviamos los datos que recibe nuestro metodo</param>
        /// <returns>retornamos una lista con los datos</returns>
        public List<EM_HomeBanner> ObtenerComboTipoBanner(EM_HomeBanner Datos)
        {
            try
            {
                EM_HomeBannerDatos LD = new EM_HomeBannerDatos();
                return LD.ObtenerComboBannerTipo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
