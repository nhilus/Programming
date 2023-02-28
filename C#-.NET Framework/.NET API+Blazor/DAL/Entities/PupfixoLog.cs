using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PupfixoLog
{
    public int Id { get; set; }

    public int IdPupFixo { get; set; }

    public int IdUtil { get; set; }

    public DateTime Data { get; set; }

    public string? Observacoes { get; set; }
}
