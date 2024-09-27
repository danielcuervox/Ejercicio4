using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            Animal.agregarAnimales(nuevoAnimal);

            Animal.mostrarInfoAnimales();

            String nombre = "Sharki";

            Animal.buscarAnimal(nombre);

            String nombreEliminar = "Rufus";

            Animal.eliminarAnimal(nombre);

            */


            ArrayList listaDeAnimales2 = new ArrayList();

            Perro perro1 = new Perro();
            //perro1.comer();

            //perro1.caminar();

            perro1.ladrar();
            perro1.caminar();   
            perro1.dormir();


            Gato gato1 = new Gato();
            gato1.caminar();
            gato1.dormir();
            gato1.comer();

            Console.ReadKey();


         

          

        }

        
    }
}
