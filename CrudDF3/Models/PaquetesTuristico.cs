namespace CrudDF3.Models
{
    public partial class PaquetesTuristico
    {
        public int IdPaquete { get; set; }
        public string? NombrePaquete { get; set; }
        public string? DescripcionPaquete { get; set; }
        public decimal? PrecioPaquete { get; set; }
        public bool DisponibilidadPaquete { get; set; }
        public DateTime? FechaPaquete { get; set; }
        public string? DestinoPaquete { get; set; }
        public bool EstadoPaquete { get; set; }
        public string? TipoViajePaquete { get; set; }

        public virtual ICollection<ReservasPaquete> ReservasPaquetes { get; set; } = new List<ReservasPaquete>();

        // Relación muchos a muchos con Servicios
        public virtual ICollection<PaqueteServicio> PaqueteServicios { get; set; } = new List<PaqueteServicio>();

        // Relación uno a muchos con Habitaciones
        public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();
    }
}
