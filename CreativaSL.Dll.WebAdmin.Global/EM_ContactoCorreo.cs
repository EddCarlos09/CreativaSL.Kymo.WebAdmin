using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// Es para el envio de mensaje de la pagina web se guardan los datos que se envian.
    /// </summary>
    public class EM_ContactoCorreo
    {
        private string _IdCorreo;
        /// <summary>
        /// Es el identificador del registro para realizar la operacion
        /// </summary>
        public string IdCorreo
        {
            get { return _IdCorreo; }
            set { _IdCorreo = value; }
        }

        private string _Nombre;
        /// <summary>
        /// El nombre de quien no esta contactando en la pagina web
        /// </summary>
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Correo;
        /// <summary>
        /// El correo de quién nos contacto
        /// </summary>
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }
        private string _Telefono;
        /// <summary>
        /// El telefono de nuestro contacto
        /// </summary>
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _Direccion;
        /// <summary>
        /// Direccion de donde nos estan contactando
        /// </summary>
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Mensaje;
        /// <summary>
        /// Es referenta nuestro que nos estan escribiendo en contacto
        /// </summary>
        public string Mensaje
        {
            get { return _Mensaje; }
            set { _Mensaje = value; }
        }
        private DateTime _FechaHora;
        /// <summary>
        /// La fecha es para saber a que hora y cuendo lo envio
        /// </summary>
        public DateTime FechaHora
        {
            get { return _FechaHora; }
            set { _FechaHora = value; }
        }
        private bool _Leido;
        /// <summary>
        /// Es para ver si ya vieron nuestro mensaje enviado
        /// </summary>
        public bool Leido
        {
            get { return _Leido; }
            set { _Leido = value; }
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
