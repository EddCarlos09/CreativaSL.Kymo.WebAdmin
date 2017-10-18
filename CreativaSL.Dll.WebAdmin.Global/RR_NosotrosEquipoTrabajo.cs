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

        private string _IdImagen;
        /// <summary>
        /// Identificador para la ima
        /// </summary>
        public string IdImagen
        {
            get { return _IdImagen; }
            set { _IdImagen = value; }
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
