using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupEncomendum
{
    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public DateTime DtPickup { get; set; }

    public string RefShipper { get; set; } = null!;

    public int NrTotalItems { get; set; }

    public int IdCliente { get; set; }

    public int IdCliMorada { get; set; }

    public string EmpresaDest { get; set; } = null!;

    public string ContactoDest { get; set; } = null!;

    public int TelefoneDest { get; set; }

    public string MoradaDest { get; set; } = null!;

    public string LocalidadeDest { get; set; } = null!;

    public string CpostalDest { get; set; } = null!;

    public int IdPaisDestino { get; set; }

    public int? IdManifesto { get; set; }

    public int? NumVolumesManifesto { get; set; }

    public decimal? PesoManifesto { get; set; }

    public int? NumDocAdos { get; set; }

    public bool Concluido { get; set; }
}
