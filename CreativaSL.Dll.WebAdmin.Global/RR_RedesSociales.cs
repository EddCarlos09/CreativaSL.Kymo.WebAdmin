using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    public class RR_RedesSociales
    {
        /// <summary>
        /// identificador del tipo de  la red social
        /// </summary>
        private int _IdTipoRedSocial;
        public int IdTipoRedSocial
        {
            get { return _IdTipoRedSocial; }
            set { _IdTipoRedSocial = value; }
        }

        /// <summary>
        /// identificador de la red social
        /// </summary>
        private string _IdMiembroxRedSocial;
        public string IdMiembroxRedSocial
        {
            get { return _IdMiembroxRedSocial; }
            set { _IdMiembroxRedSocial = value; }
        }

        /// <summary>
        /// identificador del miembro de equipo
        /// </summary>
        private string _IdMiembroEquipo;
        public string IdMiembroEquipo
        {
            get { return _IdMiembroEquipo; }
            set { _IdMiembroEquipo = value; }
        }

        /// <summary>
        /// nombre de la cuenta de la red social
        /// </summary>
        private string _CuentaRedSocial;
        public string CuentaRedSocial
        {
            get { return _CuentaRedSocial; }
            set { _CuentaRedSocial = value; }
        }
        
        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        private string _NombreMostrar;
        public string NombreMostrar
        {
            get { return _NombreMostrar; }
            set { _NombreMostrar = value; }
        }
        
        private string _UrlBase;
        public string UrlBase
        {
            get { return _UrlBase; }
            set { _UrlBase = value; }
        }

        private string _Class;
        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }

        private string _FaClass;
        public string FaClass
        {
            get { return _FaClass; }
            set { _FaClass = value; }
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
