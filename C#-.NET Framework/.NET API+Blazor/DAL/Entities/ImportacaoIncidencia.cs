using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ImportacaoIncidencia
{
    public int Id { get; set; }

    public int IdManifesto { get; set; }

    public int? IdScan { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public int? IdTipoIncidencia { get; set; }

    public string? Obs { get; set; }

    public int? IdBoff { get; set; }

    public int? IdLocalOcorr { get; set; }

    public int? IdResolucao { get; set; }

    public DateTime? DtResolucao { get; set; }

    public int? IdUtilResolucao { get; set; }

    public DateTime? DtValidacao { get; set; }

    public int? IdUtilValidacao { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? IdReclamacao { get; set; }
}
