using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupEncomendaItem
{
    public int Id { get; set; }

    public int IdPickupEncomenda { get; set; }

    public string RefShipper { get; set; } = null!;

    public int NrItem { get; set; }

    public int IdPickup { get; set; }

    public bool Cancelado { get; set; }
}
