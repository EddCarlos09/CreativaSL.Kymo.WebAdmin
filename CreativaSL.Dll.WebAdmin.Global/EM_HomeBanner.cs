using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    public class EM_HomeBanner
    {
        private string _IdBanner;
        /// <summary>
        /// Sirver para realizar una operacion de identificador
        /// </summary>
        public string IdBanner
        {
            get { return _IdBanner; }
            set { _IdBanner = value; }
        }
        private int _IdTipoBanner;
        /// <summary>
        /// Es un identificador por si hay mas de un banner
        /// </summary>
        public int IdTipoBanner
        {
            get { return _IdTipoBanner; }
            set { _IdTipoBanner = value; }
        }
        private string _TextoInicial;
        /// <summary>
        /// Es el titulo de nuestro banner
        /// </summary>

        private string _NombreTipoBanner;

        public string NombreTipoBanner
        {
            get { return _NombreTipoBanner; }
            set { _NombreTipoBanner = value; }
        }

        public string TextoInicial
        {
            get { return _TextoInicial; }
            set { _TextoInicial = value; }
        }

        private string _TextoPrincipal;
        /// <summary>
        /// Es la descripcion de nuestro banner 
        /// </summary>
        public string TextoPrincipal
        {
            get { return _TextoPrincipal; }
            set { _TextoPrincipal = value; }
        }
        private bool _Comprar;
        /// <summary>
        /// Es para saber si el banner va a llevar un boton
        /// </summary>
        public bool Comprar
        {
            get { return _Comprar; }
            set { _Comprar = value; }
        }
        private string _UrlDestino;
        /// <summary>
        /// La es si se activa el boton comprar se pedira un url del boton
        /// </summary>
        public string UrlDestino
        {
            get { return _UrlDestino; }
            set { _UrlDestino = value; }
        }

        private string _TextoButton;
        /// <summary>
        /// Es si va a llevar btn se tiene que pedir el nombre de el btn
        /// </summary>
        public string TextoButton
        {
            get { return _TextoButton; }
            set { _TextoButton = value; }
        }
        private string _UrlImagen;
        /// <summary>
        /// Es la url completa de ruta donde se guarda la imagen
        /// </summary>
        public string UrlImagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
        }

        private string _Alt;
        /// <summary>
        /// Es el texto alternativo de la imagen para seo
        /// </summary>
        public string Alt
        {
            get { return _Alt; }
            set { _Alt = value; }
        }
        private string _Title;
        /// <summary>
        /// El es titulo de la imagen en seo
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        private string _NombreImagen;
        /// <summary>
        /// este nombte tiene que ir sin acentos ni espacio. Los espacios se remplase por - medio 
        /// </summary>
        public string NombreImagen
        {
            get { return _NombreImagen; }
            set { _NombreImagen = value; }
        }
        private bool _CambiarImagen;

        public bool CambiarImagen
        {
            get { return _CambiarImagen; }
            set { _CambiarImagen = value; }
        }
        private string _Extencion;

        public string Extencion
        {
            get { return _Extencion; }
            set { _Extencion = value; }
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
