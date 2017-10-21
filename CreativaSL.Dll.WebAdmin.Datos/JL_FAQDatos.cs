using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class JL_FAQDatos
    {
        public void ACPreguntas(JL_Pregunta Datos)
        {
            try
            {
                object[] Parametros = { Datos.NuevoRegistro, Datos.IDPregunta, Datos.Pregunta, Datos.Respuesta, Datos.Orden, Datos.IDUsuario };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "JL_spCSLDB_AC_Pregunta", Parametros);
                while (Dr.Read())
                {
                    int Resultado = Dr.GetInt32(Dr.GetOrdinal("Resultado"));
                    if (Resultado == 1)
                    {
                        Datos.Completado = true;
                        Datos.IDPregunta = Dr.GetString(Dr.GetOrdinal("IDPregunta"));
                    }
                    Datos.Resultado = Resultado;
                    break;
                }
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
                object[] Parametros = { Datos.IDPregunta, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "JL_spCSLDB_B_Pregunta", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                    {
                        Datos.Completado = true;
                    }
                    Datos.Resultado = Resultado;       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<JL_Pregunta> ObtenerPreguntas(JL_Pregunta Datos)
        {
            List<JL_Pregunta> Lista = new List<JL_Pregunta>();
            JL_Pregunta Item;
            SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "JL_spCSLDB_get_Preguntas");
            while (Dr.Read())
            {
                Item = new JL_Pregunta();
                Item.IDPregunta = Dr.GetString(Dr.GetOrdinal(("id_pregunta")));
                Item.Pregunta = Dr.GetString(Dr.GetOrdinal("pregunta"));
                Item.Respuesta = Dr.GetString(Dr.GetOrdinal("respuesta"));
                Item.Orden = Dr.GetInt32(Dr.GetOrdinal("orden"));
                Lista.Add(Item);
            }
            return Lista;
        }
        public void ObtenerPreguntasXID(JL_Pregunta Datos)
        {
            object[] Parametros = { Datos.IDPregunta};
            SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "JL_spCSLDB_get_PreguntasXID", Parametros);
            while (Dr.Read())
            {

                Datos.IDPregunta = Dr.GetString(Dr.GetOrdinal("id_pregunta"));
                Datos.Pregunta = Dr.GetString(Dr.GetOrdinal("pregunta"));
                Datos.Respuesta = Dr.GetString(Dr.GetOrdinal("respuesta"));
                Datos.Orden = Dr.GetInt32(Dr.GetOrdinal("orden"));
                Datos.Completado = true;
            }
        }
    }
}
