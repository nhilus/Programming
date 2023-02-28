using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class LineHaulTemplate
{
    public int Id { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public string? Descricao { get; set; }

    public int? IdTipo { get; set; }

    public string? Master { get; set; }

    public string? Referencia { get; set; }

    public int? IdPlataformaOrigem { get; set; }

    public int? IdPlataformaDestino { get; set; }

    public bool? IdaVolta { get; set; }

    public decimal? Custo { get; set; }

    public int? IdClientePagamento { get; set; }

    public decimal? Proveito { get; set; }

    public bool? FacturarFedex { get; set; }

    public int? IdClienteFactura { get; set; }

    public bool? VendaDinheiro { get; set; }

    public string? ObsVendaDinheiro { get; set; }

    public string? Obs { get; set; }

    public string? CostCenter { get; set; }

    public bool? ServicoExtraordinario { get; set; }

    public int? IdTipoServico { get; set; }

    public int? IdLineHaul { get; set; }

    public int IdEntidade { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public bool? Activo { get; set; }

    public string? Matricula { get; set; }

    public string? MatriculaGalera { get; set; }

    public string? NomeMotorista { get; set; }

    public long? NumeroTelefone { get; set; }

    public DateTime? DataContab { get; set; }

    public decimal? CustoAdicional { get; set; }

    public string? ObservacoesCa { get; set; }

    public decimal? CustoPenaliza { get; set; }

    public string? ObservacoesPenal { get; set; }

    public decimal? CustoTotal { get; set; }
}
