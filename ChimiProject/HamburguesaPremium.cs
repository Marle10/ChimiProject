using System;
using System.Collections.Generic;
using ChimiMiBarriga;

class HamburguesaPremium : Hamburguesa
{
    private bool papitas;
    private bool bebida;

    public HamburguesaPremium(string tipoPan, string carne, double precioBase) : base(tipoPan, carne, precioBase)
    {
    }

    public HamburguesaPremium(string tipoPan, string carne, double precioBase, bool papitas, bool bebida)
        : base(tipoPan, carne, precioBase)
    {
        this.papitas = papitas;
        this.bebida = bebida;
    }

    public double precioBase()
    {
        double precio = precioBase();

        if (papitas)
        {
            precio += 1.5;
            Console.WriteLine(" - Papitas fritas: $1.5");
        }

        if (bebida)
        {
            precio += 2.0;
            Console.WriteLine(" - Bebida: $2.0");
        }

        Console.WriteLine("Total: ${0}\n", precio);
        return precio;
    }
}
