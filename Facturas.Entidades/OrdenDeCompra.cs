using System.ComponentModel.DataAnnotations;

namespace Facturas.Entidades
{
    public class OrdenDeCompra
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public string DireccionEntrega { get; set; }
        public string Contacto { get; set; }
        public int TiempoEntrega { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaAlta { get; set; }
        public decimal TotalPagar { get; set; }


    }
}