using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class CargoScanner
{
    public int Id { get; set; }

    public DateTime DataAutomatica { get; set; }

    public DateTime? DataLeitura { get; set; }

    public string? Modo { get; set; }

    public string Awb { get; set; } = null!;

    public decimal? Peso { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Pesovol { get; set; }

    public DateTime? DtScans { get; set; }

    public DateTime? DtConferido { get; set; }

    public int? IdImportacaoManifesto { get; set; }

    public int? IdExportacaoManifesto { get; set; }

    public string? IdBalanca { get; set; }

    public int? IdUnico { get; set; }

    public int? IdManifesto { get; set; }

    public DateTime? DtValida { get; set; }

    public DateTime? DtNotif { get; set; }

    public bool? AlteraValor { get; set; }

    public int? IdRazaoNaoConferir { get; set; }

    public string? RampId { get; set; }
}
