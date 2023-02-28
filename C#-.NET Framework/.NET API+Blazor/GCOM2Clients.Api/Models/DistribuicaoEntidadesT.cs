using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DistribuicaoEntidadesT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Sigla { get; set; }

    public bool? IsEntidade { get; set; }

    public bool? IsDistribuidor { get; set; }

    public bool IsWorking { get; set; }

    public bool? Activo { get; set; }

    public string? LogoImg { get; set; }

    public string? HeaderImg { get; set; }

    public string? AppName { get; set; }

    public string? AppNameAlt { get; set; }

    public string? CodSap { get; set; }

    public string? MandanteSap { get; set; }

    public string? PlatSap { get; set; }

    public bool? ActivoSap { get; set; }

    public decimal DivVolumetrico { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdUtilSistema { get; set; }

    public bool GuardarDestinatario { get; set; }

    public bool? IsDestinatarioCrm { get; set; }

    public bool? IsDestinatarioCrossSelling { get; set; }

    public string? CorClienteBar { get; set; }

    public bool IsDestinatarioBoff { get; set; }

    public int? IdPais { get; set; }

    public int? IdUnidadeMonetaria { get; set; }

    public int? IdMoedaDefaultTarifa { get; set; }
}
