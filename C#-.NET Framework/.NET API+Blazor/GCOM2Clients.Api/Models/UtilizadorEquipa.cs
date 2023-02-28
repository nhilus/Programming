using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class UtilizadorEquipa
{
    public short Id { get; set; }

    public string? Sigla { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdUtilTelesale { get; set; }

    public int IdUtilVendedor { get; set; }

    public int? IdutilController { get; set; }

    public int? IdUtilControllerTsr { get; set; }

    public int? IdUtilControllerAe { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public int Activa { get; set; }

    public int? IdPlataforma { get; set; }

    public byte IdPlataformaReg { get; set; }

    public DateTime? DtUltAct { get; set; }

    public short? IdUtilUltAct { get; set; }

    public int? IdDinamicaComercial { get; set; }

    public bool? IsForcedAe { get; set; }
}
