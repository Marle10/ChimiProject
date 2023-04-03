using System;
using System.Collections.Generic;

namespace ChimiMiBarriga
{
    public class HamburguesaSaludable : Hamburguesa
    {
        private readonly int _maxIngredientesAdicionales = 6;
        private readonly List<string> _ingredientesAdicionales = new List<string>();

        public HamburguesaSaludable(string tipoPan, string carne, decimal Precio)
            : base(tipoPan, carne, Precio)
        {
        }

        public void precioIngredientes(string ingrediente, decimal precioAdicional)
        {
            if (_ingredientesAdicionales.Count < _maxIngredientesAdicionales)
            {
                _ingredientesAdicionales.Add(ingrediente);
                precioBase += precioAdicional;
            }
            else
            {
                Console.WriteLine($"No se pueden agregar más de {_maxIngredientesAdicionales} ingredientes adicionales.");
            }
        }

        public override void MostrarDetalleVenta()
        {
            base.MostrarDetalleVenta();
            Console.WriteLine("Ingredientes adicionales:");
            foreach (string ingrediente in _ingredientesAdicionales)
            {
                Console.WriteLine($"- {ingrediente}");
            }
            Console.WriteLine($"Total de la venta: {precioBase:C}");
        }
    }
}
