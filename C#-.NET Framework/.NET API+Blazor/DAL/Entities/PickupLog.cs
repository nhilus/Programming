using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupLog
{
    public int Id { get; set; }

    public int IdPickup { get; set; }

    public int IdUtil { get; set; }

    public DateTime Data { get; set; }

    public int IdAccao { get; set; }

    public string? Observacoes { get; set; }
}
