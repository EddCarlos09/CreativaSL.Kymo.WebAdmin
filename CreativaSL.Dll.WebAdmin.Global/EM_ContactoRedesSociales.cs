using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// Es para saber que redes sociales tiene
    /// </summary>
    public class EM_ContactoRedesSociales
    {
        private string _IdRedSocial;
        /// <summary>
        /// Es para realizar una operacion
        /// </summary>
        public string IdRedSocial
        {
            get { return _IdRedSocial; }
            set { _IdRedSocial = value; }
        }
        private int _IdTipoRedSocial;
        /// <summary>
        /// Es para saber que tipo de red social estan registrando
        /// </summary>
        public int IdTipoRedSocial
        {
            get { return _IdTipoRedSocial; }
            set { _IdTipoRedSocial = value; }
        }
        private string _Cuenta;
        /// <summary>
        /// Es para saber que cuenta de redes sociales están registrando
        /// </summary>
        public string Cuenta
        {
            get { return _Cuenta; }
            set { _Cuenta = value; }
        }

        #region DatosDeControl
        private string _Conexion;
        /// <summary>
        /// Es la para asignar la cadena de conexion
        /// </summary>
        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }

        private int _Resultado;
        /// <summary>
        /// Es si la operacion que se realiza de vuelve un valor
        /// </summary>
        public int Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; }
        }

        private bool _Completado;
        /// <summary>
        /// Es para ver si la operacion que se realizo es correcta
        /// </summary>
        public bool Completado
        {
            get { return _Completado; }
            set { _Completado = value; }
        }

        private string _IDUsuario;
        /// <summary>
        /// Es para signar el usuario que se encuentra logeado en nuestro sistema
        /// </summary>
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

        private DataTable _TablaDatos;
        /// <summary>
        /// ???
        /// </summary>
        public DataTable TablaDatos
        {
            get { return _TablaDatos; }
            set { _TablaDatos = value; }
        }

        private bool _NuevoRegistro;
        /// <summary>
        /// Es para verificacion de un nuevo registro
        /// </summary>
        public bool NuevoRegistro
        {
            get { return _NuevoRegistro; }
            set { _NuevoRegistro = value; }
        }
        #endregion
    }
}
