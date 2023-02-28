using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ServicosT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateTime HoraEntrega { get; set; }

    public int IdSegmento { get; set; }

    public int IdEntidade { get; set; }

    public bool Default { get; set; }

    public bool? Activo { get; set; }

    public int Posicao { get; set; }

    public decimal? MaxDimInCm { get; set; }

    public decimal? MaxSizeInCm { get; set; }

    public decimal? MaxWeightPerVol { get; set; }

    public decimal? DivVolumetrico { get; set; }

    public decimal? PesoMinFact { get; set; }

    public decimal? PesoMinUni { get; set; }

    public bool ContaTempoTransito { get; set; }

    public int DiasTransito { get; set; }

    public bool? UseKpi { get; set; }

    public bool EnvInterface { get; set; }

    public bool? IsComissionavel { get; set; }

    public bool IsValidPortal { get; set; }

    public bool? IsFacturavelCliente { get; set; }

    public bool? IsValidDataEntry { get; set; }

    public decimal? MaxWeight { get; set; }

    public bool? Recolha { get; set; }
}
