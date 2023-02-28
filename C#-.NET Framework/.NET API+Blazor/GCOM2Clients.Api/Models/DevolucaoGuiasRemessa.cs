using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class DevolucaoGuiasRemessa
{
    public int IdExportacao { get; set; }

    public string AwbOriginal { get; set; } = null!;

    public int? IdManifestoDev { get; set; }

    public string? AwbDevolucao { get; set; }

    public bool Finalizar { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public int? IdUtilGerouDevolucao { get; set; }

    public DateTime? DtUtilGerouDevolucao { get; set; }

    public int? IdUtilFin { get; set; }

    public DateTime? DtUtilFin { get; set; }
}
