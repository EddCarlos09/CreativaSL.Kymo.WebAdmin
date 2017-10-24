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
    public class EM_ContactoRedesSocialesDatos
    {
        /// <summary>
        /// Es el encargado de dar de alta y baja 
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void AC_RedesSocialesContacto(EM_ContactoRedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdRedSocial, Datos.IdTipoRedSocial, Datos.Cuenta, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_AC_ContactoRedesSociales", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.IdRedSocial = Dr.GetString(Dr.GetOrdinal("IdRedSocial"));
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
        /// Es el metodo que obtiene todo los registro que se encuentren activo
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        /// <returns>Retorna todo los datos en una lista</returns>
        public List<EM_ContactoRedesSociales> ObtenerDatosContactoRedes(EM_ContactoRedesSociales Datos)
        {
            try
            {
                List<EM_ContactoRedesSociales> Lista = new List<EM_ContactoRedesSociales>();
                EM_ContactoRedesSociales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ContactoRedesSociales");
                while (Dr.Read())
                {
                    Item = new EM_ContactoRedesSociales();
                    Item.IdRedSocial = Dr.GetString(Dr.GetOrdinal(("IdRedSocial")));
                    Item.IdTipoRedSocial = Dr.GetInt32(Dr.GetOrdinal("IdTipoRedSocial"));
                    Item.Cuenta = Dr.GetString(Dr.GetOrdinal("Cuenta"));
                    Item.NombreRedSocial = Dr.GetString(Dr.GetOrdinal("TipoRed"));
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
        /// Es el encardo de obterne los datos de un registro para modificar
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void ObtenerDetalleRedesSocialesContacto(EM_ContactoRedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdRedSocial };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ContactoRedesSocialesXID", Parametros);
                while (Dr.Read())
                {
                    Datos.IdTipoRedSocial = Dr.GetInt32(Dr.GetOrdinal("IdTipoRedSocial"));
                    Datos.Cuenta = Dr.GetString(Dr.GetOrdinal("Cuenta"));
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
        /// Es el encargado de obtener el combo de tipo redes sociales 
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        /// <returns>Retorna los dato en una lista</returns>
        public List<EM_ContactoRedesSociales> ObtenerComboTipoRedeSociale(EM_ContactoRedesSociales Datos)
        {
            try
            {
                List<EM_ContactoRedesSociales> Lista = new List<EM_ContactoRedesSociales>();
                EM_ContactoRedesSociales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "EM_spCSLDB_get_ComboRedesSociales");
                while (Dr.Read())
                {
                    Item = new EM_ContactoRedesSociales();
                    Item.IdTipoRedSocial = Dr.GetInt32(Dr.GetOrdinal("IdTipoRedSocial"));
                    Item.NombreRedSocial = Dr.GetString(Dr.GetOrdinal("TipoRedSocial"));
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
        /// El metodo es que da de baja a un registro
        /// </summary>
        /// <param name="Datos">Se envia la cadena de conexion y los parametro que recibe</param>
        public void EliminarRedeSocialContactoXID(EM_ContactoRedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdRedSocial, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "EM_spCSLDB_del_ContactoRedesSociales", Parametros);
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
