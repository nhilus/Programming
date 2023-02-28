﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class TaxaCombustivelZonasT
{
    public int Id { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public bool Activo { get; set; }
}
