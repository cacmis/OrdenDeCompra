namespace Facturas.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal  Precio  { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public decimal Descuento { get; set; }

    }
}