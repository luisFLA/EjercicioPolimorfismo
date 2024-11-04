using System;

namespace EjercicioPolimorfismo
{
    public class Zapato
    {
        public string Marca { get; set; }
        public double Precio { get; set; }

        public Zapato(string marca, double precio)
        {
            Marca = marca;
            Precio = precio;
        }

        public virtual void Describir()
        {
            Console.WriteLine($"Zapato de marca {Marca} con precio de L{Precio}");
        }

        public virtual void AplicarDescuento()
        {
            Console.WriteLine("Aplicando descuento genérico al zapato.");
        }
    }
}

