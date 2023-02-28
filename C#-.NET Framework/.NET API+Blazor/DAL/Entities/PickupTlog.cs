using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PickupTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public int Id { get; set; }

    public DateTime DtPedido { get; set; }

    public int IdUtilPedido { get; set; }

    public DateTime DtPup { get; set; }

    public int IdCliente { get; set; }

    public string? ContactoPup { get; set; }

    public string? MoradaPup { get; set; }

    public int? IdCpostal { get; set; }

    public int? TelefonePup { get; set; }

    public string? EmpresaDest { get; set; }

    public string? ContactoDest { get; set; }

    public int? TelefoneDest { get; set; }

    public string? MoradaDest { get; set; }

    public string? LocalidadeDest { get; set; }

    public int? IdCpostalDest { get; set; }

    public string? CpostalDest { get; set; }

    public int IdPaisDestino { get; set; }

    public int IdTipoProduto { get; set; }

    public int NumeroVolumes { get; set; }

    public decimal? Comprimento { get; set; }

    public decimal? Largura { get; set; }

    public decimal? Altura { get; set; }

    public decimal Peso { get; set; }

    public int? ContaFedEx { get; set; }

    public string? Nifpagamento { get; set; }

    public int? IdLocalPagamento { get; set; }

    public decimal? ValorPrevisto { get; set; }

    public bool VendaDinheiro { get; set; }

    public bool? Seguro { get; set; }

    public decimal? ValorSegurado { get; set; }

    public decimal? ValorReembolso { get; set; }

    public bool? Fef { get; set; }

    public bool? Americangold { get; set; }

    public bool? Daa { get; set; }

    public DateTime HoraFecho { get; set; }

    public DateTime HoraDisponivel { get; set; }

    public string? Observacoes { get; set; }

    public bool? Fixo { get; set; }

    public int? IdRota { get; set; }

    public DateTime? HoraAtribuicao { get; set; }

    public int? IdUtilAtribuicao { get; set; }

    public int? IdAlerta { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public bool? Enviado { get; set; }

    public DateTime? DtEnviado { get; set; }

    public bool? EnviadoMan { get; set; }

    public DateTime? DtEnviadoMan { get; set; }

    public int? IdUtilEnviadoMan { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? Dtrecolhido { get; set; }

    public string? Scancode { get; set; }

    public int? IdDistribuidor { get; set; }

    public int? IdServico { get; set; }

    public bool? DangerousGoods { get; set; }

    public int? IdPickupRdom { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public bool? EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdTipoDangGoods { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdSegmento { get; set; }

    public int? NumeroEnvios { get; set; }

    public int? IdPickupOrigem { get; set; }

    public int? IdTratamento { get; set; }

    public int? IdCliMorada { get; set; }

    public string? RefShipper { get; set; }

    public short? IdClasseOrigem { get; set; }

    public string? DepartamentoFact { get; set; }

    public string? EmpresaAlt { get; set; }

    public bool? Fif { get; set; }

    public string? CommentScan { get; set; }

    public int? IdDestinatario { get; set; }

    public string? CamposObrigatorios { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public decimal? M3 { get; set; }
}
