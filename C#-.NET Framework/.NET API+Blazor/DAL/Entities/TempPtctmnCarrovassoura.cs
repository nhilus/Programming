using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TempPtctmnCarrovassoura
{
    public string? Empresa { get; set; }

    public string? Transportador { get; set; }

    public string? ArmazémExpedidor { get; set; }

    public double? Ano { get; set; }

    public string? Mês { get; set; }

    public string? NMes { get; set; }

    public string? NúmeroDeOrdem { get; set; }

    public string? NúmeroDeRemessa { get; set; }

    public string? NúmeroDeObjecto { get; set; }

    public string? TpServ { get; set; }

    public DateTime? DataSm { get; set; }

    public string? DMax { get; set; }

    public string? Dept { get; set; }

    public string? Obs { get; set; }

    public string? Resolvido { get; set; }
}
