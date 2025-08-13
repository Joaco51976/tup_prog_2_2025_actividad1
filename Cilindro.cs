using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2___Act1
{
    public class Cilindro : Figura3D
    {
        public decimal Radio { get; set; }
        public decimal Altura { get; set; }

        public Cilindro(decimal radio, decimal altura)
        {
            Radio = radio;
            Altura = altura;
        }

        public Circulo Tapa => new Circulo(Radio);

        public override decimal Area => 2 * Tapa.Area + 2 * (decimal)Math.PI * Radio * Altura;
        public override decimal Volumen => Tapa.Area * Altura;

        public override string Describir()
        {
            return $@"{{
            ""Tipo"": ""Cilindro"",
            ""Tapa"": {Tapa.Describir()},
            ""Altura"": {Altura:F2},
            ""Area"": {Area:F2},
            ""Volumen"": {Volumen:F2}
            }}";
        }
    }
}
