﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class CodigosPostaisCompromissoT
{
    public int IdEntidade { get; set; }

    public string Cp4 { get; set; } = null!;

    public short IdPais { get; set; }

    public int? IdServico { get; set; }

    public DateTime HoraLimite { get; set; }
}
