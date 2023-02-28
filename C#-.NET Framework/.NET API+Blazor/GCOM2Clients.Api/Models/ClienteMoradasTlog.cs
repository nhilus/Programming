using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ClienteMoradasTlog
{
    public int IdTrigger { get; set; }

    public DateTime DtTrigger { get; set; }

    public int Id { get; set; }

    public int IdEntidade { get; set; }

    public int IdCliente { get; set; }

    public int? IdStComercial { get; set; }

    public int? IdStCredito { get; set; }

    public int? IdEquipaComercial { get; set; }

    public int? IdTipoCliente { get; set; }

    public int? IdLoja { get; set; }

    public int? IdConcorrente { get; set; }

    public int? IdMotivo { get; set; }

    public int? IdCampanhaMkt { get; set; }

    public int? IdTipoAcomp { get; set; }

    public int? IdUtilAcomp { get; set; }

    public DateTime? DtUtilAcomp { get; set; }

    public short? PeriodicidadeFacturacao { get; set; }

    public bool? FacturasIndividuais { get; set; }

    public bool? TemDebDir { get; set; }

    public string? NibDebDir { get; set; }

    public string? RefDebDir { get; set; }

    public bool? FactDetalhada { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public int? IdCliMoradaEmissao { get; set; }

    public bool? QuebraFactServico { get; set; }

    public bool? QuebraFactDepart { get; set; }

    public bool? QuebraFactClassOri { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public bool? TemSisShip { get; set; }

    public DateTime? DtSisShip { get; set; }

    public int? IdMotivoSisShip { get; set; }

    public string? ObsSisShip { get; set; }

    public bool? Booking { get; set; }

    public bool? RecebeDescarga { get; set; }

    public bool? IsGlobalAccount { get; set; }

    public bool? IsGrandeConta { get; set; }

    public DateTime? DtGrandeConta { get; set; }

    public bool? TemTxDespAlfPer { get; set; }

    public decimal? TxDespAlfPer { get; set; }

    public string? Nome { get; set; }

    public string? Morada { get; set; }

    public int? IdCpostal { get; set; }

    public string? Cpostal { get; set; }

    public string? Localidade { get; set; }

    public int? IdPais { get; set; }

    public string? Observacoes { get; set; }

    public bool? IsDefault { get; set; }

    public byte? Activo { get; set; }

    public TimeSpan? HoraDisponivel { get; set; }

    public TimeSpan? HoraFecho { get; set; }

    public string? CoordGps { get; set; }

    public bool? IsMoradaEntrevista { get; set; }

    public bool? IsMoradaRecolha { get; set; }

    public bool? IsMoradaEntrega { get; set; }

    public bool? IsMoradaFact { get; set; }

    public string? NumConta { get; set; }

    public bool? IsGestaoIndependente { get; set; }

    public int? IdStatusCreditoAdua { get; set; }

    public bool? TemInsight { get; set; }

    public DateTime? DtInsight { get; set; }

    public int? IdMotivoInsight { get; set; }

    public string? ObsInsight { get; set; }

    public decimal? DescTxCombCusto { get; set; }

    public decimal? NovoDescTxCombCusto { get; set; }

    public DateTime? DtNovoDescTxCombCusto { get; set; }

    public int? IdTipoInstalacao { get; set; }

    public int? IdCliMoradaReembolso { get; set; }
}
