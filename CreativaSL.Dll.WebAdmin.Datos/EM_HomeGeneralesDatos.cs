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
    public class EM_HomeGeneralesDatos
    {
        /// <summary>
        /// Metodo que se encarga de dar de alta y modificacion de imagene
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void AC_ImagenHome(EM_HomeGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.IdPagina, Datos.Extencion, Datos.UrlImagen, Datos.CambiarImagen, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_AC_HomeGenerales", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagenGuarda"));
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
        /// Es el metodo que se encarga de obtener los datos del registro
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void ObtenerImagenHome(EM_HomeGenerales Datos)
        {
            try
            {
                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "EM_spCSLDB_get_HomeGenerales");
                if (Ds != null)
                {
                    if (Ds.Tables.Count == 1)
                    {
                        Datos.Completado = true;
                        Datos.TablaDatos = Ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
