using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2___Act1
{
    public class Cubo : Ortoedro
    {
        public Cubo(decimal lado) : base(lado, lado, lado) { }

        public string Describir()
        {
            return $@"{{
            ""Tipo"": ""Cubo"",
            ""Area"": {Area:F2},
            ""Volumen"": {Volumen:F2}
            }}";
        }
    }
}
