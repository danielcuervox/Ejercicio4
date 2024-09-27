using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Perro : Animal
    {

        String nombre { get; set; }
        int edad {  get; set; }

        String raza { get; set; }


        //métodos propios 
        internal void ladrar()
        {
            Console.WriteLine("el perro está ladrando");
        }

        public override void comer()
        {
            Console.WriteLine("el perro come como perro");
        }

        public override void caminar()
        {
            Console.WriteLine("el perro camina como perro");
        }

        public override void dormir()
        {
            Console.WriteLine("el perro duerme como un perro");
        }

    }
}
