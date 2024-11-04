namespace EjercicioPolimorfismo
{
    public class ZapatoCasual : Zapato
    {
        public ZapatoCasual(string marca, double precio) : base(marca, precio) { }

        public override void Describir()
        {
            Console.WriteLine($"Zapato Casual de marca {Marca} con precio de L{Precio}. Ideal para uso diario.");
        }

        public override void AplicarDescuento()
        {
            Precio -= Precio * 0.05;
            Console.WriteLine($"Descuento aplicado al zapato casual. Nuevo precio: L{Precio}");
        }
    }
}
