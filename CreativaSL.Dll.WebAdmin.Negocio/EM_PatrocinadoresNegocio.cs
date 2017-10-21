using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using CreativaSL.Dll.WebAdmin.Datos;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class EM_PatrocinadoresNegocio
    {
        /// <summary>
        /// El metodo que siver para enviar un operacion a la base da datos 
        /// </summary>
        /// <param name="Datos"></param>
        public void AC_Patrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                EM_PatrocinadoresDatos PD = new EM_PatrocinadoresDatos();
                PD.ACPatrocinadores(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtenemos el datos de los registro activo
        /// </summary>
        /// <param name="Datos">Objeto de datos conexion y Parametros</param>
        /// <returns></returns>
        public List<EM_Patrocinadores> ObtenerPatrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                EM_PatrocinadoresDatos PD = new EM_PatrocinadoresDatos();
                return PD.ObtenerPatrocinadoresHome(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Obtenemos los datos de un registro para modificarlos
        /// </summary>
        /// <param name="Datos">Enviamos y retornamos los datos</param>
        public void ObtenerDetallePatrocinadores(EM_Patrocinadores Datos)
        {
            try
            {
                EM_PatrocinadoresDatos PD = new EM_PatrocinadoresDatos();
                PD.ObtenerDetallePatrocinador(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Es para darle de baja a un patrocinador
        /// </summary>
        /// <param name="Datos">Se envia el id de lo que se va a eliminar</param>
        public void EliminarPatrocinador(EM_Patrocinadores Datos)
        {
            try
            {
                EM_PatrocinadoresDatos PD = new EM_PatrocinadoresDatos();
                PD.EliminarPatrocinadores(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
