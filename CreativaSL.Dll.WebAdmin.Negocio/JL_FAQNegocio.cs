using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class JL_FAQNegocio
    {
        public void ACPreguntas(JL_Pregunta Datos)
        {
            try
            {
                JL_FAQDatos datos = new JL_FAQDatos();
                datos.ACPreguntas(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarPreguntaXID(JL_Pregunta Datos)
        {
            try
            {
                JL_FAQDatos datos = new JL_FAQDatos();
                datos.EliminarPreguntaXID(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<JL_Pregunta> ObtenerPreguntas(JL_Pregunta Datos)
        {
            try
            {
                JL_FAQDatos datos = new JL_FAQDatos();
                return datos.ObtenerPreguntas(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public void ObtenerPreguntasXID(JL_Pregunta Datos)
        {
            try
            {
                JL_FAQDatos datos = new JL_FAQDatos();
                datos.ObtenerPreguntasXID(Datos);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
