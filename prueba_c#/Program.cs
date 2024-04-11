using System;

namespace prueba1
{
    class Program
    {
        static void Main ()
            {
                string nombre;
                Console.WriteLine("¿Cómo te llamas?");

                nombre = Console.ReadLine();

                Console.WriteLine("Hola {0}. ¿Cuántos años tienes?", nombre);
                string edad = Console.ReadLine();

                Console.WriteLine("Entonces, te llamas {0} y tienes {1} años", nombre, edad);
            }
    }
}