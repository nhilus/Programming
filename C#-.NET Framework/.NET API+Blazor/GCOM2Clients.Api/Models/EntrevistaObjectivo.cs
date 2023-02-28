using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaObjectivo
{
    public int Id { get; set; }

    public int IdGrupoUtil { get; set; }

    public decimal ObjCapt { get; set; }

    public decimal ObjManut { get; set; }

    public int IdEntidade { get; set; }
}
