using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class HamburguesaSaludable : HamburguesaClasica
    {
        private List<string> ingredientesSaludables = new List<string>();
        private List<decimal> preciosSaludables = new List<decimal>();

        public HamburguesaSaludable(string tipoPan, string carne, decimal precioBase) : base(tipoPan, carne, precioBase)
        {
        }

        public void agregarIngredienteSaludable(string ingrediente, decimal precio)
        {
            if (ingredientesSaludables.Count < 2)
            {
                ingredientesSaludables.Add(ingrediente);
                preciosSaludables.Add(precio);
            }
            else
            {
                Console.WriteLine("No se pueden agregar más de 2 ingredientes saludables.");
            }
        }

        public override void mostrarPrecio()
        {
            decimal total = precioBase;
            Console.WriteLine("Hamburguesa: " + GetType().Name + " (Pan: " + tipoPan + ", Carne: " + carne + "): " + precioBase.ToString("C2"));
            for (int i = 0; i < ingredientesAdicionales.Count; i++)
            {
                Console.WriteLine("- " + ingredientesAdicionales[i] + ": " + preciosAdicionales[i].ToString("C2"));
                total += preciosAdicionales[i];
            }
            for (int i = 0; i < ingredientesSaludables.Count; i++)
            {
                Console.WriteLine("- " + ingredientesSaludables[i] + ": " + preciosSaludables[i].ToString("C2"));
                total += preciosSaludables[i];
            }
            Console.WriteLine("Total: " + total.ToString("C2"));
        }
    }
}
