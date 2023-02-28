using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class MaterialPedido
{
    public int Id { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtPedido { get; set; }

    public int IdCliente { get; set; }

    public string? Contacto { get; set; }

    public string? MoradaAlt { get; set; }

    public int? IdCpostalAlt { get; set; }

    public int? TelefoneAlt { get; set; }

    public int Quantidade { get; set; }

    public int IdTipoMaterial { get; set; }

    public string? Observacoes { get; set; }

    public int? QuantidadeEntregue { get; set; }

    public bool? Fechado { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public int? IGCOM2Userserta { get; set; }

    public bool? Anulado { get; set; }

    public DateTime? DtAnulacao { get; set; }

    public int? IdUtilAnulacao { get; set; }

    public DateTime? Dtscan { get; set; }

    public int? Idrota { get; set; }

    public string? Scancode { get; set; }

    public bool? Enviado { get; set; }

    public string? Assinatura { get; set; }

    public int? Idassinatura { get; set; }

    public int? IdClienteFact { get; set; }

    public decimal? ValorBase { get; set; }

    public DateTime? DtValor { get; set; }

    public int? IdUtilValor { get; set; }

    public int? IdMoeda { get; set; }

    public decimal? Cambio { get; set; }

    public decimal? TaxaIvavalorBase { get; set; }

    public int? IdTipoIvavalorBase { get; set; }

    public bool? VendaDinheiro { get; set; }

    public decimal? ValorVendaDinheiro { get; set; }

    public string? ObsVendaDinheiro { get; set; }

    public bool? FacturacaoIndividual1 { get; set; }

    public bool? ParaFacturar { get; set; }

    public DateTime? DtParaFacturar { get; set; }

    public int? IdUtilParaFacturar { get; set; }

    public bool? ValidToFact { get; set; }

    public DateTime? DtValidToFact { get; set; }

    public int? IdUtilValidToFact { get; set; }

    public bool? ExpToFact { get; set; }

    public DateTime? DtExpToFact { get; set; }

    public int? IdUtilExpToFact { get; set; }

    public bool? Fact { get; set; }

    public DateTime? DtFact { get; set; }

    public bool? FacturacaoIndividual { get; set; }

    public int IdEntidade { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }

    public DateTime? DtEntregue { get; set; }

    public string? SignEntregue { get; set; }

    public DateTime? DtRecolhido { get; set; }

    public string? SignRecolhido { get; set; }

    public bool? EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdCliMoradaFact { get; set; }

    public int? IdManifesto { get; set; }

    public string? CodIva { get; set; }

    public byte? IdIvaReg { get; set; }

    public int? IdJustificacao { get; set; }
}
