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
