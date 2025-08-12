using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1___Act1
{
    public class Rectangulo
    {
    public decimal Largo { get; set; }
    public decimal Ancho { get; set; }

    public Rectangulo(decimal largo, decimal ancho)
    {
    Largo = largo;
    Ancho = ancho;
    }

    public decimal Area => Largo * Ancho;

        public string Describir()
        {
        return $@"{{
        ""Tipo"": ""Rectangulo"",
        ""Largo"": {Largo:F2},
        ""Ancho"": {Ancho:F2},
        ""Area"": {Area:F2}
        }}";
        }
    }
}
