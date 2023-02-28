using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Tarifa
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }

    public DateTime DtIntrod { get; set; }

    public int IdUtilIntrod { get; set; }

    public DateTime DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int? IdEntidade { get; set; }

    public int IdTarifaTipo { get; set; }

    public int? IdRegime { get; set; }

    public int? IdServico { get; set; }

    public int? IdServicoDet { get; set; }

    public int? IdTipoIncidencia { get; set; }

    public decimal UnidArredondaVariavel { get; set; }

    /// <summary>
    /// disponível apenas para cliente seleccionado
    /// </summary>
    public int? IdCliente { get; set; }

    public decimal? FactEsperada { get; set; }

    public decimal? FactMinEsperada { get; set; }

    public decimal? FactMaxEsperada { get; set; }

    public bool Valida { get; set; }

    public DateTime? DtValida { get; set; }

    public int? IdUtilValida { get; set; }

    public bool TabEmpresa { get; set; }

    public bool Default { get; set; }

    public DateTime? DtInicioDef { get; set; }

    public DateTime? DtFimDef { get; set; }

    public bool TabAutoDefault { get; set; }

    public bool? Activa { get; set; }

    public bool? Visivel { get; set; }

    public bool IsSimulavel { get; set; }

    public int? IdCliMorada { get; set; }

    public int? IdFicheiro { get; set; }

    public int? IdUtilMotorista { get; set; }

    public int? IdRota { get; set; }

    public int? IdMoeda { get; set; }
}
