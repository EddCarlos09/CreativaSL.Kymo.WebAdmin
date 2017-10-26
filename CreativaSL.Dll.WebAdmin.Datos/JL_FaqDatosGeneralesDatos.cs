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
    public class JL_FaqDatosGeneralesDatos
    {
        public void AC_ImagenFaq(JL_FaqDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdImagen, Datos.TituloPagina, Datos.TextoAlternativo, Datos.TituloImagen, Datos.IdPagina,
                   Datos.UrlImagen, Datos.Extencion, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "JL_spCSLDB_AC_DatosGenerales", Parametros);
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
        public void ObtenerDatosGeneralesFaq(JL_FaqDatosGenerales Datos)
        {
            try
            {

                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "JL_spCSLDB_get_DatosGeneralesFaq");
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
    }
}
