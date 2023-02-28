using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class IvaCodigoIsencaoT
{
    public int Id { get; set; }

    public int IdTipoIva { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int? IdRegime { get; set; }

    public bool? Ec { get; set; }

    public int? IdEntidade { get; set; }

    public int? IdIvaReg { get; set; }

    public int? Activo { get; set; }
}
