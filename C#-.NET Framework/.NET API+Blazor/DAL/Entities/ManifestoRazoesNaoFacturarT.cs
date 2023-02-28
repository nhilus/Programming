﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoRazoesNaoFacturarT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int IdEntidade { get; set; }

    public int IdRegime { get; set; }

    public bool Activo { get; set; }
}