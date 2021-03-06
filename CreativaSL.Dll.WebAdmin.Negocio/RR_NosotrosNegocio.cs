﻿using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_NosotrosNegocio
    {
        #region Nosotros Quienes Somos

        /// <summary>
        /// Realiza la peticion para hacer altas o cambios en la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.ACNosotrosQuienesSomos(Datos);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        /// <summary>
        /// Realiza la peticion para hacer bajas en la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.EliminarNosotrosQuienesSomos(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza la peticion para obtener los registros de la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosQuienesSomos> ObtenerCatalogoNosotrosQuienesSomos(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                return ND.ObtenerCatalogoNosotrosQuienesSomos(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza la peticion para obtener el registro especifico por ID de la tabla "Nosotros Quienes Somos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosQuienesSomosXID(RR_NosotrosQuienesSomos Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.ObtenerNosotrosQuienesSomosXID(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Nosotros Nuestro Equipo de Trabajo

        /// <summary>
        /// Realiza la peticion para hacer las altas o cambios en la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.ACNosotrosEquipoTrabajo(Datos);

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        /// <summary>
        /// Realiza la peticion para hacer bajas en la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.EliminarNosotrosEquipoTrabajo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Realiza la peticion para obtener los registros de la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosEquipoTrabajo> ObtenerCatalogoNosotrosEquipoTrabajo(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                return ND.ObtenerCatalogoNosotrosEquipoTrabajo(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Realiza la peticion para obtener el registro especifico por ID de la tabla "Nosotros Cat Equipo Trabajo"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosQuienesSomosXID(RR_NosotrosEquipoTrabajo Datos)
        {
            try
            {
                RR_NosotrosDatos ND = new RR_NosotrosDatos();
                ND.ObtenerNosotrosQuienesSomosXID(Datos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Iconos

        /// <summary>
        /// obtiene el id y el nombre de los iconos a utilizar
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_Iconos> ObtenerIconos(RR_Iconos Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            return ND.ObtenerIconos(Datos);
        }

        #endregion

        #region Nosotros Elegirnos
        /// <summary>
        ///  Realiza la peticion para hacer altas o cambios en la tabla "nosotros elegirnos" 
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosPorqueElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.ACNosotrosPorqueElegirnos(Datos);
        }

        /// <summary>
        /// Realiza la peticion para hacer bajas en la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        public void BNosotrosPorqueElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.BNosotrosPorqueElegirnos(Datos);
        }

        /// <summary>
        /// Realiza la peticion para obtener la lista de los registros en la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_NosotrosPorqueElegirnos> ObtenerCatalogoNosotrosElegirnos(RR_NosotrosPorqueElegirnos Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            return ND.ObtenerCatalogoNosotrosElegirnos(Datos);
        }

        /// <summary>
        /// Realiza la peticion para obtener el registro por ID de la tabla "nosotros elegirnos"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosElegirnosXID(RR_NosotrosPorqueElegirnos Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.ObtenerNosotrosElegirnosXID(Datos);
        }

        #endregion

        #region Redes Sociales
        /// <summary>
        /// realiza la peticion para obtener las redes sociales
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_RedesSociales> ObtenerRedesSoc(RR_RedesSociales Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            return ND.ObtenerRedesSoc(Datos);
        }

        /// <summary>
        /// Realiza la peticion para hacer altas y cambios en la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.ACNosotrosRedesSociales(Datos);
        }
        /// <summary>
        /// realiza la peticion para hacer las bajas de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void BNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.BNosotrosRedesSociales(Datos);
        }
        /// <summary>
        /// realiza las peticiones para obtener la lista de las redes sociales de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        /// <returns></returns>
        public List<RR_RedesSociales> ObtenerNosotrosRedesSociales(RR_RedesSociales Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            return ND.ObtenerNosotrosRedesSociales(Datos);
        }
        /// <summary>
        /// obtiene el deallte de la red social seleccionada de la tabla "Nosotros redes sociales miembros"
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosRedesSocialesDetalle(RR_RedesSociales Datos)
        {
            RR_NosotrosDatos ND = new RR_NosotrosDatos();
            ND.ObtenerNosotrosRedesSocialesDetalle(Datos);
        }
        #endregion

        #region Nosotros Datos Generales

        /// <summary>
        /// altas y bajas de textos en la pagina nosotros
        /// </summary>
        /// <param name="Datos"></param>
        public void ACNosotrosDatosGenerales(RR_NosotrosDatosGenerales Datos)
        {
            RR_NosotrosDatos NN = new RR_NosotrosDatos();
            NN.ACNosotrosDatosGenerales(Datos);
        }

        /// <summary>
        /// bajas de textos en la pagaina nosotros
        /// </summary>
        /// <param name="Datos"></param>
        public void EliminarNosotrosDatosGenerales(RR_NosotrosDatosGenerales Datos)
        {
            RR_NosotrosDatos NN = new RR_NosotrosDatos();
            NN.EliminarNosotrosDatosGenerales(Datos);
        }                

        /// <summary>
        /// obtiene los textos de la pagina nosotors datos generales
        /// </summary>
        /// <param name="Datos"></param>
        public void ObtenerNosotrosDatosGeneralesXID (RR_NosotrosDatosGenerales Datos)
        {
            RR_NosotrosDatos NN = new RR_NosotrosDatos();
            NN.ObtenerNosotrosDatosGeneralesXID(Datos);
        }

        #endregion
    }
}
