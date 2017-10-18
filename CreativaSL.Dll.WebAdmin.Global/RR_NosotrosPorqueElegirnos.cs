using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// Clase para los datos de la pagina porque elegirnos
    /// </summary>
    public class RR_NosotrosPorqueElegirnos
    {
        private string _IdSeccion;
        /// <summary>
        /// Identificador para el texto que se ingresará a la página 
        /// </summary>
        public string IdSeccion
        {
            get { return _IdSeccion; }
            set { _IdSeccion = value; }
        }

        private string _Titulo;
        /// <summary>
        /// Titulo de la página
        /// </summary>
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        private string _Texto;
        /// <summary>
        /// Texto de la página
        /// </summary>
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        private string _IdClaseIcono;
        /// <summary>
        /// Identificador para el tipo de icono a mostrar en la página
        /// </summary>
        public string IdClaseIcono
        {
            get { return _IdClaseIcono; }
            set { _IdClaseIcono = value; }
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
        /// 
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
