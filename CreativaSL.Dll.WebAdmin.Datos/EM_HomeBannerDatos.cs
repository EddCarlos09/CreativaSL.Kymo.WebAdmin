using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class EM_HomeBannerDatos
    {
        public void AGBanner(EM_HomeBanner Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdBanner, Datos.IdTipoBanner, Datos.TextoInicial, Datos.TextoPrincipal, Datos.Comprar, Datos.UrlDestino, Datos.TextoButton, Datos.UrlImagen, Datos.Alt, Datos.Title, Datos.Extencion, Datos.NombreImagen, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_AC_Home_Banner", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("URLImagen"));
                    }
                    Datos.Resultado = Resultado;
                    break;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<EM_HomeBanner> ObtenerListBanner(EM_HomeBanner Datos)
        {
            try
            {
                List<EM_HomeBanner> Lista = new List<EM_HomeBanner>();
                EM_HomeBanner Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_Banner");
                while (Dr.Read())
                {

                    Item = new EM_HomeBanner();
                    Item.IdBanner = Dr.GetString(Dr.GetOrdinal("IdBanner"));
                    Item.IdTipoBanner = Dr.GetInt32(Dr.GetOrdinal("IdTipoBanner"));
                    Item.TextoInicial = Dr.GetString(Dr.GetOrdinal("TextoInicial"));
                    Item.TextoPrincipal = Dr.GetString(Dr.GetOrdinal("TextoPrincipal"));
                    Item.Comprar = Dr.GetBoolean(Dr.GetOrdinal("ComprarAhora"));
                    Item.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Item.TextoButton = Dr.GetString(Dr.GetOrdinal("TextButton"));
                    Item.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Item.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Item.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ObtenerDetalleHomeBannerID(EM_HomeBanner Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdBanner };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_BannerDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdBanner = Dr.GetString(Dr.GetOrdinal("IdBanner"));
                    Datos.IdTipoBanner = Dr.GetInt32(Dr.GetOrdinal("IdTipoBanner"));
                    Datos.TextoInicial = Dr.GetString(Dr.GetOrdinal("TextoInicial"));
                    Datos.TextoPrincipal = Dr.GetString(Dr.GetOrdinal("TextoPrincipal"));
                    Datos.Comprar = Dr.GetBoolean(Dr.GetOrdinal("ComprarAhora"));
                    Datos.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Datos.TextoButton = Dr.GetString(Dr.GetOrdinal("TextButton"));
                    Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Datos.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Datos.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarHomeBanner(EM_HomeBanner Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdBanner, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_del_BannerHome", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EM_HomeBanner> ObtenerComboBannerTipo(EM_HomeBanner Datos)
        {
            try
            {
                List<EM_HomeBanner> Lista = new List<EM_HomeBanner>();
                EM_HomeBanner Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_TipoBanner");
                while (Dr.Read())
                {

                    Item = new EM_HomeBanner();
                    Item.IdTipoBanner = Dr.GetInt32(Dr.GetOrdinal("IdTipoBanner"));
                    Item.NombreTipoBanner = Dr.GetString(Dr.GetOrdinal("NombreTipoBanner"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
