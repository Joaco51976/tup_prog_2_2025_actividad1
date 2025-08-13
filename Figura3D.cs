using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2___Act1
{
    public abstract class Figura3D
    {
        public abstract decimal Area { get; }
        public abstract decimal Volumen { get; }
        public abstract string Describir();
    }
}