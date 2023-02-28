using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class Viatura
{
    public int Id { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtInicioContrato { get; set; }

    public DateTime? DtFimContrato { get; set; }

    public int? IdTipoContrato { get; set; }

    public int? DuracaoContrato { get; set; }

    public int? KmsContrato { get; set; }

    public int? IdCombustivel { get; set; }

    public string? Codigo { get; set; }

    public string? Matricula { get; set; }

    public string? Modelo { get; set; }

    public short? Cilindrada { get; set; }

    public int? CapacidadeKg { get; set; }

    public int? CapacidadeM3 { get; set; }

    public bool? Publicidade { get; set; }

    public decimal? ValorCompra { get; set; }

    public DateTime? DtViaverde { get; set; }

    public decimal? CustoPneusKm { get; set; }

    public decimal? CustoPortagensMes { get; set; }

    public decimal? CustoSeguroMes { get; set; }

    public decimal? CustoRendaMes { get; set; }

    public decimal? CustoTelemovelMes { get; set; }

    public decimal? CustoSmsMes { get; set; }

    public int? DuracaoPneusKms { get; set; }

    public decimal? ConsumoMedio { get; set; }

    public int? Lotacao { get; set; }

    public string? Observacoes { get; set; }

    public double? PesoMin { get; set; }

    public double? PesoMax { get; set; }

    public double? VolMinM3 { get; set; }

    public double? VolMaxM3 { get; set; }

    public int? EnviosMin { get; set; }

    public int? EnviosMax { get; set; }

    public double? VolMin { get; set; }

    public double? VolMax { get; set; }

    public int? IdUtilizador { get; set; }

    public int? IdPlataforma { get; set; }

    public bool? Activo { get; set; }

    public int? IdEntidade { get; set; }

    public bool EnvInterface { get; set; }

    public DateTime? DtEnvInterface { get; set; }

    public int? IdTipoViatura { get; set; }

    public int? IdCliente { get; set; }
}
