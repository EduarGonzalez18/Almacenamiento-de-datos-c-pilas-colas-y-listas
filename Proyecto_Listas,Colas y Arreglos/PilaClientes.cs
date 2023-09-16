using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    internal class PilaClientes
    {


        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Estrato { get; set; }
        public string Genero { get; set; }
        public DateTime MesDeAfiliacion { get; set; }
        public string categoria { get; set; }
        public string CanalMegas { get; set; }
        public double ValorTotal { get; set; }





        private double calcularValorCategoria()
        {

            double ValorCategoria = 0;
            

            if (CanalMegas == "5 Megas")
            {
                if (categoria == "Urbano")
                {

                    ValorCategoria = 20000;


                }

                else if (categoria == "Rural")
                {

                    ValorCategoria = 30000;


                }

            }


            else if (CanalMegas == "10 Megas")
            {
                if (categoria == "Urbano")
                {

                    ValorCategoria = 30000;


                }

                else if (categoria == "Rural")
                {

                    ValorCategoria = 40000;


                }


            }

            else if (CanalMegas == "20 Megas")
            {
                if (categoria == "Urbano")
                {

                    ValorCategoria = 45000;


                }

                else if (categoria == "Rural")
                {

                    ValorCategoria = 55000;


                }



            }

            else if (CanalMegas == "50 Megas")
            {
                if (categoria == "Urbano")
                {

                    ValorCategoria = 60000;


                }

                else if (categoria == "Rural")
                {

                    ValorCategoria = 70000;


                }

            }


            return ValorCategoria;



        }


        private double CalcularDescuento()
        {

            double descuentoEstrato = 0;

            if (Estrato == 1 || Estrato == 2 || Estrato == 3)
            {
                descuentoEstrato = 0.15;
                
            }

            else if (Estrato == 4 || Estrato == 5 || Estrato == 6)
            {
                descuentoEstrato = 0.10;

            }


            return descuentoEstrato;
        }



         public double ValorTotalApagar()
        {
            double valorTotal = 0;

            valorTotal = calcularValorCategoria() -     (CalcularDescuento() * calcularValorCategoria());
           
            return valorTotal;

        }

    }
}
