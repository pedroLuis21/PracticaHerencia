using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{

        public class HamburguesaPremium : HamburguesaClasica
        {
            private readonly decimal _precioPapitas = 50.00m;
            private readonly decimal _precioBebida = 30.00m;
            private bool _tienePapitasYBebida = true;

            public HamburguesaPremium(string tipoPan, string carne, decimal precioBase) : base(tipoPan, carne, precioBase)
            {
                this.precioBase += _precioPapitas + _precioBebida;
            }

            public void quitarPapitasYBebida()
            {
                _tienePapitasYBebida = false;
                this.precioBase -= _precioPapitas + _precioBebida;
            }

            public override void agregarIngrediente(string ingrediente, decimal precioAdicional)
            {
                if (_tienePapitasYBebida)
                {
                    Console.WriteLine("No se pueden agregar ingredientes adicionales a la Hamburguesa Premium que ya tiene papitas y bebida.");
                }
                else
                {
                    base.agregarIngrediente(ingrediente, precioAdicional);
                }
            }

            public override void mostrarPrecio()
            {
            Console.WriteLine("Hamburguesa: " + GetType().Name + " (Pan: " + tipoPan + ", Carne: " + carne + "): " + 220.00M);
            Console.WriteLine($"Adicionales incluidos: Papitas (${_precioPapitas}) y Bebida (${_precioBebida})");
                Console.WriteLine($"Precio total de la Hamburguesa Premium: ${precioBase}");
            }
        }




    }


