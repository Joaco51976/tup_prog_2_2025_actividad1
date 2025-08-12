using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1___Act1
{
    public class Ortoedro
    {
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }

        public Ortoedro(decimal largo, decimal ancho, decimal alto)
        {
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
        }

        public List<Rectangulo> Tapas
        {
            get
            {
                return new List<Rectangulo>
            {
                new Rectangulo(Largo, Ancho),
                new Rectangulo(Largo, Ancho)
            };
            }
        }

        public List<Rectangulo> Laterales
        {
            get
            {
                return new List<Rectangulo>
            {
                new Rectangulo(Alto, Ancho),
                new Rectangulo(Alto, Ancho),
                new Rectangulo(Alto, Largo),
                new Rectangulo(Alto, Largo)
            };
            }
        }

        public decimal Area => 2 * (Largo * Ancho + Largo * Alto + Ancho * Alto);
        public decimal Volumen => Largo * Ancho * Alto;

        public string Describir()
        {
            string tapasJson = string.Join(",\n", Tapas.Select(t => t.Describir()));
            string lateralesJson = string.Join(",\n", Laterales.Select(l => l.Describir()));

            return $@"{{
    ""Tipo"": ""Ortoedro"",
    ""Tapas"": [
        {tapasJson}
    ],
    ""Laterales"": [
        {lateralesJson}
    ],
    ""Area"": {Area:F2},
    ""Volumen"": {Volumen:F2}
}}";
        }
    }
}