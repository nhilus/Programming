﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class ManifestoCustosTiposT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public int Sinal { get; set; }
}
