using System;
using System.Collections.Generic;

namespace CrudDF3.Models;

public partial class ReservasServicio
{
    public int IdReservaServicio { get; set; }

    public int? IdReserva { get; set; }

    public int? IdServicio { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
