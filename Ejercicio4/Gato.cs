using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Gato : Animal
    {

        String nombre { get; set; }
        int edad { get; set; }

        String raza { get; set; }

        int numVidas { get; set; }

        public virtual void comer()
        {
            Console.WriteLine("el Gato está comiendo");
        }

        public virtual void caminar()
        {
            Console.WriteLine("el Gato está caminando");
        }

        public virtual void dormir()
        {
            Console.WriteLine("el Gato está durmiendo");
        }
    }
}
