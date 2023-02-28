using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class GuiaRemessaDigitalizacaoControlo
{
    public int Id { get; set; }

    public string Gr { get; set; } = null!;

    public int? IdManifesto { get; set; }

    public int? NumPaginas { get; set; }

    public int? NumDocAdos { get; set; }

    public bool? Processada { get; set; }

    public DateTime? Dtprocessada { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilUltAct { get; set; }

    public DateTime? DtUltAct { get; set; }
}
