﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class PacReclamacoesStatusT
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;
}
