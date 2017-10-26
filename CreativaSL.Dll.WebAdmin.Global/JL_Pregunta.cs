using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// La clase para la pagina de Faq
    /// </summary>
    public class JL_Pregunta
    {
        private string _IDPregunta;
        /// <summary>
        /// IDPregunta es para realizar una accion
        /// </summary>
        public string IDPregunta
        {
            get { return _IDPregunta; }
            set { _IDPregunta = value; }
        }
        private string _Pregunta;

        public string Pregunta
        {
            get { return _Pregunta; }
            set { _Pregunta = value; }
        }
        private string _Respuesta;

        public string Respuesta
        {
            get { return _Respuesta; }
            set { _Respuesta = value; }
        }   
        private int _Orden;

        public int Orden
        {
            get { return _Orden; }
            set { _Orden = value; }
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
