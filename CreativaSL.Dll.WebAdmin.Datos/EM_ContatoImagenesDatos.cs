using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using System.Data;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class EM_ContatoImagenesDatos
    {
        /// <summary>
        /// Metodo que se encarga de dar de alta y modificacion de imagene
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void AC_ImagenContacto(EM_ContactoImagen Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdImagen, Datos.TituloPagina, Datos.TextoAlternativo, Datos.TituloImagen, Datos.IdPagina,
                    Datos.TituloContacto, Datos.TextoContacto, Datos.Extencion, Datos.UrlImagen, Datos.CambiarImagen, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_AC_ContactoImagen", Parametros);
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
        public void ObtenerImagenContacto(EM_ContactoImagen Datos)
        {
            try
            {

                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "EM_spCSLDB_get_ContactoImages");
                if(Ds != null )
                { 
                    if(Ds.Tables.Count == 2)
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
