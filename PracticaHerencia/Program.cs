using PracticaHerencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("¡Bienvenido a Chimi MiBarriga del Sr. Billy Navaja!");
                Console.WriteLine("Por favor, elija una hamburguesa:");
                Console.WriteLine("1. Hamburguesa clásica");
                Console.WriteLine("2. Hamburguesa saludable");
                Console.WriteLine("3. Hamburguesa premium");
                Console.WriteLine("0. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        HamburguesaClasica hamburguesa1 = new HamburguesaClasica("Pan de trigo", "Carne de res", 150.00M);
                        Console.WriteLine("Agregar ingredientes adicionales (separados por comas):");
                        string[] ingredientes1 = Console.ReadLine().Split(',');
                        foreach (string ingrediente in ingredientes1)
                        {
                            hamburguesa1.agregarIngrediente(ingrediente.Trim(), 10.00M);
                        }
                        hamburguesa1.mostrarPrecio();
                        break;

                    case 2:
                        HamburguesaSaludable hamburguesa2 = new HamburguesaSaludable("Pan integral", "Carne de pollo", 180.00M);
                        Console.WriteLine("Agregar ingredientes adicionales (separados por comas):");
                        string[] ingredientes2 = Console.ReadLine().Split(',');
                        foreach (string ingrediente in ingredientes2)
                        {
                            hamburguesa2.agregarIngrediente(ingrediente.Trim(), 15.00M);
                        }
                        hamburguesa2.mostrarPrecio();
                        break;

                    case 3:
                        HamburguesaPremium hamburguesa3 = new HamburguesaPremium("Pan de papa", "Carne de cerdo", 220.00M);
                        hamburguesa3.mostrarPrecio();
                        break;

                    case 0:
                        Console.WriteLine("¡Gracias por visitar Chimi MiBarriga del Sr. Billy Navaja! ¡Vuelve pronto!");
                        return;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
