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
        #region Nosotros Quienes Somos

        /// <summary>
        /// Altas y cambios en la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen, Datos.NombreImagen,
                Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdSeccion, Datos.Titulo, Datos.TextoHtml, Datos.IDUsuario};
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
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosQuienesSomos");
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

        /// <summary>
        /// Obtiene el detalle de el registro solicitado por el ID de la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosQuienesSomosXID(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdSeccion };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosQuienesSomosDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdSeccion = Dr.GetString(Dr.GetOrdinal("id_seccion"));
                    Datos.Titulo = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Datos.TextoHtml = Dr.GetString(Dr.GetOrdinal("textoHTML"));
                    Datos.IdImagen = Dr.GetString(Dr.GetOrdinal("id_imagen"));
                    Datos.TextoAlternativo = Dr.GetString(Dr.GetOrdinal("textoAlternativo"));
                    Datos.TituloImagen = Dr.GetString(Dr.GetOrdinal("tituloImagen"));
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


        #region Nosotros Equipo de Trabajo
        /// <summary>
        /// Altas y cambios en la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.IDUsuario};
                Object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "", Parametros);
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
        /// Bajas en la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdMiembroEquipo, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_NosotrosNuestroEquipo", Parametros);
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
        /// Obtiene la lista de todos los textos de la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosEquipoTrabajo> ObtenerCatalogoNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                List<RR_NosotrosEquipoTrabajo> Lista = new List<RR_NosotrosEquipoTrabajo>();
                RR_NosotrosEquipoTrabajo Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosEquipoTrabajo");
                while (Dr.Read())
                {
                    Item = new RR_NosotrosEquipoTrabajo();
                    Item.IdMiembroEquipo = Dr.GetString(Dr.GetOrdinal(("id_miembroEquipo")));
                    Item.NombreMostrar = Dr.GetString(Dr.GetOrdinal("nombreMostar"));
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
        /// Obtiene el detalle de el registro solicitado por el ID de la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosQuienesSomosXID(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdMiembroEquipo };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "", Parametros);
                while (Dr.Read())
                {
                    Datos.IdMiembroEquipo = Dr.GetString(Dr.GetOrdinal("id_miembroEquipo"));
                    Datos.NombreMostrar = Dr.GetString(Dr.GetOrdinal("nombreMostrar"));
                    Datos.Puesto = Dr.GetString(Dr.GetOrdinal("puesto"));
                    Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("urlImagen"));
                    Datos.TextoAlternativo = Dr.GetString(Dr.GetOrdinal("textoAlternativo"));
                    Datos.TituloImagen = Dr.GetString(Dr.GetOrdinal("tituloImagen"));
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