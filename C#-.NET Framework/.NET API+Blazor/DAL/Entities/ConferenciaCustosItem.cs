using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ConferenciaCustosItem
{
    public int Id { get; set; }

    public int IdConferenciaCustosEnvios { get; set; }

    public int? IdServicoDet { get; set; }

    public string? Description { get; set; }

    public decimal Valor { get; set; }

    public string? ImportObjectName { get; set; }

    public int? ImportObjectId { get; set; }
}
