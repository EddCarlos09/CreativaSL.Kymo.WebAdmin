using CreativaSL.Dll.WebAdmin.Global;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Datos
{
    public class RR_TestimonialesDatos
    {
        public List<RR_Testimoniales> ObtenerTestimoniales(RR_Testimoniales Datos)
        {
            try
            {
                List<RR_Testimoniales> Lista = new List<RR_Testimoniales>();
                RR_Testimoniales Item;
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_Testimoniales");
                while (Dr.Read())
                {
                    Item = new RR_Testimoniales();
                    Item.IdTestimonial = Dr.GetString(Dr.GetOrdinal(("id_testimonial")));
                    Item.NombreCompleto = Dr.GetString(Dr.GetOrdinal("nombreCompleto"));
                    Lista.Add(Item);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerTestimonialesXID(RR_Testimoniales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTestimonial };
                SqlDataReader Dr = SqlHelper.ExecuteReader(Datos.Conexion, "RR_spCSLDB_get_TestimonialesXID", Parametros);
                while (Dr.Read())
                {
                    Datos.IdTestimonial = Dr.GetString(Dr.GetOrdinal("id_testimonial"));
                    Datos.NombreCompleto = Dr.GetString(Dr.GetOrdinal("nombreCompleto"));
                    Datos.Comentario = Dr.GetString(Dr.GetOrdinal("comentario"));                    
                    Datos.Completado = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActivarTestimonial(RR_Testimoniales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTestimonial, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_ActivarTestimonial", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarTestimonial(RR_Testimoniales Datos)
        {
            try
            {
                object[] Parametros = { Datos.IdTestimonial, Datos.IDUsuario };
                object Result = SqlHelper.ExecuteScalar(Datos.Conexion, "RR_spCSLDB_B_Testimonial", Parametros);
                int Resultado = 0;
                int.TryParse(Result.ToString(), out Resultado);
                if (Resultado == 1)
                {
                    Datos.Completado = true;
                }
                Datos.Resultado = Resultado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
