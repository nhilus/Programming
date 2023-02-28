using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class TarifaTipoAgrupaRep
{
    public int Id { get; set; }

    public int IdTipoAgrupa { get; set; }

    public int IdTipoAgrupaRep { get; set; }
}
