using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class AlertaDetalhe
{
    public int Id { get; set; }

    public int IGCOM2Userserta { get; set; }

    public int? IdDeptDestino { get; set; }

    public int? IdUtilDestino { get; set; }

    public DateTime? DtFecho { get; set; }

    public int? IdUtilFecho { get; set; }

    public bool Fechado { get; set; }
}
