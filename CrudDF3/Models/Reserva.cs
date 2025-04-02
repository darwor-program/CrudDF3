using System;
using System.Collections.Generic;

namespace CrudDF3.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdHuesped { get; set; }

    public int? IdHabitacion { get; set; }

    public DateTime? FechaInicial { get; set; }

    public DateTime? FechaFinal { get; set; }

    public int? NumeroPersonas { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Anticipo { get; set; }

    public DateTime? FechaReserva { get; set; }

    public bool EstadoReserva { get; set; }

    public virtual Habitacione? IdHabitacionNavigation { get; set; }

    public virtual Huespede? IdHuespedNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<ReservasPaquete> ReservasPaquetes { get; set; } = new List<ReservasPaquete>();

    public virtual ICollection<ReservasServicio> ReservasServicios { get; set; } = new List<ReservasServicio>();
}
