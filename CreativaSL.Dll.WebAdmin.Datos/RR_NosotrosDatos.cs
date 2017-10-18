using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class RR_NosotrosDatos
    {
        /// <summary>
        /// Altas y cambios en la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NombreImagen, Datos.UrlImagen,
                Datos.NumPosition, Datos.IdPagina, Datos.IdSeccion, Datos.Titulo, Datos.TextoHtml, Datos.IDUsuario};
                Object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_AC_NosotrosQuienesSomos", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if(Resultado == 1)
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

        /// <summary>
        /// Bajas en la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdSeccion, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_NosotrosQuienesSomos", Parametros);
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

        /// <summary>
        /// Obtiene la lista de todos los textos de la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosQuienesSomos> ObtenerCatalogoNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                List<RR_NosotrosQuienesSomos> Lista = new List<RR_NosotrosQuienesSomos>();
                RR_NosotrosQuienesSomos Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_InfoCandidatos");
                while (Dr.Read())
                {
                    Item = new RR_NosotrosQuienesSomos();
                    Item.IdSeccion = Dr.GetString(Dr.GetOrdinal(("id_seccion")));
                    Item.Titulo = Dr.GetString(Dr.GetOrdinal("titulo"));                    
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
