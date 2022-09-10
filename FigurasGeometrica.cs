using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class FigurasGeometrica :IPoligono
    {

        
        private string nombre;
        //private string fig;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        // cumplimos contrato de interfaz y calculamos el area segun el tipo de figura
        public double Area(string t, double a, double h)
        {
            double resultado=0;
            switch (t)
            {
                case "Triangulo": 
                resultado = (a * h)/2;
                    break;
                case "Rectangulo":
                case "Paralelogramo":
                resultado = (a * h);
                    break;

                default:
                    break;

            }
            
            return resultado;
        }


        public FigurasGeometrica(string nombreFig)
        {
            this.nombre = nombreFig;  
            
        }

       
    }
   // interfaz requerida
public interface IPoligono
    {
        //definimos metodo a utilizar para calculo de area
        public double Area(string tipo, double a, double h);
    }
}
