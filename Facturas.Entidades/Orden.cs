using System.ComponentModel.DataAnnotations;

namespace Facturas.Entidades
{
    public class Orden
    {
        public int Id { get; set; }
        public int TiempoEntrega { get; set; }
        public decimal Descuento { get; set; }
        public DateTime FechaAlta { get; set; }
        public decimal TotalPagar { get; set; }

        // FK
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<OrdenDetalle> OrdenDetalles { get; set; }

    }
}