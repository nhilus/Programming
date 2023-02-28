using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Alertum
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int IdTipoAlerta { get; set; }

    public DateTime DtCriacao { get; set; }

    public int IdUtilCriacao { get; set; }

    public DateTime DtAlerta { get; set; }

    public int? NumDiasAlerta { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCliMorada { get; set; }

    public byte? IdEntidade { get; set; }
}
