using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosEntrega
{
    public int Id { get; set; }

    public int IdConferenciaCustosEnvios { get; set; }

    public string? CodigoEntrega { get; set; }

    public DateTime? DataEntrega { get; set; }

    public DateTime? PrimeiraTentativa { get; set; }

    public string? Assinatura { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }
}
