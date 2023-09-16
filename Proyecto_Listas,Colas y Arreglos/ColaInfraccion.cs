using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    internal class ColaInfraccion
    {
        public decimal Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string placa { get; set; }
        public string TipoDeAutomotor { get; set; }
        public DateTime anioMatricula { get; set; }
        public DateTime fechaComparendo { get; set; }

        public int diasInfraccion;
        public int DiasInfraccion { get { return diasInfraccion; } }
        public double ValorTotal { get; set; }


        public double valorComparendo = 450000; 


        // Metodo para determinar los dias que han pasado depues de la infraación

        public int getDiasInfraccion()
        {

            diasInfraccion = 0;
            TimeSpan diasTrasnscurridos = DateTime.Now.Subtract(fechaComparendo);
            diasInfraccion = (int)diasTrasnscurridos.TotalDays;
            return diasInfraccion;

        }


        public double descuento()
        {

            double descuento = 0;
            int diasInfraccion = getDiasInfraccion();

            // EN un caso probar con el if sin el swith

         
               

               
                    if (diasInfraccion < 10)
                    {
                        descuento = valorComparendo * 0.5;
                   
                    }
                 
                          
                    if (diasInfraccion >= 10 && diasInfraccion < 20)
                    {
                        descuento = valorComparendo * 0.25;
                       
                    }
                       
                    if (diasInfraccion >= 20 && diasInfraccion < 30)
                    {
                        descuento = valorComparendo * 0.1;
                    }
                         
                    if (diasInfraccion > 30)
                    {
                        descuento = 0;
                       
                    }

            return descuento;




        }


        public double valorApagar()
        {

            double valorTotal = 0;

            valorTotal = valorComparendo - descuento();
            return valorTotal;

        }


    }
}
