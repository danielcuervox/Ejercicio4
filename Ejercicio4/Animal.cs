using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public abstract class Animal
    {
        public virtual void comer()
        {
            Console.WriteLine("el Animal está comiendo");
        }

        public virtual void caminar()
        {
            Console.WriteLine("el Animal está caminando");
        }

        public virtual void dormir()
        {
            Console.WriteLine("el Animal está durmiendo");
        }


    }
}
