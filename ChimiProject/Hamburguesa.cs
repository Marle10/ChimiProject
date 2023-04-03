using System;
using System.Collections.Generic;

namespace ChimiMiBarriga
{
    public class Hamburguesa
    {
        public string TipoPan;
        public string Carne;
        public decimal precioBase;
        public List<string> Ingredientes = new List<string>();
        public decimal precioIngredientes;
        internal double Precio;
        private double precioBase1;
        private decimal precio;
        

        

        public Hamburguesa(string tipoPan, string carne, double precioBase1, decimal precio)
        {
            TipoPan = tipoPan;
            Carne = carne;
            this.precioBase1 = precioBase1;
            this.precio = precio;
        }


        public void AgregarIngrediente(string ingrediente, decimal precio)
        {
            if (Ingredientes.Count < 4)
            {
                Ingredientes.Add(ingrediente);
                precioIngredientes += precio;
            }
            else
            {
                Console.WriteLine("Ya ha alcanzado el máximo de ingredientes adicionales.");
            }
        }

        public virtual void MostrarDetalleVenta()
        {
            Console.WriteLine("Tipo de pan: " + TipoPan);
            Console.WriteLine("Carne: " + Carne);
            Console.WriteLine("Precio base: $" + precioBase);
            Console.WriteLine("Ingredientes adicionales:");

            foreach (string ingrediente in Ingredientes)
            {
                Console.WriteLine("- " + ingrediente);
            }

            Console.WriteLine("Precio ingredientes adicionales: $" + precioIngredientes);
            Console.WriteLine("Precio total: $" + (precioBase + precioIngredientes));
        }

        }
    }

