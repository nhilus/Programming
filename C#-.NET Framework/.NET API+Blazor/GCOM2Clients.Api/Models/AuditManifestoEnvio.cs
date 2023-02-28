using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AuditManifestoEnvio
{
    public int IdAudit { get; set; }

    public string Type { get; set; } = null!;

    public int IdMaster { get; set; }

    public string Awb { get; set; } = null!;

    public byte IdEntidade { get; set; }

    public short? IdPltOrigem { get; set; }

    public short? IdPltDestino { get; set; }

    public DateTime? DtEnvio { get; set; }

    public int? IdCliente { get; set; }

    public int? IdClienteFact { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public int? IdClienteEmissao { get; set; }

    public int? IdCliMoradaEmissao { get; set; }

    public byte? IdLocPagaTrans { get; set; }

    public string? NumContaPagaTrans { get; set; }

    public byte? IdLocPagaDir { get; set; }

    public string? NumContaPagaDir { get; set; }

    public short? NumPacotes { get; set; }

    public int? IdTipoProduto { get; set; }

    public decimal? Peso { get; set; }

    public byte? IdUnidadePeso { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public byte? IdUnidadePesoVolumetrico { get; set; }

    public double? M3 { get; set; }

    public byte? IdUnidM3 { get; set; }

    public byte? IdRegime { get; set; }

    public byte? IdServico { get; set; }

    public decimal? ValorSegurado { get; set; }

    public decimal? ValorReembolso { get; set; }

    public string? ReembolsoObs { get; set; }

    public string? DepartamentoFact { get; set; }

    public short? IdClasseOrigem { get; set; }

    public string? Descricao { get; set; }

    public string? Observacoes { get; set; }

    public bool VendaDinheiro { get; set; }

    public decimal? ValorVendaDinheiro { get; set; }

    public short IdUtilUltAct { get; set; }

    public DateTime DtUltAct { get; set; }

    public bool? Anulado { get; set; }

    public byte? IdTipoDangGoods { get; set; }

    public bool AuditLog { get; set; }

    public bool AuditFact { get; set; }

    public bool AuditPortal { get; set; }

    public decimal? PesoOrig { get; set; }

    public decimal? PesoReal { get; set; }

    public int? IdUtilDataEntry { get; set; }

    public DateTime? DtDataEntry { get; set; }

    public string? NumDocAt { get; set; }

    public string? IdTipoHandlingCode { get; set; }

    public string? IdTipoIss { get; set; }

    public string? IdOficinaCorreos { get; set; }

    public string? IdTipoLogisticaInversa { get; set; }

    public double? M3real { get; set; }

    public double? M3orig { get; set; }
}
