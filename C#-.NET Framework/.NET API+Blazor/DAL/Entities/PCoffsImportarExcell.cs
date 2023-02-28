using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PCoffsImportarExcell
{
    public double? Cp4 { get; set; }

    public string? Entidade { get; set; }

    public string? Plataforma { get; set; }

    public string? Localidade { get; set; }

    public DateTime? Req { get; set; }

    public DateTime? CutOff1 { get; set; }

    public DateTime? CutOff2 { get; set; }

    public DateTime? Req1 { get; set; }

    public DateTime? CutOff11 { get; set; }

    public DateTime? CutOff21 { get; set; }
}
