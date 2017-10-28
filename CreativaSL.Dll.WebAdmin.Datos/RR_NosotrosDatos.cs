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
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_NosotrosQuienesSomos", Parametros);
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
                    Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("urlImagen"));
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
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen,
                    Datos.NombreImagen, Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdMiembroEquipo, Datos.NombreMostrar,
                    Datos.Puesto, Datos.PaginaWeb, Datos.IDUsuario};
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_NosotrosNuestroEquipo", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("ImagenGuardada"));
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
                    Item.NombreMostrar = Dr.GetString(Dr.GetOrdinal("nombreMostrar"));
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
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosEquipoTrabajoDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdMiembroEquipo = Dr.GetString(Dr.GetOrdinal("id_miembroEquipo"));
                    Datos.NombreMostrar = Dr.GetString(Dr.GetOrdinal("nombreMostrar"));
                    Datos.Puesto = Dr.GetString(Dr.GetOrdinal("puesto"));
                    Datos.IdImagen = Dr.GetString(Dr.GetOrdinal("id_imagen"));
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

        #region Iconos Css
        /// <summary>
        /// Obtiene la lista de los iconos 
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_Iconos> ObtenerIconos(RR_Iconos Datos)
        {
            try
            {
                List<RR_Iconos> Lista = new List<RR_Iconos>();
                RR_Iconos Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_CatIconCSS");
                while (Dr.Read())
                {
                    Item = new RR_Iconos();
                    Item.IdClassIcono = Dr.GetString(Dr.GetOrdinal(("id_classIcono")));
                    Item.CssClass = Dr.GetString(Dr.GetOrdinal("cssClass"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Nosotros Porque elegirnos

        /// <summary>
        /// Altas y cambios en la tabla  "notros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosPorqueElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdSeccion, Datos.Titulo, Datos.Texto, Datos.IdClaseIcono, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_AC_NosotrosElegirnos", Parametros);
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
        /// bajas en la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        public void BNosotrosPorqueElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdSeccion, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_NosotrosElegirnos", Parametros);
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
        /// obtiene la lista de los registros en la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosPorqueElegirnos> ObtenerCatalogoNosotrosElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            try
            {
                List<RR_NosotrosPorqueElegirnos> Lista = new List<RR_NosotrosPorqueElegirnos>();
                RR_NosotrosPorqueElegirnos Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosElegirnos");
                while (Dr.Read())
                {
                    Item = new RR_NosotrosPorqueElegirnos();
                    Item.IdSeccion = Dr.GetString(Dr.GetOrdinal("id_seccion"));
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
        /// obtiene el registro especifico por id de la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosElegirnosXID(RR_NosotrosPorqueElegirnos Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdSeccion };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosotrosElegirnosDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdSeccion = Dr.GetString(Dr.GetOrdinal("id_seccion"));
                    Datos.Titulo = Dr.GetString(Dr.GetOrdinal("titulo"));
                    Datos.Texto = Dr.GetString(Dr.GetOrdinal("texto"));
                    Datos.IdClaseIcono = Dr.GetString(Dr.GetOrdinal("id_claseIcono"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Redes sociales
        /// <summary>
        /// Obtiene las redes sociales disponibles para agregar
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_RedesSociales> ObtenerRedesSoc(RR_RedesSociales Datos)
        {
            try
            {
                List<RR_RedesSociales> Lista = new List<RR_RedesSociales>();
                RR_RedesSociales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_CatRedesSociales");
                while (Dr.Read())
                {
                    Item = new RR_RedesSociales();
                    Item.IdTipoRedSocial = Dr.GetInt32(Dr.GetOrdinal(("id_tipoRedSocial")));
                    Item.Descripcion = Dr.GetString(Dr.GetOrdinal("descripcion"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Nuestro Equipo Trabajo Redes Sociales
        /// <summary>
        /// Realiza altas y cambios de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IdMiembroxRedSocial, Datos.IdMiembroEquipo, Datos.IdTipoRedSocial, Datos.CuentaRedSocial, Datos.IDUsuario };
                Object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_AC_NosotrosRedesSociales", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if(Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Borra la red social del miembro en la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void BNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdMiembroxRedSocial, Datos.IDUsuario };
                Object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_NosotrosRedesSociales", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// obtiene todas las redes sociales del miembro de equipo de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_RedesSociales> ObtenerNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            try
            {
                object[] Parametros = {Datos.IdMiembroxRedSocial };
                List<RR_RedesSociales> Lista = new List<RR_RedesSociales>();
                RR_RedesSociales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosostrosRedesSociales");
                while (Dr.Read())
                {
                    Item = new RR_RedesSociales();
                    Item.IdMiembroxRedSocial = Dr.GetString(Dr.GetOrdinal("id_miembroXRedSocial"));
                    Item.NombreMostrar = Dr.GetString(Dr.GetOrdinal("descripcion"));
                    Lista.Add(Item);                    
                }
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// obtiene el detalle de la red social seleccionada por el id de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosRedesSocialesDetalle(RR_RedesSociales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdMiembroxRedSocial };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_NosostrosRedesSocialesDetalle", Parametros);
                while (Dr.Read())
                {
                    Datos.IdMiembroxRedSocial = Dr.GetString(Dr.GetOrdinal("id_miembroXRedSocial"));
                    Datos.IdMiembroEquipo = Dr.GetString(Dr.GetOrdinal("id_miembroEquipo"));
                    Datos.IdTipoRedSocial = Dr.GetInt32(Dr.GetOrdinal("id_tipoRedSocial"));
                    Datos.CuentaRedSocial = Dr.GetString(Dr.GetOrdinal("cuentaRedSocial"));
                    Datos.Completado = true;
                    break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Nosotros Datos Generales
        /// <summary>
        /// modifica el texto general de la pagina nosotros datos generales
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosDatosGenerales(RR_NosotrosDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = {Datos.NuevoRegistro, Datos.IdImagen, Datos.TextoAlternativo, Datos.TituloImagen, Datos.NumPosition, Datos.UrlImagen,
                    Datos.NombreImagen, Datos.Extencion, Datos.CambioImagen, Datos.IdPagina, Datos.IdTexto, Datos.Titulo, Datos.Titulo2, Datos.Titulo3, Datos.IDUsuario};
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_AC_NosotrosDatosGenerales", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.UrlImagen = Dr.GetString(Dr.GetOrdinal("ImagenGuardada"));
                    }
                    else if(Resultado == 2)
                    {
                        Datos.Completado = true;
                    }
                    Datos.Resultado = Resultado;
                    break;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarNosotrosDatosGenerales(RR_NosotrosDatosGenerales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTexto, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_NosotrosDatosGenerales", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// obtiene los textos de la pagina nosotros datos general
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosDatosGeneralesXID(RR_NosotrosDatosGenerales Datos)
        {
            try
            {
                DataSet Ds = SqlHelper.ExecuteDataset(Datos.Conexion, "RR_spCSLDB_get_NosotrosDatosGeneralesDetalle");
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