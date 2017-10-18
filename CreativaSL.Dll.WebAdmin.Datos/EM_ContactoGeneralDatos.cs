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
    public class EM_ContactoGeneralDatos
    {
        /// <summary>
        /// Este metodo es el encargado de eviarlo al base de datos altas y modificaciones
        /// </summary>
        /// <param name="Datos">Son los datos que recibe</param>
        public void AC_DatosDeContacto(EM_ContactoGeneral Datos)
        {
            try
            {
                object[] Parametros = { Datos.Direccion, Datos.Latitud, Datos.Longitud, Datos.Telefonos, Datos.Correo, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_AC_ContactoDatos", Parametros);
                if (Result != null)
                {
                    int Resultado = 0;
                    int.TryParse(Result.ToString(), out Resultado);
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                    }
                    Datos.Resultado = Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Es el encargado de obterner los datos de la base
        /// </summary>
        /// <param name="Datos">son la lista de los todo a recibir</param>
        public void ObtenerDatosContacto(EM_ContactoGeneral Datos)
        {
            try
            {
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_DatosContacto");
                while (Dr.Read())
                {
                    Datos.Latitud = Dr.GetDouble(Dr.GetOrdinal("Latitud"));
                    Datos.Longitud = Dr.GetDouble(Dr.GetOrdinal("Longitud"));
                    Datos.Telefonos = Dr.GetString(Dr.GetOrdinal("Telefonos"));
                    Datos.Correo = Dr.GetString(Dr.GetOrdinal("Correo"));
                    Datos.Direccion = Dr.GetString(Dr.GetOrdinal("Direccion"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
