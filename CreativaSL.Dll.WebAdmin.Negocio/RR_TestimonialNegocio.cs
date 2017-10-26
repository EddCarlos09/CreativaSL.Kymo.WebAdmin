using CreativaSL.Dll.WebAdmin.Datos;
using CreativaSL.Dll.WebAdmin.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.WebAdmin.Negocio
{
    public class RR_TestimonialNegocio
    {
        public List<RR_Testimoniales> ObtenerTestimonial(RR_Testimoniales Datos)
        {
            RR_TestimonialesDatos TD = new RR_TestimonialesDatos();
            return TD.ObtenerTestimoniales(Datos);
        }

        public void ObtenerTestimonialXId(RR_Testimoniales Datos)
        {
            RR_TestimonialesDatos TD = new RR_TestimonialesDatos();
            TD.ObtenerTestimonialesXID(Datos);
        }

        public void ActivarTestimonial(RR_Testimoniales Datos)
        {
            RR_TestimonialesDatos TD = new RR_TestimonialesDatos();
            TD.ActivarTestimonial(Datos);
        }

        public void EliminarTestimonial(RR_Testimoniales Datos)
        {
            RR_TestimonialesDatos TD = new RR_TestimonialesDatos();
            TD.EliminarTestimonial(Datos);
        }

    }
}
