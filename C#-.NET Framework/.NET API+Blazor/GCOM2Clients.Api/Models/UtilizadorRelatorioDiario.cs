using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorRelatorioDiario
{
    public int Id { get; set; }

    public DateTime DtIni { get; set; }

    public DateTime? DtFim { get; set; }

    public int KmsIni { get; set; }

    public int? KmsFim { get; set; }

    public int? IdViatura { get; set; }

    public int? IdRota { get; set; }

    public int IdUtil { get; set; }

    public DateTime DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public string? Matricula { get; set; }

    public DateTime? DtUltAct { get; set; }

    public int? IdUtilUltAct { get; set; }

    public int? IdServicoEspecial { get; set; }

    public int? IdModoTransporte { get; set; }
}
