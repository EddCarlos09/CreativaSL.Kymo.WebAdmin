using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class RR_AvisoPrivacidadDatos
    {
        #region Aviso de Privacidad Datos Generales

        public void ACAvisoPrivacidadDatosGenerales(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen, Datos.NombreImagen,
                Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdTexto, Datos.Texto, Datos.Texto2, Datos.IDUsuario};
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_AvisoPrivacidadGeneral", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("ImagenGuardada"));
                    }
                    if (Resultado == 2)
                    {
                        Datos.Completado = true;
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

        public void ObtenerAvisoPrivacidadDatosGeneralesXID(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_get_AvisoPrivacidadDatosGeneralesDetalle");
                if (Ds != null)
                {
                    if (Ds.Tables.Count == 2)
                    {
                        Datos.Completado = true;
                        Datos.TablaDatos = Ds.Tables[0];
                        Datos.TableTexto = Ds.Tables[1];

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Aviso de Privacidad Textos

        public void ACAvisoPrivacidad(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdAviso, Datos.TituloAviso, Datos.TextoAviso, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_AvisoPrivacidad", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                    }
                    Datos.Resultado = Resultado;
                    break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarAvisoPrivacidad(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdAviso, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_AvisoPrivacidad", Parametros);
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

        public List<RR_AvisoPrivacidadDatosGenerales> ObtenerAvisosPrivacidad(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                List<RR_AvisoPrivacidadDatosGenerales> Lista = new List<RR_AvisoPrivacidadDatosGenerales>();
                RR_AvisoPrivacidadDatosGenerales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_AvisosPrivacidad");
                while (Dr.Read())
                {
                    Item = new RR_AvisoPrivacidadDatosGenerales();
                    Item.IdAviso = Dr.GetString(Dr.GetOrdinal(("id_seccion")));
                    Item.TituloAviso = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerAvisoPrivacidadXID(RR_AvisoPrivacidadDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdAviso };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_AvisosPrivacidadDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdAviso = Dr.GetString(Dr.GetOrdinal("id_aviso"));
                    Datos.TituloAviso = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Datos.TextoAviso = Dr.GetString(Dr.GetOrdinal("texto"));                    
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
