﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class DocServerTiposT
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }
}