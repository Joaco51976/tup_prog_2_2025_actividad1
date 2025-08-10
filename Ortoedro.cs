using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];
        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);
            Laterales[0] = new Rectangulo(ladoComun, largoLateral);
            Laterales[1] = new Rectangulo(ladoComun, largoLateral);
            Laterales[2] = new Rectangulo(ladoComun, largoLateral);
            Laterales[3] = new Rectangulo(ladoComun, largoLateral);
        }

        public double CalcularArea()
        {
             double areaBase = Bases[0].CalcularArea();
             double areaLateral = Laterales[0].CalcularArea();
             return areaBase * 2 + areaLateral* 4;
        }
    }
}