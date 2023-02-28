using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Cotacao
{
    public int Id { get; set; }

    public DateTime DtPedido { get; set; }

    public int IdUtilPedido { get; set; }

    public DateTime DtCotacao { get; set; }

    public int IdCliente { get; set; }

    public string? ContactoCot { get; set; }

    public string? MoradaCot { get; set; }

    public int? IdCpostal { get; set; }

    public int? TelefoneCot { get; set; }

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

    public DateTime HoraFecho { get; set; }

    public DateTime HoraDisponivel { get; set; }

    public string? Observacoes { get; set; }

    public bool? Fixo { get; set; }

    public int? IdRota { get; set; }

    public DateTime? HoraAtribuicao { get; set; }

    public int? IdUtilAtribuicao { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public bool? Enviado { get; set; }

    public DateTime? DtEnviado { get; set; }

    public bool EnviadoMan { get; set; }

    public DateTime? DtEnviadoMan { get; set; }

    public int? IdUtilEnviadoMan { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? Dtrecolhido { get; set; }

    public int? IdUtilRecolhido { get; set; }

    public string? Scancode { get; set; }

    public int? IdDistribuidor { get; set; }

    public int? IdServico { get; set; }

    public bool? DangerousGoods { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdTipoDangGoods { get; set; }

    public int? IdPlataforma { get; set; }

    public int? IdSegmento { get; set; }

    public int? NumeroEnvios { get; set; }

    public int? IdTratamento { get; set; }

    public bool? TrataVolume { get; set; }

    public int? NifCot { get; set; }

    public int? IdGps { get; set; }

    public bool ValorManual { get; set; }

    public int? IdPaisOrigem { get; set; }

    public string? LocalidadeCot { get; set; }

    public bool RecolhaRemota { get; set; }

    public string? RefShipper { get; set; }

    public int? IdCliMorada { get; set; }

    public short? IdClasseOrigem { get; set; }

    public string? DepartamentoFact { get; set; }

    public decimal? PesoVolumetrico { get; set; }

    public decimal? M3 { get; set; }

    public int? IdCliMoradaPaga { get; set; }

    public string? EmpresaAlt { get; set; }

    public int? IdPaisPaga { get; set; }

    public bool? Fif { get; set; }

    public int? IdOrigem { get; set; }

    public int? IdMotivo { get; set; }

    public int? IdTipoIss { get; set; }

    public int? IdDestinatario { get; set; }
}
