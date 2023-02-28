using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CpApsCtt
{
    public string? Ep { get; set; }

    public double? ApaIni { get; set; }

    public double? ApaFim { get; set; }

    public double? Cp4Bloco { get; set; }

    public double? Cp3Bloco { get; set; }

    public string? CpalfBloco { get; set; }

    public double? Cp4Ind { get; set; }

    public double? Cp3Ind { get; set; }

    public string? CpalfInd { get; set; }
}
