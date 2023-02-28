using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorSetting
{
    public int Id { get; set; }

    public int? IdUtil { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdPais { get; set; }

    public string? Impressora { get; set; }

    public string? ImpressoraEtiq { get; set; }

    public string? FormatoImp { get; set; }

    public string? VersaoChrome { get; set; }

    public string? PluginWcpp { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? Activo { get; set; }
}
