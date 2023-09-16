using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    internal class ListaEstudiante
    {
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int estrato{ get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int Grado { get; set; }
        public string servicioPAE { get; set; }
       
        public string beneficio { get; set; }



        public string BeneficioAlimentario()
        {

            string beneficio = "";

            if( Grado > 6 && Grado <= 9)
            {

                beneficio = "Desayuno";

            }

            if (Grado >10 && Grado <= 11)
            {

                beneficio = "Almierzo";

            }

            return beneficio;

        }







    }
}
