using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    public class HamburguesaClasica
    {
        public string tipoPan;
        public string carne;
        public decimal precioBase;
        public List<string> ingredientesAdicionales = new List<string>();
        public List<decimal> preciosAdicionales = new List<decimal>();

        public HamburguesaClasica(string tipoPan, string carne, decimal precioBase)
        {
            this.tipoPan = tipoPan;
            this.carne = carne;
            this.precioBase = precioBase;
        }

        public virtual void agregarIngrediente(string ingrediente, decimal precio)
        {
            if (ingredientesAdicionales.Count < 4)
            {
                ingredientesAdicionales.Add(ingrediente);
                preciosAdicionales.Add(precio);
            }
            else
            {
                Console.WriteLine("No se pueden agregar más de 4 ingredientes adicionales.");
            }
        }

        public virtual void mostrarPrecio()
        {
            decimal total = precioBase;
            Console.WriteLine("Hamburguesa: " + GetType().Name + " (Pan: " + tipoPan + ", Carne: " + carne + "): " + precioBase.ToString("C2"));
            for (int i = 0; i < ingredientesAdicionales.Count; i++)
            {
                Console.WriteLine("- " + ingredientesAdicionales[i] + ": " + preciosAdicionales[i].ToString("C2"));
                total += preciosAdicionales[i];
            }
            Console.WriteLine("Total: " + total.ToString("C2"));
        }
    }
}
