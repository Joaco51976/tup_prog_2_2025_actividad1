using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public class Rectangulo
    {
        public double ancho { get; set; }
        public double largo { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            ancho = ancho;
            largo = largo;
        }

        public string Describir()
        {
            return "rectangulo";
        }

       /*  public double CalcularArea()
        {

        }
       */

        public string Describir()
        {
            string json = $@"
            {{
                ""Lado"":9, {this.lado}

                ""Ancho"":3 {this.ancho}
            }}
            ";
        }
    }
}