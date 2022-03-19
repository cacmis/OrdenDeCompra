namespace Facturas.Entidades
{
    public class OrdenDetalle
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }

    }
}