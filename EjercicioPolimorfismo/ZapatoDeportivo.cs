namespace EjercicioPolimorfismo
{
    public class ZapatoDeportivo : Zapato
    {
        public ZapatoDeportivo(string marca, double precio) : base(marca, precio) { }

        public override void Describir()
        {
            Console.WriteLine($"Zapato Deportivo de marca {Marca} con precio de L{Precio}. Ideal para actividades deportivas.");
        }

        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.10;
            Console.WriteLine($"Descuento aplicado al zapato deportivo. Nuevo precio: L{Precio}");
        }
    }
}

