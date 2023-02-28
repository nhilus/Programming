using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class PacReclamaco
{
    public int Id { get; set; }

    public int IdPac { get; set; }

    public int IdReclamacao { get; set; }

    public int? IdStatusReclama { get; set; }

    public int? IdStatusReocorre { get; set; }

    public int IdEntidade { get; set; }

    public DateTime? DtIntrod { get; set; }

    public int? IdUtilIntrod { get; set; }
}
