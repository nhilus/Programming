using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class UtilizadorExcepcao
{
    public int Id { get; set; }

    public DateTime Data { get; set; }

    public DateTime Duracao { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdUtil { get; set; }

    public DateTime? DtIntrod { get; set; }
}
