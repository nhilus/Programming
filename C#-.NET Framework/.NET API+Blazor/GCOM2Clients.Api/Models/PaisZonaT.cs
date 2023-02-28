using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PaisZonaT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Sigla { get; set; }

    public string? SiglaVg { get; set; }

    public string? Zona { get; set; }

    public string? ZonaFedex { get; set; }

    public int? IdRegiao { get; set; }

    public bool? Servico { get; set; }

    public bool? Importacao { get; set; }

    public bool? Exportacao { get; set; }

    public bool RecolhasDom { get; set; }

    public string? MaskCpostal { get; set; }

    public bool? Activo { get; set; }

    public bool? PermiteTarifaOb { get; set; }

    public bool? PermiteTarifaIb { get; set; }

    public int? IdZonaComb { get; set; }

    public bool? ImpIpf { get; set; }

    public bool? ExpIpf { get; set; }

    public bool? IsPais { get; set; }
}
