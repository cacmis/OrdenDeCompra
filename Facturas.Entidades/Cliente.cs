namespace Facturas.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string   Direccion { get; set; }
        public string Telefono { get; set; }

        public List<Orden> Ordenes { get; set; }
    }
}