using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocumentosInterface
{
    public int IdCab { get; set; }

    public int IdInterface { get; set; }

    public bool? Env { get; set; }

    public DateTime? DtEnv { get; set; }

    public DateTime? DtUltAct { get; set; }
}
