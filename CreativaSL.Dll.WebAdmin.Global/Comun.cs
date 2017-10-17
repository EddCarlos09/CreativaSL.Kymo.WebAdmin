using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    public static class Comun
    {
        private static string _Conexion;
        /// <summary>
        /// Conexion la el acceso a la base de datos
        /// </summary>
        public static string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        
        private static string _IDUsuario;
        /// <summary>
        /// IDUsuario es el usuario que se encuentra logeado en nuestro sistema
        /// </summary>
        public static string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }

    }
}
