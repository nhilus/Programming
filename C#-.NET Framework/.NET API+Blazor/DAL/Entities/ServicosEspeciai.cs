using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ServicosEspeciai
{
    public int Id { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdAgente { get; set; }

    public int? IdMotorista { get; set; }

    public string? IdRota { get; set; }

    public string? Matricula { get; set; }

    public int? KmsIni { get; set; }

    public int? KmsFim { get; set; }

    public string? Descricao { get; set; }

    public decimal? CustoTotal { get; set; }

    public decimal? Proveito { get; set; }

    public bool? FacturarFedex { get; set; }

    public int? IdClienteFactura { get; set; }

    public string? Obs { get; set; }

    public bool? ServicoExtraordinario { get; set; }

    public int? IdUtilIntrod { get; set; }

    public DateTime? DtIntrod { get; set; }

    public decimal? CustoExtra { get; set; }

    public int? IdCliMoradaFact { get; set; }
}
