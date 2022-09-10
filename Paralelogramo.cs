using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Paralelogramo:FigurasGeometrica
    {
        private string myNombre;

        public string MyNombre
        {
            get { return myNombre; }
            set { myNombre = value; }
        }
        private string myTipo;

        public string MyTipo
        {
            get { return myTipo; }
            set { myTipo = value; }
        }
        private double myBase;

        public double MyBase
        {
            get { return myBase; }
            set { myBase = value; }
        }
        private double myAltura;

        public double MyAltura
        {
            get { return myAltura; }
            set { myAltura = value; }
        }


        public Paralelogramo(double _base, double _altura, string fig) : base(fig)
        {
            this.myNombre = fig;
            this.myTipo = "Paralelogramo";
            this.myBase = _base;
            this.myAltura = _altura;

        }
        //metodo requirido para mostrar nombre y area
        public string mostrar(string fig)

        {

            return Convert.ToString(this.myTipo + ": " + this.myNombre + ": " + base.Area(this.myTipo, this.MyBase, this.myAltura));
            // return base.Area(2.3, 2.5, this.myTipo) ;    

        }

    }
}
