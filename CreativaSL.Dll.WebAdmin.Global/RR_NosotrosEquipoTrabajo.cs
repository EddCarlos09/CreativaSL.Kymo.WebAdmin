using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    public class RR_NosotrosEquipoTrabajo
    {
        private string _IdMiembroEquipo;
        /// <summary>
        /// Identificador para el miembro de equipo de trabajo
        /// </summary>
        public string IdMiembroEquipo
        {
            get { return _IdMiembroEquipo; }
            set { _IdMiembroEquipo = value; }
        }

        private string _NombreMostrar;
        /// <summary>
        /// Nombre del miembro de equipo de trabajo
        /// </summary>
        public string NombreMostrar
        {
            get { return _NombreMostrar; }
            set { _NombreMostrar = value; }
        }

        private string _Puesto;
        /// <summary>
        /// Puesto del miembro de equipo de trabajo
        /// </summary>
        public string Puesto
        {
            get { return _Puesto; }
            set { _Puesto = value; }
        }

        private bool _PaginaWeb;
        /// <summary>
        /// Saber si el miembro de equipo de trabajo tiene página web
        /// </summary>
        public bool PaginaWeb
        {
            get { return _PaginaWeb; }
            set { _PaginaWeb = value; }
        }

        /// <summary>
        /// identificador del tipo de pagina que es
        /// </summary>
        private int _IdPagina;
        public int IdPagina
        {
            get { return _IdPagina; }
            set { _IdPagina = value; }
        }

        #region Datos para las imagenes
        private string _IdImagen;
        /// <summary>
        /// identificador de la imagen agregada
        /// </summary>
        public string IdImagen
        {
            get { return _IdImagen; }
            set { _IdImagen = value; }
        }

        private string _TextoAlternativo;
        /// <summary>
        /// texto alternativo de la imagen
        /// </summary>
        public string TextoAlternativo
        {
            get { return _TextoAlternativo; }
            set { _TextoAlternativo = value; }
        }

        private string _TituloImagen;
        /// <summary>
        /// Titulo de la imagen
        /// </summary>
        public string TituloImagen
        {
            get { return _TituloImagen; }
            set { _TituloImagen = value; }
        }

        private string _NombreImagen;
        /// <summary>
        /// Nombre de la imagen
        /// </summary>
        public string NombreImagen
        {
            get { return _NombreImagen; }
            set { _NombreImagen = value; }
        }

        private string _Extencion;
        /// <summary>
        /// tipo de archivo que es la imagen
        /// </summary>
        public string Extencion
        {
            get { return _Extencion; }
            set { _Extencion = value; }
        }

        private bool _CambioImagen;
        /// <summary>
        /// Cambio de imagen
        /// </summary>
        public bool CambioImagen
        {
            get { return _CambioImagen; }
            set { _CambioImagen = value; }
        }

        private string _UrlImagen;
        /// <summary>
        /// Url de la imagen subida
        /// </summary>
        public string UrlImagen
        {
            get { return _UrlImagen; }
            set { _UrlImagen = value; }
        }

        /// <summary>
        /// Numero de posicion de la imagen en la pagina
        /// </summary>
        private int _NumPosition;
        public int NumPosition
        {
            get { return _NumPosition; }
            set { _NumPosition = value; }
        }
        
        #endregion
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
