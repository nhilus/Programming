using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoDu
{
    public int IdManifesto { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public DateTime? Data { get; set; }

    public short? IdUtilIntrod { get; set; }

    public string? ObservacoesDu { get; set; }

    public int? NumDu { get; set; }

    public DateTime? DtFedex { get; set; }

    public DateTime? DtCliente { get; set; }

    public string? MoradaAlt { get; set; }

    public int? IdClienteDu { get; set; }

    public int? NumEstanciaAdu { get; set; }

    public short? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
