using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2___Act1
{
    public class Circulo
    {
        public decimal Radio { get; set; }

        public Circulo(decimal radio)
        {
            Radio = radio;
        }

        public decimal Area => (decimal)Math.PI * Radio * Radio;

        public string Describir()
        {
            return $@"{{
            ""Tipo"": ""Circulo"",
            ""Radio"": {Radio:F2},
            ""Area"": {Area:F2}
            }}";
        }
    }
}
