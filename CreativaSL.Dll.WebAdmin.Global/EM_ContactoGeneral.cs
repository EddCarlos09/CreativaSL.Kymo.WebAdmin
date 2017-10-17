using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Global
{
    /// <summary>
    /// La clase para la pagina de contacto
    /// </summary>
    public class EM_ContactoGeneral
    {

        private string _IdContacto;
        /// <summary>
        /// IdContacto es para realizar un acción
        /// </summary>
        public string IdContacto
        {
            get { return _IdContacto; }
            set { _IdContacto = value; }
        }

        private double _Latitud;
        /// <summary>
        /// Latitud es la coordenadas geograficas de una dirección
        /// </summary>
        public double Latitud
        {
            get { return _Latitud; }
            set { _Latitud = value; }
        }

        private double _Longitud;
        /// <summary>
        /// Longitud es coordenada geografica de una dirección
        /// </summary>
        public double Longitud
        {
            get { return _Longitud; }
            set { _Longitud = value; }
        }

        private string _Telefonos;
        /// <summary>
        /// Telefono registra todos los número de la empresa
        /// </summary>
        public string Telefonos
        {
            get { return _Telefonos; }
            set { _Telefonos = value; }
        }

        private string _Correo;
        /// <summary>
        /// El Correo electrónico de la empresa
        /// </summary>
        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        private string _Direccion;
        /// <summary>
        /// La dirección el la ubicación de la empresa
        /// </summary>
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        private string _CorreoDestinatario;
        /// <summary>
        /// EL correo a donde se va enviar el contacto
        /// </summary>
        public string CorreoDestinatario
        {
            get { return _CorreoDestinatario; }
            set { _CorreoDestinatario = value; }
        }

        private int _Puerto;
        /// <summary>
        /// El número de puerto que usa el servidor de correo entrante. Para hotmail el 587 ó si no ver la forma de abrir el puerto.Para gmail el 25
        /// </summary>
        public int Puerto
        {
            get { return _Puerto; }
            set { _Puerto = value; }
        }

        private bool _EnableSSL;
        /// <summary>
        /// La propiedad EnableSsl especifica si SSL se usa para acceder al servidor de correo SMTP especificado.
        /// </summary>
        public bool EnableSSL
        {
            get { return _EnableSSL; }
            set { _EnableSSL = value; }
        }
        private bool _HTMLText;
        /// <summary>
        /// Para que interprete el HTML que se va enviar y no lo reciba como cadena.
        /// </summary>
        public bool HTMLText
        {
            get { return _HTMLText; }
            set { _HTMLText = value; }
        }

        private string _HostText;
        /// <summary>
        /// Un servidor de correo es un equipo que envía 
        /// </summary>
        public string HostText
        {
            get { return _HostText; }
            set { _HostText = value; }
        }

    }
}
