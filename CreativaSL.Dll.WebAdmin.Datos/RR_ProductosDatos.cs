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
    public class RR_ProductosDatos
    {
        #region Terminos y Condiciones Datos Generales
        /// <summary>
        /// modifica los textos generales de la pagina terminos y condiciones 
        /// </summary>
        /// <param name="Datos"></param>
        public void ACProductosDatosGenerales(RR_Productos Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen, Datos.NombreImagen,
                Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdTexto, Datos.Texto, Datos.Texto2, Datos.IDUsuario};
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_ProductosGeneral", Parametros);
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
        /// <summary>
        /// obtiene los textos generales de la pagina terminos y condiciones
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerProductosGeneralesXID(RR_Productos Datos)
        {
            try
            {
                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_get_ProductosDatosGeneralesDetalle");
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
    }
}
