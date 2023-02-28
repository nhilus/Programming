using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupCustosReai
{
    public int Id { get; set; }

    public int? IdPickup { get; set; }

    public DateTime? ScanDate { get; set; }

    public DateTime? ScanDateDt { get; set; }

    public TimeSpan? ScanDateTm { get; set; }

    public string? ScanCode { get; set; }

    public int? IdUtil { get; set; }

    public int? IdRota { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdFornecedor { get; set; }

    public int? IdAgente { get; set; }

    public bool? ParaFacturar { get; set; }

    public int? IdMotivoNf { get; set; }

    public decimal? Valor { get; set; }

    public int? IdTarifaForn { get; set; }

    public decimal? ValorManual { get; set; }

    public bool Recalcular { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdStop { get; set; }

    public int? IdTipoCusto { get; set; }

    public int? IdTarifaPenalizacao { get; set; }

    public int? IdTipoPenalizacao { get; set; }

    public string? Observacoes { get; set; }

    public bool? ValidManual { get; set; }

    public int? IdUtilvalidManual { get; set; }

    public DateTime? DtvalidManual { get; set; }

    public int? IdTarifaEspecial { get; set; }
}
