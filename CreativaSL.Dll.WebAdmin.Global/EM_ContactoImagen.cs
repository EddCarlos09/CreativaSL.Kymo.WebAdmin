using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// Es el para guardar imagen de contacto
    /// </summary>
    public class EM_ContactoImagen
    {
        private string _IdImagen;
        /// <summary>
        /// Es para realizar una operacion
        /// </summary>
        public string IdImagen
        {
            get { return _IdImagen; }
            set { _IdImagen = value; }
        }

        private string _TextoAlternativo;
        /// <summary>
        /// El testo es referenta la imagen para seo
        /// </summary>
        public string TextoAlternativo
        {
            get { return _TextoAlternativo; }
            set { _TextoAlternativo = value; }
        }
        private string _TituloImagen;
        /// <summary>
        /// El titulo de la imagen para seo
        /// </summary>
        public string TituloImagen
        {
            get { return _TituloImagen; }
            set { _TituloImagen = value; }
        }
        private string _NombreImagen;

        public string NombreImagen
        {
            get { return _NombreImagen; }
            set { _NombreImagen = value; }
        }

        private string _UrlImagen;
        /// <summary>
        /// El la ruta donde se guardara la imagen
        /// </summary>
        public string UrlImagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
        }
        private int _NumPosition;
        /// <summary>
        /// La posicion del registro para identificar en la pagina web
        /// </summary>
        public int NumPosition
        {
            get { return _NumPosition; }
            set { _NumPosition = value; }
        }
        private int _IdPagina;
        /// <summary>
        /// Es el numero de pagina
        /// </summary>
        public int IdPagina
        {
            get { return _IdPagina; }
            set { _IdPagina = value; }
        }
        private string _Extencion;
        /// <summary>
        /// Es la expencion
        /// </summary>
        public string Extencion
        {
            get { return _Extencion; }
            set { _Extencion = value; }
        }

        private bool _CambiarImagen;

        public bool CambiarImagen
        {
            get { return _CambiarImagen; }
            set { _CambiarImagen = value; }
        }

        private string _TituloContacto;
        /// <summary>
        /// Es el encambezado de nuestra pagina
        /// </summary>
        public string TituloContacto
        {
            get { return _TituloContacto; }
            set { _TituloContacto = value; }
        }
        private string _TextoContacto;
        /// <summary>
        /// Es referecia a los texto que se muestra en nuestra pagina
        /// </summary>
        public string TextoContacto
        {
            get { return _TextoContacto; }
            set { _TextoContacto = value; }
        }
        private string _TituloPagina;

        public string TituloPagina
        {
            get { return _TituloPagina; }
            set { _TituloPagina = value; }
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

        private DataTable _TablaTexto;

        public DataTable TableTexto
        {
            get { return _TablaTexto; }
            set { _TablaTexto = value; }
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
