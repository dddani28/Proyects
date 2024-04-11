using System;

namespace AdivinaElNúmero
{
    class Código
    {
        static void Main ()
        {
            string nombre;
            Console.WriteLine("Hola, ¿cómo te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola {0}, hoy pensaré en un número del 1 al 100 y tendrás que adivinarlo. ¿Empezamos?", nombre);

            Empezar();
        }
        static void Empezar()
        {
            string empezamos;
            empezamos = Console.ReadLine();
            if (empezamos == null)
            {
                Console.WriteLine("Porfavor di si o no");
                Empezar();
            }
            switch (empezamos)
            {
                case "No":
                Console.WriteLine("A vale, ¡hasta la próxima!");
                break;

                case "Si":
                Juego();
                break;

                case "no":
                Console.WriteLine("A vale, ¡hasta la próxima!");
                break;

                case "si":
                Juego();
                break;

                default:
                Console.WriteLine("Porfavor di si o no");
                Empezar();
                break;
            }
        }
        static void Juego()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 101);
            Console.WriteLine("Vale, di un número y te diré si está por encima o por debajo de mi número");
            Numero(num, 0);
        }
        static void Numero(int num, int contador)
        {
            double nuevoNum1;
            try
            {
                nuevoNum1 = Convert.ToDouble(Console.ReadLine());

                if (nuevoNum1 < num)
            {
                Console.WriteLine("Ese número está por debajo del mio");
                contador++;
                Numero(num, contador);
            }
            if (nuevoNum1 > num)
            {
                Console.WriteLine("Ese número está por encima del mio");
                contador++;
                Numero(num, contador);
            }
            if (nuevoNum1 == num)
            {
                Console.WriteLine("¡Felicidades! Has acertado el número en {0} intentos. ¿Quieres volver a jugar?", ++contador);
                Empezar();
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Porvafor di un número del 1 al 100");
                Numero(num, contador);
            }
        }
    }
}