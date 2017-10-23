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
    public class RR_TerminosCondicionesDatos
    {
        #region Terminos y Condiciones Datos Generales

        public void ACTerminosDatosGenerales(RR_TerminosCondiciones Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen, Datos.NombreImagen,
                Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdTexto, Datos.Texto, Datos.Texto2, Datos.IDUsuario};
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_TerminosGeneral", Parametros);
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

        public void ObtenerTerminosCondicionesGeneralesXID(RR_TerminosCondiciones Datos)
        {
            try
            {
                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_get_TerminosDatosGeneralesDetalle");
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

        #region Terminos y Condiciones Textos

        public void ACTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdTermino, Datos.TituloTermino, Datos.TextoTermino, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_Terminos", Parametros);
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
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void EliminarTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTermino, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_Terminos", Parametros);
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

        public List<RR_TerminosCondiciones> ObtenerTerminosCondiciones(RR_TerminosCondiciones Datos)
        {
            try
            {
                List<RR_TerminosCondiciones> Lista = new List<RR_TerminosCondiciones>();
                RR_TerminosCondiciones Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_Terminos");
                while (Dr.Read())
                {
                    Item = new RR_TerminosCondiciones();
                    Item.IdTermino = Dr.GetString(Dr.GetOrdinal(("id_termino")));
                    Item.TituloTermino = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerTerminosCondicionesXID(RR_TerminosCondiciones Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTermino };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_AvisosPrivacidadDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdTermino = Dr.GetString(Dr.GetOrdinal("id_termino"));
                    Datos.TituloTermino = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Datos.TextoTermino = Dr.GetString(Dr.GetOrdinal("texto"));
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
