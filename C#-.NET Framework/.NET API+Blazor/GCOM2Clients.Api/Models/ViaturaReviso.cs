using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class ViaturaReviso
{
    public int Id { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }

    public int IdViatura { get; set; }

    public DateTime? DtMarcada { get; set; }

    public int? IdTipoManutencao { get; set; }

    public string? ObsMarcada { get; set; }

    public bool? Programada { get; set; }

    public int? IdCondutor { get; set; }

    public string? ObsEfectuada { get; set; }

    public decimal? Custo { get; set; }

    public DateTime? DtEfectuada { get; set; }

    public int? IdUtilFecho { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IGCOM2Userserta { get; set; }
}
