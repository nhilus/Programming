﻿using System;
using System.Collections.Generic;

namespace GCOM2Users.Models;

public partial class EntrevistaResultadosT
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Descricao { get; set; }
}