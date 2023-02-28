using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupDelegacao
{
    public int Id { get; set; }

    public int? IdPickupOrigem { get; set; }

    public int? IdEntidadeOrigem { get; set; }

    public int? IdPickupDelegada { get; set; }

    public int? IdEntidadeDelegada { get; set; }

    public DateTime? DtIntrod { get; set; }

    public DateTime? DtDelegada { get; set; }
}
