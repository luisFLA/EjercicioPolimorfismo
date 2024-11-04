namespace EjercicioPolimorfismo
{
    public class ZapatoFormal : Zapato
    {
        public ZapatoFormal(string marca, double precio) : base(marca, precio) { }

        public override void Describir()
        {
            Console.WriteLine($"Zapato Formal de marca {Marca} con precio de L{Precio}. Ideal para ocasiones formales.");
        }

        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.15;
            Console.WriteLine($"Descuento aplicado al zapato formal. Nuevo precio: L{Precio}");
        }
    }
}
