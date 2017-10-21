using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class EM_PatrocinadoresDatos
    {
        /// <summary>
        /// En metodo para realizar la conexion y hacer la accion
        /// </summary>
        /// <param name="Datos">Son todo los parametos que recibe el metodo</param>
        public void ACPatrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdPatrocinadores, Datos.NombreCompleto, Datos.Alt, Datos.Title, Datos.NombreImagen, Datos.UrlImagen, Datos.UrlDestino, Datos.Extencion, Datos.CambiarImagen, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_AC_Home_Patrocinadores", Parametros);
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
        /// <summary>
        /// Es el que no va a dar la lista de todo los patrocinadores
        /// </summary>
        /// <param name="Datos">Objeto de datos cadena de conexion y parametros</param>
        /// <returns>Retorna la lista obtenida</returns>
        public List<EM_Patrocinadores> ObtenerPatrocinadoresHome(EM_Patrocinadores Datos)
        {
            try
            {
                List<EM_Patrocinadores> Lista = new List<EM_Patrocinadores>();
                EM_Patrocinadores Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_Patrocinador");
                while (Dr.Read())
                {

                    Item = new EM_Patrocinadores();
                    Item.IdPatrocinadores = Dr.GetString(Dr.GetOrdinal("IdPatrocinador"));
                    Item.NombreCompleto = Dr.GetString(Dr.GetOrdinal("NombreCompleto"));
                    Item.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Item.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Item.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Item.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtenemos el detalle de el registro que se va a modificar
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerDetallePatrocinador(EM_Patrocinadores Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdPatrocinadores };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_Home_PatrocinadorDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.NombreCompleto = Dr.GetString(Dr.GetOrdinal("NombreCompleto"));
                    Datos.Alt = Dr.GetString(Dr.GetOrdinal("TextoAlternativo"));
                    Datos.Title = Dr.GetString(Dr.GetOrdinal("Titulo"));
                    Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("UrlImagen"));
                    Datos.UrlDestino = Dr.GetString(Dr.GetOrdinal("UrlDestino"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Ese elimina el registro seleccionado 
        /// </summary>
        /// <param name="Datos">Objeto con la cadena de conexion y parametros</param>
        public void EliminarPatrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdPatrocinadores, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_del_Home_Patrocinador", Parametros);
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
    }
}
