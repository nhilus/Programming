using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaSugestaoLog
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public byte IdEntidade { get; set; }

    public short IdEntrevistaTipo { get; set; }

    public int? IdEsvvalorizacoesLog { get; set; }

    public DateTime DtIntrod { get; set; }

    public short? IdUtilIntrod { get; set; }

    public short? IdCriterio { get; set; }

    public string? ObsSugestao { get; set; }

    public short IdUtilResp { get; set; }

    public DateTime? DtAgendada { get; set; }

    public int? IdEntrevista { get; set; }

    public DateTime? DtFecho { get; set; }

    public short? IdUtilFecho { get; set; }

    public byte? IdTipoFecho { get; set; }

    public string? ObsFecho { get; set; }
}
