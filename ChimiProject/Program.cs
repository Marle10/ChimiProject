using System;

namespace ChimiMiBarriga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Chimi MiBarriga del Sr. Billy Navaja!");

            // Crear una hamburguesa clásica
            Hamburguesa hamburguesaClasica = new Hamburguesa("Pan normal", "Carne normal", 100);

            // Agregar ingredientes a la hamburguesa clásica
            hamburguesaClasica.AgregarIngrediente("Lechuga", 20);
            hamburguesaClasica.AgregarIngrediente("Tomate", 20);
            hamburguesaClasica.AgregarIngrediente("Bacon", 30);

            // Mostrar la información de la hamburguesa clásica
            Console.WriteLine("Hamburguesa Clásica:");
            hamburguesaClasica.MostrarDetalleVenta();

            // Crear una hamburguesa saludable
            HamburguesaSaludable hamburguesaSaludable = new HamburguesaSaludable("Pan integral", "Carne magra", 120);

            // Agregar ingredientes a la hamburguesa saludable
            hamburguesaSaludable.AgregarIngrediente("Lechuga", 20);
            hamburguesaSaludable.AgregarIngrediente("Tomate", 20);

            // Mostrar la información de la hamburguesa saludable
            Console.WriteLine("Hamburguesa Saludable:");
            hamburguesaSaludable.MostrarDetalleVenta();

            // Crear una hamburguesa premium
            HamburguesaPremium hamburguesaPremium = new HamburguesaPremium("TipoPan", "Carne", 200);


            // Mostrar la información de la hamburguesa premium
            Console.WriteLine("Hamburguesa Premium:");
            hamburguesaPremium.MostrarDetalleVenta();

            Console.ReadLine();
        }
    }
}
