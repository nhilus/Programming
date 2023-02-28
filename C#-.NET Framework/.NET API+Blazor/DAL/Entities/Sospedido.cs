using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Sospedido
{
    public int Id { get; set; }

    public byte IdEntidade { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public string? Nome { get; set; }

    public string? Nif { get; set; }

    public long? ContactoTelf { get; set; }

    public string? Email { get; set; }

    public DateTime? DtRecolha { get; set; }

    public TimeSpan? HoraRecDisp { get; set; }

    public TimeSpan? HoraRecMax { get; set; }

    public string? NomeRec { get; set; }

    public long? TelefoneRec { get; set; }

    public string? EmpresaRec { get; set; }

    public string? MoradaRec { get; set; }

    public string? CpostalRec { get; set; }

    public int? IdCpostalRec { get; set; }

    public string? LocalidadeRec { get; set; }

    public int? IdPaisRec { get; set; }

    public string? EmailRec { get; set; }

    public DateTime? DtEntrega { get; set; }

    public TimeSpan? HoraEntDisp { get; set; }

    public TimeSpan? HoraEntMax { get; set; }

    public string? NomeEnt { get; set; }

    public long? TelefoneEnt { get; set; }

    public string? EmpresaEnt { get; set; }

    public string? MoradaEnt { get; set; }

    public string? CpostalEnt { get; set; }

    public int? IdCpostalEnt { get; set; }

    public string? LocalidadeEnt { get; set; }

    public int? IdPaisEnt { get; set; }

    public int? NrVolumes { get; set; }

    public decimal? PesoTotal { get; set; }

    public string? DescMercadoria { get; set; }

    public int? IdTipoViatura { get; set; }

    public int? IdTipoVia { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public string? Observacoes { get; set; }

    public int? IdEstado { get; set; }

    public int? IdMotivoRejeitado { get; set; }

    public bool EnvPropostaCliente { get; set; }

    public string? ObsRejeitado { get; set; }

    public decimal? MargemLucro { get; set; }

    public decimal? Valor { get; set; }

    public int? IdManifesto { get; set; }

    public bool Encerrado { get; set; }
}
